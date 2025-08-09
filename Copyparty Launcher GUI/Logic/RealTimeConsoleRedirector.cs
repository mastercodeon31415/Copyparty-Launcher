using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Copyparty_Launcher_GUI.Logic
{
    public class RealTimeConsoleRedirector : IDisposable
    {
        private readonly RichTextBox _outputBox;
        private readonly Process _process;
        private readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        // A buffer to handle text chunks that might end in the middle of an ANSI escape code.
        private string _stdOutBuffer = "";
        private string _stdErrBuffer = "";
        private object _lock = new object();

        private static readonly Dictionary<string, Color> AnsiColorMap = new Dictionary<string, Color>
    {
        // Standard Colors
        { "30", Color.Black },
        { "31", Color.DarkRed },
        { "32", Color.DarkGreen },
        { "33", Color.DarkGoldenrod },
        { "34", Color.DarkBlue },
        { "35", Color.DarkMagenta },
        { "36", Color.DarkCyan },
        { "37", Color.Gray },
        // Bright Colors
        { "90", Color.DarkGray },
        { "91", Color.Red },
        { "92", Color.Green },
        { "93", Color.Yellow },
        { "94", Color.Blue },
        { "95", Color.Magenta },
        { "96", Color.Cyan },
        { "97", Color.White }
    };

        public RealTimeConsoleRedirector(RichTextBox outputBox, string executablePath, string arguments)
        {
            _outputBox = outputBox;

            _process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = executablePath,
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    // Use UTF8 encoding for better character support
                    StandardOutputEncoding = Encoding.UTF8,
                    StandardErrorEncoding = Encoding.UTF8
                },
                EnableRaisingEvents = true
            };
        }

        public void Start()
        {
            _process.Start();

            // Start async tasks to redirect stdout and stderr
            Task.Run(() => RedirectStreamAsync(_process.StandardOutput, _stdOutBuffer, _outputBox.ForeColor, _cancellationTokenSource.Token));
            Task.Run(() => RedirectStreamAsync(_process.StandardError, _stdErrBuffer, Color.Red, _cancellationTokenSource.Token));
        }

        public void Stop()
        {
            _cancellationTokenSource.Cancel();
            try
            {
                if (!_process.HasExited)
                {
                    // A more graceful shutdown attempt
                    _process.CloseMainWindow();
                    if (!_process.WaitForExit(1000))
                    {
                        _process.Kill();
                    }
                }
            }
            catch (Exception)
            {
                // Ignore exceptions during shutdown
            }
        }

        private async Task RedirectStreamAsync(StreamReader streamReader, string streamBuffer, Color defaultColor, CancellationToken token)
        {
            var buffer = new char[1024];
            while (!token.IsCancellationRequested)
            {
                try
                {
                    int bytesRead = await streamReader.ReadAsync(buffer, 0, buffer.Length);
                    if (bytesRead > 0)
                    {
                        string text = new string(buffer, 0, bytesRead);
                        lock (_lock)
                        {
                            // Prepend any leftover text from the previous read
                            streamBuffer += text;
                            // Process the complete text chunks and leave any partial ones in the buffer
                            ProcessBuffer(ref streamBuffer, defaultColor);
                        }
                    }
                    else
                    {
                        // Stream has ended
                        await Task.Delay(100, token); // Wait a bit before breaking
                        if (_process.HasExited) break;
                    }
                }
                catch (OperationCanceledException)
                {
                    break; // Task was cancelled
                }
                catch (Exception)
                {
                    break; // An error occurred, such as stream closed
                }
            }
        }

        private void ProcessBuffer(ref string buffer, Color defaultColor)
        {
            // Regex to find ANSI escape codes. \x1B is the ESC character.
            var regex = new Regex(@"\x1B\[[;\d]*m");
            int lastIndex = 0;
            Color currentColor = defaultColor;

            // Process all matches in the current buffer
            foreach (Match match in regex.Matches(buffer))
            {
                // Append text that came before this match
                string plainText = buffer.Substring(lastIndex, match.Index - lastIndex);
                AppendTextWithColor(plainText, currentColor);

                // Process the escape code
                string code = match.Value.Trim(new char[] { '\x1B', '[', 'm' });
                if (string.IsNullOrEmpty(code) || code == "0")
                {
                    currentColor = defaultColor;
                }
                else if (AnsiColorMap.TryGetValue(code, out Color newColor))
                {
                    currentColor = newColor;
                }
                lastIndex = match.Index + match.Length;
            }

            // After processing all matches, the remainder of the string is the new buffer content.
            // This handles cases where a chunk ends mid-escape-sequence.
            string remainingText = buffer.Substring(lastIndex);
            AppendTextWithColor(remainingText, currentColor);

            // For simplicity in this example, we clear the buffer and append the final colored text.
            // A more complex implementation could keep partial escape codes.
            buffer = "";
        }


        private void AppendTextWithColor(string text, Color color)
        {
            if (string.IsNullOrEmpty(text)) return;

            // Ensure this runs on the UI thread
            _outputBox.Invoke((Action)(() =>
            {
                _outputBox.SelectionStart = _outputBox.TextLength;
                _outputBox.SelectionLength = 0;
                _outputBox.SelectionColor = color;
                _outputBox.AppendText(text);
                _outputBox.SelectionColor = _outputBox.ForeColor; // Reset to default
                _outputBox.ScrollToCaret();
            }));
        }

        public void Dispose()
        {
            Stop();
            _process?.Dispose();
            _cancellationTokenSource?.Dispose();
        }
    }
}
