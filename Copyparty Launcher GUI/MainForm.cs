using Copyparty_Launcher_GUI.Forms;
using Copyparty_Launcher_GUI.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NativeDarkMode_Lib;

namespace Copyparty_Launcher_GUI
{
    public partial class MainForm : Form
    {
        private AppSettings _appSettings;
        private bool _isInitializing = true;

        public MainForm()
        {
            // OG SIZE: 810, 502
            InitializeComponent();
            _appSettings = SettingsManager.Load();

            NativeDarkMode_Lib.Converter.DarkModeEnable(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetupGrids();
            UpdateUiFromSettings();
            AddAutoSaveHandlers();
            this.FormClosing += (s, ee) => SaveAllSettings();
            _isInitializing = false;
        }

        #region Auto-Saving

        private void AddAutoSaveHandlers()
        {
            var textBoxes = new List<TextBox> { txtCopyPartyPath, txtServerName, txtIp, txtPort, txtCertPath, txtThSize, txtBanPw, txtBan403, txtLogFile, txtZmsSvc, txtZsLoc };
            foreach (var txt in textBoxes)
            {
                txt.TextChanged += (s, e) => SaveAllSettings();
            }

            var numerics = new List<NumericUpDown> { numMaxClients, numCpuCores, numRescan, numFtpPort, numFtpsPort, numMcHop, numZmSpam };
            foreach (var num in numerics)
            {
                num.ValueChanged += (s, e) => SaveAllSettings();
            }

            var checkBoxes = new List<CheckBox>
            {
                chkUsernames, chkEnableDots, chkRMagic, chkReuseAddr, chkHttpOnly, chkHttpsOnly,
                chkDotPart, chkDedup, chkHardlink, chkReflink, chkNoDupe,
                chkE2D, chkE2DS, chkE2DSA, chkE2T, chkE2TS, chkE2TSR,
                chkNoThumb, chkNoVThumb, chkNoAThumb, chkDav, chkDavInf,
                chkSafety1, chkSafety2, chkSafety3, chkXVol, chkXDev,
                chkGrid, chkLocaltime, chkNoBranding, chkQuiet, chkLogConn,
                chkZeroconf, chkQrCode, chkZVerbose, chkZm, chkZm4, chkZm6, chkZmVerbose, chkZs, chkZsVerbose, redirectOutputBox
            };
            foreach (var chk in checkBoxes)
            {
                chk.CheckedChanged += (s, e) => SaveAllSettings();
            }
        }

        private void SaveAllSettings()
        {
            if (_isInitializing) return;
            UpdateSettingsFromUi();
            SettingsManager.Save(_appSettings);
            lblStatus.Text = "Settings auto-saved.";
        }
        #endregion

        #region UI and Data Handling
        private void UpdateUiFromSettings()
        {
            var cfg = _appSettings.PartyConfig;
            txtCopyPartyPath.Text = _appSettings.CopyPartyExePath;

            // General
            numMaxClients.Value = cfg.MaxClients;
            numCpuCores.Value = cfg.Cores;
            txtServerName.Text = cfg.ServerName;
            chkUsernames.Checked = cfg.Usernames;
            chkEnableDots.Checked = cfg.EnableDots;
            chkRMagic.Checked = cfg.RMagic;
            redirectOutputBox.Checked = cfg.redirectOutput;

            // Network
            txtIp.Text = cfg.Ip;
            txtPort.Text = cfg.Port;
            chkReuseAddr.Checked = cfg.ReuseAddr;

            // Discovery Tab
            chkQrCode.Checked = cfg.EnableQrCode;
            chkZeroconf.Checked = cfg.EnableZeroconf;
            chkZVerbose.Checked = cfg.ZVerbose;
            numMcHop.Value = cfg.McHopSec;
            chkZm.Checked = cfg.Zm;
            chkZm4.Checked = cfg.Zm4;
            chkZm6.Checked = cfg.Zm6;
            chkZmVerbose.Checked = cfg.Zmv;
            txtZmsSvc.Text = cfg.ZmsServices;
            numZmSpam.Value = (decimal)cfg.ZmSpamSec;
            chkZs.Checked = cfg.Zs;
            chkZsVerbose.Checked = cfg.Zsv;
            txtZsLoc.Text = cfg.ZsLocation;

            // Uploads
            chkDotPart.Checked = cfg.DotPart;
            chkDedup.Checked = cfg.Dedup;
            chkHardlink.Checked = cfg.Hardlink;
            chkReflink.Checked = cfg.Reflink;
            chkNoDupe.Checked = cfg.NoDupe;

            // DB & Thumbs
            chkE2D.Checked = cfg.EnableE2D;
            chkE2DS.Checked = cfg.EnableE2DS;
            chkE2DSA.Checked = cfg.EnableE2DSA;
            chkE2T.Checked = cfg.EnableE2T;
            chkE2TS.Checked = cfg.EnableE2TS;
            chkE2TSR.Checked = cfg.EnableE2TSR;
            numRescan.Value = cfg.RescanMaxAge;
            chkNoThumb.Checked = cfg.NoThumb;
            chkNoVThumb.Checked = cfg.NoVThumb;
            chkNoAThumb.Checked = cfg.NoAThumb;
            txtThSize.Text = cfg.ThSize;

            // Protocols
            numFtpPort.Value = cfg.FtpPort;
            numFtpsPort.Value = cfg.FtpsPort;
            chkDav.Checked = cfg.Dav;
            chkDavInf.Checked = cfg.DavInf;

            // Security
            chkSafety1.Checked = cfg.Safety1;
            chkSafety2.Checked = cfg.Safety2;
            chkSafety3.Checked = cfg.Safety3;
            chkXVol.Checked = cfg.XVol;
            chkXDev.Checked = cfg.XDev;
            txtBanPw.Text = cfg.BanPw;
            txtBan403.Text = cfg.Ban403;

            // SSL
            chkHttpOnly.Checked = cfg.HttpOnly;
            chkHttpsOnly.Checked = cfg.HttpsOnly;
            txtCertPath.Text = cfg.CertPath;

            // UI
            chkGrid.Checked = cfg.Grid;
            chkLocaltime.Checked = cfg.LocalTime;
            chkNoBranding.Checked = cfg.NoBranding;

            // Logging
            chkQuiet.Checked = cfg.Quiet;
            txtLogFile.Text = cfg.LogFile;
            chkLogConn.Checked = cfg.LogConn;
        }

        private void UpdateSettingsFromUi()
        {
            var cfg = _appSettings.PartyConfig;
            _appSettings.CopyPartyExePath = txtCopyPartyPath.Text;

            // General
            cfg.MaxClients = (int)numMaxClients.Value;
            cfg.Cores = (int)numCpuCores.Value;
            cfg.ServerName = txtServerName.Text;
            cfg.Usernames = chkUsernames.Checked;
            cfg.EnableDots = chkEnableDots.Checked;
            cfg.RMagic = chkRMagic.Checked;
            cfg.redirectOutput = redirectOutputBox.Checked;

            // Network
            cfg.Ip = txtIp.Text;
            cfg.Port = txtPort.Text;
            cfg.ReuseAddr = chkReuseAddr.Checked;

            // Discovery Tab
            cfg.EnableQrCode = chkQrCode.Checked;
            cfg.EnableZeroconf = chkZeroconf.Checked;
            cfg.ZVerbose = chkZVerbose.Checked;
            cfg.McHopSec = (int)numMcHop.Value;
            cfg.Zm = chkZm.Checked;
            cfg.Zm4 = chkZm4.Checked;
            cfg.Zm6 = chkZm6.Checked;
            cfg.Zmv = chkZmVerbose.Checked;
            cfg.ZmsServices = txtZmsSvc.Text;
            cfg.ZmSpamSec = (double)numZmSpam.Value;
            cfg.Zs = chkZs.Checked;
            cfg.Zsv = chkZsVerbose.Checked;
            cfg.ZsLocation = txtZsLoc.Text;

            // Uploads
            cfg.DotPart = chkDotPart.Checked;
            cfg.Dedup = chkDedup.Checked;
            cfg.Hardlink = chkHardlink.Checked;
            cfg.Reflink = chkReflink.Checked;
            cfg.NoDupe = chkNoDupe.Checked;

            // DB & Thumbs
            cfg.EnableE2D = chkE2D.Checked;
            cfg.EnableE2DS = chkE2DS.Checked;
            cfg.EnableE2DSA = chkE2DSA.Checked;
            cfg.EnableE2T = chkE2T.Checked;
            cfg.EnableE2TS = chkE2TS.Checked;
            cfg.EnableE2TSR = chkE2TSR.Checked;
            cfg.RescanMaxAge = (int)numRescan.Value;
            cfg.NoThumb = chkNoThumb.Checked;
            cfg.NoVThumb = chkNoVThumb.Checked;
            cfg.NoAThumb = chkNoAThumb.Checked;
            cfg.ThSize = txtThSize.Text;

            // Protocols
            cfg.FtpPort = (int)numFtpPort.Value;
            cfg.FtpsPort = (int)numFtpsPort.Value;
            cfg.Dav = chkDav.Checked;
            cfg.DavInf = chkDavInf.Checked;

            // Security
            cfg.Safety1 = chkSafety1.Checked;
            cfg.Safety2 = chkSafety2.Checked;
            cfg.Safety3 = chkSafety3.Checked;
            cfg.XVol = chkXVol.Checked;
            cfg.XDev = chkXDev.Checked;
            cfg.BanPw = txtBanPw.Text;
            cfg.Ban403 = txtBan403.Text;

            // SSL
            cfg.HttpOnly = chkHttpOnly.Checked;
            cfg.HttpsOnly = chkHttpsOnly.Checked;
            cfg.CertPath = txtCertPath.Text;

            // UI
            cfg.Grid = chkGrid.Checked;
            cfg.LocalTime = chkLocaltime.Checked;
            cfg.NoBranding = chkNoBranding.Checked;

            // Logging
            cfg.Quiet = chkQuiet.Checked;
            cfg.LogFile = txtLogFile.Text;
            cfg.LogConn = chkLogConn.Checked;
        }

        private void SetupGrids()
        {
            dgvAccounts.DataSource = _appSettings.PartyConfig.Accounts;
            dgvAccounts.AutoGenerateColumns = true;
            dgvAccounts.Columns["Username"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAccounts.Columns["Password"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvGroups.DataSource = _appSettings.PartyConfig.Groups;
            dgvGroups.AutoGenerateColumns = true;
            dgvGroups.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGroups.Columns["Members"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGroups.Columns["Members"].HeaderText = "Members (comma-separated)";

            dgvVolumes.DataSource = _appSettings.PartyConfig.Volumes;
            dgvVolumes.AutoGenerateColumns = true;
            dgvVolumes.Columns["SourcePath"].HeaderText = "Source Path";
            dgvVolumes.Columns["DestPath"].HeaderText = "Destination Path";
            dgvVolumes.Columns["SourcePath"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvVolumes.Columns["DestPath"].Width = 150;
        }

        #endregion

        #region Button Click Handlers

        private void btnBrowseExe_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog { Filter = "Executable files (*.exe)|*.exe|All files (*.*)|*.*", Title = "Select copyparty.exe" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtCopyPartyPath.Text = ofd.FileName;
                }
            }
        }

        private void btnBrowseCert_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog { Filter = "PEM files (*.pem)|*.pem|All files (*.*)|*.*", Title = "Select Certificate File" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtCertPath.Text = ofd.FileName;
                }
            }
        }

        private void btnBrowseLog_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog { Filter = "Log files (*.log, *.txt)|*.log;*.txt|All files (*.*)|*.*", Title = "Set Log File Path" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    txtLogFile.Text = sfd.FileName;
                }
            }
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            SaveAllSettings();
            string configContent = ConfigGenerator.Generate(_appSettings.PartyConfig);
            using (var sfd = new SaveFileDialog { Filter = "Config files (*.conf)|*.conf|All files (*.*)|*.*", Title = "Save Copyparty Config" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, configContent);
                    lblStatus.Text = $"Configuration exported to {Path.GetFileName(sfd.FileName)}";
                }
            }
        }

        private HighPerformanceConsoleRedirector _redirector;

        private void btnLaunchCli_Click(object sender, EventArgs e)
        {
            SaveAllSettings();
            string cliArgs = CliGenerator.Generate(_appSettings.PartyConfig);
            lblStatus.Text = "Launching with current settings via CLI...";

            if (redirectOutputBox.Checked)
            {
                // Example: Pinging Google and displaying the output
                _redirector = new HighPerformanceConsoleRedirector(serverLogBox, _appSettings.CopyPartyExePath, cliArgs);
                _redirector.Start();

                darkTabControl1.SelectedTab = serverLoggingPage;
            }
            else
            {
                ProcessManager.LaunchWithCli(_appSettings.CopyPartyExePath, cliArgs);
            }

            timer1.Start();
        }

        private void btnLaunchConfig_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog { Filter = "Config files (*.conf)|*.conf|All files (*.*)|*.*", Title = "Select a Config File to Launch" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    lblStatus.Text = $"Launching with config file {Path.GetFileName(ofd.FileName)}...";
                    ProcessManager.LaunchWithConfig(_appSettings.CopyPartyExePath, ofd.FileName);
                }
            }
        }

        #endregion

        #region List Management (Accounts, Groups, Volumes)

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            _appSettings.PartyConfig.Accounts.Add(new Account { Username = "user", Password = "password" });
            SaveAllSettings();
        }

        private void btnRemoveAccount_Click(object sender, EventArgs e)
        {
            if (dgvAccounts.CurrentRow != null && dgvAccounts.CurrentRow.Index < _appSettings.PartyConfig.Accounts.Count)
            {
                _appSettings.PartyConfig.Accounts.RemoveAt(dgvAccounts.CurrentRow.Index);
                SaveAllSettings();
            }
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            _appSettings.PartyConfig.Groups.Add(new Group { Name = "new_group", Members = "user1,user2" });
            SaveAllSettings();
        }

        private void btnRemoveGroup_Click(object sender, EventArgs e)
        {
            if (dgvGroups.CurrentRow != null && dgvGroups.CurrentRow.Index < _appSettings.PartyConfig.Groups.Count)
            {
                _appSettings.PartyConfig.Groups.RemoveAt(dgvGroups.CurrentRow.Index);
                SaveAllSettings();
            }
        }

        private void btnAddVolume_Click(object sender, EventArgs e)
        {
            var newVolume = new Volume { SourcePath = "C:\\path\\to\\share", DestPath = "/share" };
            newVolume.Permissions.Add(new Permission { Type = "r", Users = "*" });

            using (var editor = new VolumeEditorForm(newVolume))
            {
                if (editor.ShowDialog() == DialogResult.OK)
                {
                    _appSettings.PartyConfig.Volumes.Add(editor.VolumeData);
                    SaveAllSettings();
                }
            }
        }

        private void btnEditVolume_Click(object sender, EventArgs e)
        {
            if (dgvVolumes.CurrentRow == null || dgvVolumes.CurrentRow.Index >= _appSettings.PartyConfig.Volumes.Count)
            {
                MessageBox.Show("Please select a volume to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var volumeToEdit = _appSettings.PartyConfig.Volumes[dgvVolumes.CurrentRow.Index];
            using (var editor = new VolumeEditorForm(volumeToEdit))
            {
                if (editor.ShowDialog() == DialogResult.OK)
                {
                    dgvVolumes.Refresh();
                    SaveAllSettings();
                }
            }
        }

        private void btnRemoveVolume_Click(object sender, EventArgs e)
        {
            if (dgvVolumes.CurrentRow != null && dgvVolumes.CurrentRow.Index < _appSettings.PartyConfig.Volumes.Count)
            {
                _appSettings.PartyConfig.Volumes.RemoveAt(dgvVolumes.CurrentRow.Index);
                SaveAllSettings();
            }
        }

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblStatus.Text = "Ready";
            timer1.Stop();
        }
    }
}
