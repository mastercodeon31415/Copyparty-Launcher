using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Copyparty_Launcher_GUI.Logic
{
    public static class ProcessManager
    {
        public static void LaunchWithCli(string copyPartyExePath, string arguments)
        {
            if (!File.Exists(copyPartyExePath))
            {
                MessageBox.Show("copyparty.exe not found at the specified path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = copyPartyExePath,
                Arguments = arguments,
                WorkingDirectory = Path.GetDirectoryName(copyPartyExePath),
                UseShellExecute = true // Opens in a new console window
            };

            try
            {
                Process.Start(startInfo);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"Failed to start copyparty:\n{ex.Message}", "Launch Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void LaunchWithConfig(string copyPartyExePath, string configFilePath)
        {
            if (!File.Exists(copyPartyExePath))
            {
                MessageBox.Show("copyparty.exe not found at the specified path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!File.Exists(configFilePath))
            {
                MessageBox.Show("Configuration file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string arguments = $"-c \"{configFilePath}\"";
            LaunchWithCli(copyPartyExePath, arguments);
        }
    }
}
