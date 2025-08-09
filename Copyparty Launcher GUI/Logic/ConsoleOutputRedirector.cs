using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Copyparty_Launcher_GUI.Logic
{
    public class ConsoleOutputRedirector
    {
        private readonly RichTextBox _outputBox;
        private readonly Process _process;

        private static readonly Dictionary<string, Color> AnsiColorMap = new Dictionary<string, Color>
    {
        { "30", Color.Black },
        { "31", Color.Red },
        { "32", Color.Green },
        { "33", Color.Yellow },
        { "34", Color.Blue },
        { "35", Color.Magenta },
        { "36", Color.Cyan },
        { "37", Color.White },
        { "90", Color.Gray },
        { "91", Color.IndianRed },
        { "92", Color.LightGreen },
        { "93", Color.LightYellow },
        { "94", Color.LightBlue },
        { "95", Color.LightPink },
        { "96", Color.LightCyan },
        { "97", Color.WhiteSmoke }
    };

        public ConsoleOutputRedirector(RichTextBox outputBox, string executablePath, string arguments)
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
                    CreateNoWindow = true
                },
                EnableRaisingEvents = true
            };

            _process.OutputDataReceived += Process_OutputDataReceived;
            _process.ErrorDataReceived += Process_ErrorDataReceived;
        }

        public void Start()
        {
            _process.Start();
            _process.BeginOutputReadLine();
            _process.BeginErrorReadLine();
        }

        public void Stop()
        {
            if (!_process.HasExited)
            {
                _process.Kill();
            }
        }

        private void Process_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                AppendTextWithColor(e.Data, Color.Red);
            }
        }

        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                ParseAndAppend(e.Data);
            }
        }

        private void ParseAndAppend(string text)
        {
            // Regular expression to find ANSI color codes
            var regex = new Regex(@"\x1B\[(\d+;)*\d+m");
            var matches = regex.Matches(text);
            int lastIndex = 0;
            Color currentColor = _outputBox.ForeColor;

            foreach (Match match in matches)
            {
                if (match.Index > lastIndex)
                {
                    AppendTextWithColor(text.Substring(lastIndex, match.Index - lastIndex), currentColor);
                }

                string code = match.Value.Trim(new char[] { '\x1B', '[', 'm' });
                if (AnsiColorMap.TryGetValue(code, out Color newColor))
                {
                    currentColor = newColor;
                }
                else if (code == "0") // Reset
                {
                    currentColor = _outputBox.ForeColor;
                }

                lastIndex = match.Index + match.Length;
            }

            if (lastIndex < text.Length)
            {
                AppendTextWithColor(text.Substring(lastIndex), currentColor);
            }
            AppendTextWithColor(Environment.NewLine, _outputBox.ForeColor);
        }

        private void AppendTextWithColor(string text, Color color)
        {
            if (_outputBox.InvokeRequired)
            {
                _outputBox.Invoke(new Action(() => AppendTextWithColor(text, color)));
            }
            else
            {
                _outputBox.SelectionStart = _outputBox.TextLength;
                _outputBox.SelectionLength = 0;
                _outputBox.SelectionColor = color;
                _outputBox.AppendText(text);
                _outputBox.SelectionColor = _outputBox.ForeColor;
            }
        }
    }
}
