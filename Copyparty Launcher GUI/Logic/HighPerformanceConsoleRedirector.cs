using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Copyparty_Launcher_GUI.Logic
{
    public sealed class HighPerformanceConsoleRedirector : IDisposable
    {
        #region Win32 Imports for UI Optimization
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
        private const int WM_SETREDRAW = 0x0B;
        #endregion

        // Represents a piece of text with a specific color.
        private readonly struct TextSegment
        {
            public readonly string Text;
            public readonly Color Color;
            public TextSegment(string text, Color color)
            {
                Text = text;
                Color = color;
            }
        }

        private readonly RichTextBox _outputBox;
        private readonly Process _process;
        private readonly System.Windows.Forms.Timer _uiTimer;
        private readonly CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();

        // A thread-safe queue to hold text segments from the process streams.
        private readonly ConcurrentQueue<TextSegment> _segmentQueue = new ConcurrentQueue<TextSegment>();

        // A buffer to handle partial ANSI escape codes across stream reads.
        private string _currentAnsiBuffer = string.Empty;

        private static readonly Dictionary<string, Color> AnsiColorMap = new Dictionary<string, Color>
    {
        { "30", Color.Black }, { "31", Color.DarkRed }, { "32", Color.DarkGreen },
        { "33", Color.DarkGoldenrod }, { "34", Color.DarkBlue }, { "35", Color.DarkMagenta },
        { "36", Color.DarkCyan }, { "37", Color.Gray }, { "90", Color.DarkGray },
        { "91", Color.Red }, { "92", Color.Green }, { "93", Color.Yellow },
        { "94", Color.Blue }, { "95", Color.Magenta }, { "96", Color.Cyan }, { "97", Color.White }
    };

        public HighPerformanceConsoleRedirector(RichTextBox outputBox, string executablePath, string arguments)
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
                    StandardOutputEncoding = Encoding.UTF8,
                    StandardErrorEncoding = Encoding.UTF8
                },
                EnableRaisingEvents = true
            };

            // UI Timer to batch updates. Interval of 100ms is a good balance.
            _uiTimer = new System.Windows.Forms.Timer { Interval = 100 };
            _uiTimer.Tick += UiTimer_Tick;
        }

        public void Start()
        {
            _process.Start();
            _uiTimer.Start();

            // Start tasks to read stdout and stderr streams asynchronously.
            Task.Run(() => RedirectStreamAsync(_process.StandardOutput, _outputBox.ForeColor, _cancellationTokenSource.Token));
            Task.Run(() => RedirectStreamAsync(_process.StandardError, Color.Red, _cancellationTokenSource.Token));
        }

        private async Task RedirectStreamAsync(StreamReader streamReader, Color defaultColor, CancellationToken token)
        {
            var buffer = new char[1024];
            while (!token.IsCancellationRequested)
            {
                try
                {
                    int count = await streamReader.ReadAsync(buffer, 0, buffer.Length);
                    if (count == 0) break; // End of stream

                    string text = new string(buffer, 0, count);
                    ParseAndEnqueue(text, defaultColor);
                }
                catch { break; } // Exit on error or cancellation
            }
        }

        private void ParseAndEnqueue(string text, Color defaultColor)
        {
            // Prepend any leftover partial text from the previous chunk
            text = _currentAnsiBuffer + text;

            var regex = new Regex(@"\x1B\[[;\d]*m");
            int lastIndex = 0;
            Color currentColor = defaultColor;

            foreach (Match match in regex.Matches(text))
            {
                // Enqueue the text before the match
                if (match.Index > lastIndex)
                {
                    _segmentQueue.Enqueue(new TextSegment(text.Substring(lastIndex, match.Index - lastIndex), currentColor));
                }

                // Update color based on ANSI code
                string code = match.Value.Trim('\x1B', '[', 'm');
                if (string.IsNullOrEmpty(code) || code == "0")
                {
                    currentColor = defaultColor;
                }
                else if (AnsiColorMap.TryGetValue(code, out var newColor))
                {
                    currentColor = newColor;
                }

                lastIndex = match.Index + match.Length;
            }

            // Check if the text ends in the middle of an escape code
            if (lastIndex < text.Length)
            {
                _currentAnsiBuffer = text.Substring(lastIndex);
                // We can enqueue the part of the buffer that we know is complete.
                // For simplicity, we just buffer it. A more complex solution could check for partial escape codes.
                _segmentQueue.Enqueue(new TextSegment(_currentAnsiBuffer, currentColor));
                _currentAnsiBuffer = "";
            }
            else
            {
                _currentAnsiBuffer = string.Empty;
            }
        }


        private void UiTimer_Tick(object sender, EventArgs e)
        {
            if (_segmentQueue.IsEmpty) return;

            // Freeze the RichTextBox to prevent flickering and improve performance
            SendMessage(_outputBox.Handle, WM_SETREDRAW, IntPtr.Zero, IntPtr.Zero);

            // Process all segments in the queue in this batch
            while (_segmentQueue.TryDequeue(out var segment))
            {
                _outputBox.SelectionStart = _outputBox.TextLength;
                _outputBox.SelectionColor = segment.Color;
                _outputBox.AppendText(segment.Text);
            }

            // Unfreeze the RichTextBox and force a repaint
            SendMessage(_outputBox.Handle, WM_SETREDRAW, (IntPtr)1, IntPtr.Zero);
            _outputBox.Invalidate();
            _outputBox.ScrollToCaret();
        }

        public void Stop()
        {
            _uiTimer.Stop();
            _cancellationTokenSource.Cancel();

            try
            {
                if (!_process.HasExited)
                {
                    _process.Kill();
                }
            }
            catch { /* Ignore */ }
        }

        public void Dispose()
        {
            Stop();
            _process?.Dispose();
            _uiTimer?.Dispose();
            _cancellationTokenSource?.Dispose();
        }
    }
}
