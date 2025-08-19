namespace Copyparty_Launcher_GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCopyPartyPath = new System.Windows.Forms.TextBox();
            this.btnBrowseExe = new System.Windows.Forms.Button();
            this.btnLaunchCli = new System.Windows.Forms.Button();
            this.btnLaunchConfig = new System.Windows.Forms.Button();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.darkTabControl1 = new NativeDarkMode_Lib.DarkTabControl();
            this.generalPage = new NativeDarkMode_Lib.DarkTabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.redirectOutputBox = new System.Windows.Forms.CheckBox();
            this.chkRMagic = new System.Windows.Forms.CheckBox();
            this.chkEnableDots = new System.Windows.Forms.CheckBox();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numCpuCores = new System.Windows.Forms.NumericUpDown();
            this.numMaxClients = new System.Windows.Forms.NumericUpDown();
            this.chkUsernames = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkReuseAddr = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.serverLoggingPage = new NativeDarkMode_Lib.DarkTabPage();
            this.serverLogBox = new System.Windows.Forms.RichTextBox();
            this.loggingPage = new NativeDarkMode_Lib.DarkTabPage();
            this.btnBrowseLog = new System.Windows.Forms.Button();
            this.chkQuiet = new System.Windows.Forms.CheckBox();
            this.txtLogFile = new System.Windows.Forms.TextBox();
            this.chkLogConn = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.uiPage = new NativeDarkMode_Lib.DarkTabPage();
            this.chkNoBranding = new System.Windows.Forms.CheckBox();
            this.chkGrid = new System.Windows.Forms.CheckBox();
            this.chkLocaltime = new System.Windows.Forms.CheckBox();
            this.sslPage = new NativeDarkMode_Lib.DarkTabPage();
            this.btnBrowseCert = new System.Windows.Forms.Button();
            this.chkHttpOnly = new System.Windows.Forms.CheckBox();
            this.txtCertPath = new System.Windows.Forms.TextBox();
            this.chkHttpsOnly = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.secPage = new NativeDarkMode_Lib.DarkTabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBan403 = new System.Windows.Forms.TextBox();
            this.txtBanPw = new System.Windows.Forms.TextBox();
            this.chkXDev = new System.Windows.Forms.CheckBox();
            this.chkXVol = new System.Windows.Forms.CheckBox();
            this.chkSafety3 = new System.Windows.Forms.CheckBox();
            this.chkSafety2 = new System.Windows.Forms.CheckBox();
            this.chkSafety1 = new System.Windows.Forms.CheckBox();
            this.protoPage = new NativeDarkMode_Lib.DarkTabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.chkDavInf = new System.Windows.Forms.CheckBox();
            this.chkDav = new System.Windows.Forms.CheckBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.numFtpsPort = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numFtpPort = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.dbPage = new NativeDarkMode_Lib.DarkTabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtThSize = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkNoAThumb = new System.Windows.Forms.CheckBox();
            this.chkNoVThumb = new System.Windows.Forms.CheckBox();
            this.chkNoThumb = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numRescan = new System.Windows.Forms.NumericUpDown();
            this.chkE2TSR = new System.Windows.Forms.CheckBox();
            this.chkE2TS = new System.Windows.Forms.CheckBox();
            this.chkE2T = new System.Windows.Forms.CheckBox();
            this.chkE2DSA = new System.Windows.Forms.CheckBox();
            this.chkE2DS = new System.Windows.Forms.CheckBox();
            this.chkE2D = new System.Windows.Forms.CheckBox();
            this.upPage = new NativeDarkMode_Lib.DarkTabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chkReflink = new System.Windows.Forms.CheckBox();
            this.chkHardlink = new System.Windows.Forms.CheckBox();
            this.chkDedup = new System.Windows.Forms.CheckBox();
            this.chkNoDupe = new System.Windows.Forms.CheckBox();
            this.chkDotPart = new System.Windows.Forms.CheckBox();
            this.discovPage = new NativeDarkMode_Lib.DarkTabPage();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.txtZsLoc = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.chkZsVerbose = new System.Windows.Forms.CheckBox();
            this.chkZs = new System.Windows.Forms.CheckBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.numZmSpam = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.txtZmsSvc = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.chkZmVerbose = new System.Windows.Forms.CheckBox();
            this.chkZm6 = new System.Windows.Forms.CheckBox();
            this.chkZm4 = new System.Windows.Forms.CheckBox();
            this.chkZm = new System.Windows.Forms.CheckBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.numMcHop = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.chkZVerbose = new System.Windows.Forms.CheckBox();
            this.chkZeroconf = new System.Windows.Forms.CheckBox();
            this.chkQrCode = new System.Windows.Forms.CheckBox();
            this.volsPage = new NativeDarkMode_Lib.DarkTabPage();
            this.btnEditVolume = new System.Windows.Forms.Button();
            this.dgvVolumes = new System.Windows.Forms.DataGridView();
            this.btnRemoveVolume = new System.Windows.Forms.Button();
            this.btnAddVolume = new System.Windows.Forms.Button();
            this.accPage = new NativeDarkMode_Lib.DarkTabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRemoveAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnRemoveGroup = new System.Windows.Forms.Button();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.dgvGroups = new System.Windows.Forms.DataGridView();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.darkTabControl1)).BeginInit();
            this.darkTabControl1.SuspendLayout();
            this.generalPage.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCpuCores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxClients)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.serverLoggingPage.SuspendLayout();
            this.loggingPage.SuspendLayout();
            this.uiPage.SuspendLayout();
            this.sslPage.SuspendLayout();
            this.secPage.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.protoPage.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFtpsPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFtpPort)).BeginInit();
            this.dbPage.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRescan)).BeginInit();
            this.upPage.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.discovPage.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZmSpam)).BeginInit();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMcHop)).BeginInit();
            this.volsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVolumes)).BeginInit();
            this.accPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "copyparty.exe Path";
            // 
            // txtCopyPartyPath
            // 
            this.txtCopyPartyPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCopyPartyPath.Location = new System.Drawing.Point(113, 12);
            this.txtCopyPartyPath.Name = "txtCopyPartyPath";
            this.txtCopyPartyPath.Size = new System.Drawing.Size(1148, 20);
            this.txtCopyPartyPath.TabIndex = 1;
            this.txtCopyPartyPath.Text = "C:\\copyparty\\copyparty.exe";
            // 
            // btnBrowseExe
            // 
            this.btnBrowseExe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseExe.Location = new System.Drawing.Point(1267, 10);
            this.btnBrowseExe.Name = "btnBrowseExe";
            this.btnBrowseExe.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseExe.TabIndex = 2;
            this.btnBrowseExe.Text = "Browse...";
            this.btnBrowseExe.UseVisualStyleBackColor = true;
            this.btnBrowseExe.Click += new System.EventHandler(this.btnBrowseExe_Click);
            // 
            // btnLaunchCli
            // 
            this.btnLaunchCli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLaunchCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunchCli.Location = new System.Drawing.Point(1015, 410);
            this.btnLaunchCli.Name = "btnLaunchCli";
            this.btnLaunchCli.Size = new System.Drawing.Size(165, 28);
            this.btnLaunchCli.TabIndex = 4;
            this.btnLaunchCli.Text = "Launch with Current Settings";
            this.btnLaunchCli.UseVisualStyleBackColor = true;
            this.btnLaunchCli.Click += new System.EventHandler(this.btnLaunchCli_Click);
            // 
            // btnLaunchConfig
            // 
            this.btnLaunchConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLaunchConfig.Location = new System.Drawing.Point(1186, 410);
            this.btnLaunchConfig.Name = "btnLaunchConfig";
            this.btnLaunchConfig.Size = new System.Drawing.Size(156, 28);
            this.btnLaunchConfig.TabIndex = 5;
            this.btnLaunchConfig.Text = "Launch with Saved Config...";
            this.btnLaunchConfig.UseVisualStyleBackColor = true;
            this.btnLaunchConfig.Click += new System.EventHandler(this.btnLaunchConfig_Click);
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveConfig.Location = new System.Drawing.Point(12, 410);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(156, 28);
            this.btnSaveConfig.TabIndex = 6;
            this.btnSaveConfig.Text = "Export to .conf File...";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 441);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1354, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 17);
            this.lblStatus.Text = "Ready";
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // darkTabControl1
            // 
            this.darkTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.darkTabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.darkTabControl1.Controls.Add(this.generalPage);
            this.darkTabControl1.Controls.Add(this.serverLoggingPage);
            this.darkTabControl1.Controls.Add(this.loggingPage);
            this.darkTabControl1.Controls.Add(this.uiPage);
            this.darkTabControl1.Controls.Add(this.sslPage);
            this.darkTabControl1.Controls.Add(this.secPage);
            this.darkTabControl1.Controls.Add(this.protoPage);
            this.darkTabControl1.Controls.Add(this.dbPage);
            this.darkTabControl1.Controls.Add(this.upPage);
            this.darkTabControl1.Controls.Add(this.discovPage);
            this.darkTabControl1.Controls.Add(this.volsPage);
            this.darkTabControl1.Controls.Add(this.accPage);
            this.darkTabControl1.Location = new System.Drawing.Point(15, 39);
            this.darkTabControl1.Name = "darkTabControl1";
            this.darkTabControl1.Size = new System.Drawing.Size(1327, 365);
            this.darkTabControl1.TabIndex = 9;
            this.darkTabControl1.TabPages.Add(this.generalPage);
            this.darkTabControl1.TabPages.Add(this.serverLoggingPage);
            this.darkTabControl1.TabPages.Add(this.accPage);
            this.darkTabControl1.TabPages.Add(this.volsPage);
            this.darkTabControl1.TabPages.Add(this.discovPage);
            this.darkTabControl1.TabPages.Add(this.upPage);
            this.darkTabControl1.TabPages.Add(this.dbPage);
            this.darkTabControl1.TabPages.Add(this.protoPage);
            this.darkTabControl1.TabPages.Add(this.secPage);
            this.darkTabControl1.TabPages.Add(this.sslPage);
            this.darkTabControl1.TabPages.Add(this.uiPage);
            this.darkTabControl1.TabPages.Add(this.loggingPage);
            // 
            // generalPage
            // 
            this.generalPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generalPage.Controls.Add(this.groupBox4);
            this.generalPage.Controls.Add(this.groupBox1);
            this.generalPage.Location = new System.Drawing.Point(0, 30);
            this.generalPage.Name = "generalPage";
            this.generalPage.Size = new System.Drawing.Size(1327, 335);
            this.generalPage.TabIndex = 1;
            this.generalPage.Text = "General";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.redirectOutputBox);
            this.groupBox4.Controls.Add(this.chkRMagic);
            this.groupBox4.Controls.Add(this.chkEnableDots);
            this.groupBox4.Controls.Add(this.txtServerName);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.numCpuCores);
            this.groupBox4.Controls.Add(this.numMaxClients);
            this.groupBox4.Controls.Add(this.chkUsernames);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1318, 133);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "General";
            // 
            // redirectOutputBox
            // 
            this.redirectOutputBox.AutoSize = true;
            this.redirectOutputBox.Location = new System.Drawing.Point(267, 101);
            this.redirectOutputBox.Name = "redirectOutputBox";
            this.redirectOutputBox.Size = new System.Drawing.Size(184, 17);
            this.redirectOutputBox.TabIndex = 9;
            this.redirectOutputBox.Text = "Redirect output to Server Log tab";
            this.mainTooltip.SetToolTip(this.redirectOutputBox, "Redirect output of copyparty console to Server Log tab");
            this.redirectOutputBox.UseVisualStyleBackColor = true;
            // 
            // chkRMagic
            // 
            this.chkRMagic.AutoSize = true;
            this.chkRMagic.Location = new System.Drawing.Point(267, 74);
            this.chkRMagic.Name = "chkRMagic";
            this.chkRMagic.Size = new System.Drawing.Size(202, 17);
            this.chkRMagic.TabIndex = 8;
            this.chkRMagic.Text = "Improve Mimetypes (slower) (--rmagic)";
            this.mainTooltip.SetToolTip(this.chkRMagic, "Do expensive analysis to improve accuracy of returned mimetypes.");
            this.chkRMagic.UseVisualStyleBackColor = true;
            // 
            // chkEnableDots
            // 
            this.chkEnableDots.AutoSize = true;
            this.chkEnableDots.Location = new System.Drawing.Point(267, 48);
            this.chkEnableDots.Name = "chkEnableDots";
            this.chkEnableDots.Size = new System.Drawing.Size(156, 17);
            this.chkEnableDots.TabIndex = 7;
            this.chkEnableDots.Text = "Enable Dotfile Viewing (-ed)";
            this.mainTooltip.SetToolTip(this.chkEnableDots, "Globally allow clients to see dotfiles if they have permission.");
            this.chkEnableDots.UseVisualStyleBackColor = true;
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(117, 98);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(120, 20);
            this.txtServerName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Server Name (--name)";
            // 
            // numCpuCores
            // 
            this.numCpuCores.Location = new System.Drawing.Point(117, 46);
            this.numCpuCores.Name = "numCpuCores";
            this.numCpuCores.Size = new System.Drawing.Size(120, 20);
            this.numCpuCores.TabIndex = 4;
            // 
            // numMaxClients
            // 
            this.numMaxClients.Location = new System.Drawing.Point(117, 20);
            this.numMaxClients.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMaxClients.Name = "numMaxClients";
            this.numMaxClients.Size = new System.Drawing.Size(120, 20);
            this.numMaxClients.TabIndex = 3;
            // 
            // chkUsernames
            // 
            this.chkUsernames.AutoSize = true;
            this.chkUsernames.Location = new System.Drawing.Point(267, 21);
            this.chkUsernames.Name = "chkUsernames";
            this.chkUsernames.Size = new System.Drawing.Size(247, 17);
            this.chkUsernames.TabIndex = 2;
            this.chkUsernames.Text = "Require username and password (--usernames)";
            this.chkUsernames.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "CPU Cores (0=all) (-j)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Max Clients (-nc)";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkReuseAddr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIp);
            this.groupBox1.Location = new System.Drawing.Point(3, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1321, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Network";
            // 
            // chkReuseAddr
            // 
            this.chkReuseAddr.AutoSize = true;
            this.chkReuseAddr.Location = new System.Drawing.Point(245, 21);
            this.chkReuseAddr.Name = "chkReuseAddr";
            this.chkReuseAddr.Size = new System.Drawing.Size(181, 17);
            this.chkReuseAddr.TabIndex = 4;
            this.chkReuseAddr.Text = "Allow Rapid Restart (--reuseaddr)";
            this.mainTooltip.SetToolTip(this.chkReuseAddr, "Windows only. Allows multiple instances to run on the same port.");
            this.chkReuseAddr.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Port (-p)";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(89, 46);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(135, 20);
            this.txtPort.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Listen on IP (-i)";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(89, 19);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(135, 20);
            this.txtIp.TabIndex = 0;
            // 
            // serverLoggingPage
            // 
            this.serverLoggingPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverLoggingPage.Controls.Add(this.serverLogBox);
            this.serverLoggingPage.Location = new System.Drawing.Point(0, 30);
            this.serverLoggingPage.Name = "serverLoggingPage";
            this.serverLoggingPage.Size = new System.Drawing.Size(1327, 335);
            this.serverLoggingPage.TabIndex = 2;
            this.serverLoggingPage.Text = "Server Log";
            // 
            // serverLogBox
            // 
            this.serverLogBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverLogBox.Location = new System.Drawing.Point(0, 0);
            this.serverLogBox.Name = "serverLogBox";
            this.serverLogBox.Size = new System.Drawing.Size(1327, 335);
            this.serverLogBox.TabIndex = 0;
            this.serverLogBox.Text = "";
            // 
            // loggingPage
            // 
            this.loggingPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loggingPage.Controls.Add(this.btnBrowseLog);
            this.loggingPage.Controls.Add(this.chkQuiet);
            this.loggingPage.Controls.Add(this.txtLogFile);
            this.loggingPage.Controls.Add(this.chkLogConn);
            this.loggingPage.Controls.Add(this.label14);
            this.loggingPage.Location = new System.Drawing.Point(0, 30);
            this.loggingPage.Name = "loggingPage";
            this.loggingPage.Size = new System.Drawing.Size(1327, 335);
            this.loggingPage.TabIndex = 12;
            this.loggingPage.Text = "Logging";
            // 
            // btnBrowseLog
            // 
            this.btnBrowseLog.Location = new System.Drawing.Point(472, 105);
            this.btnBrowseLog.Name = "btnBrowseLog";
            this.btnBrowseLog.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseLog.TabIndex = 4;
            this.btnBrowseLog.Text = "Browse...";
            this.btnBrowseLog.UseVisualStyleBackColor = true;
            this.btnBrowseLog.Click += new System.EventHandler(this.btnBrowseLog_Click);
            // 
            // chkQuiet
            // 
            this.chkQuiet.AutoSize = true;
            this.chkQuiet.Location = new System.Drawing.Point(38, 54);
            this.chkQuiet.Name = "chkQuiet";
            this.chkQuiet.Size = new System.Drawing.Size(129, 17);
            this.chkQuiet.TabIndex = 0;
            this.chkQuiet.Text = "Quiet (less output) (-q)";
            this.chkQuiet.UseVisualStyleBackColor = true;
            // 
            // txtLogFile
            // 
            this.txtLogFile.Location = new System.Drawing.Point(106, 107);
            this.txtLogFile.Name = "txtLogFile";
            this.txtLogFile.Size = new System.Drawing.Size(360, 20);
            this.txtLogFile.TabIndex = 3;
            // 
            // chkLogConn
            // 
            this.chkLogConn.AutoSize = true;
            this.chkLogConn.Location = new System.Drawing.Point(38, 77);
            this.chkLogConn.Name = "chkLogConn";
            this.chkLogConn.Size = new System.Drawing.Size(162, 17);
            this.chkLogConn.TabIndex = 1;
            this.chkLogConn.Text = "Log Connections (--log-conn)";
            this.mainTooltip.SetToolTip(this.chkLogConn, "Debug: print tcp-server messages.");
            this.chkLogConn.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(35, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Log File (-lo)";
            // 
            // uiPage
            // 
            this.uiPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiPage.Controls.Add(this.chkNoBranding);
            this.uiPage.Controls.Add(this.chkGrid);
            this.uiPage.Controls.Add(this.chkLocaltime);
            this.uiPage.Location = new System.Drawing.Point(0, 30);
            this.uiPage.Name = "uiPage";
            this.uiPage.Size = new System.Drawing.Size(1327, 335);
            this.uiPage.TabIndex = 11;
            this.uiPage.Text = "UI";
            // 
            // chkNoBranding
            // 
            this.chkNoBranding.AutoSize = true;
            this.chkNoBranding.Location = new System.Drawing.Point(27, 71);
            this.chkNoBranding.Name = "chkNoBranding";
            this.chkNoBranding.Size = new System.Drawing.Size(179, 17);
            this.chkNoBranding.TabIndex = 2;
            this.chkNoBranding.Text = "No \"Powered By\" Branding (-nb)";
            this.chkNoBranding.UseVisualStyleBackColor = true;
            // 
            // chkGrid
            // 
            this.chkGrid.AutoSize = true;
            this.chkGrid.Location = new System.Drawing.Point(27, 25);
            this.chkGrid.Name = "chkGrid";
            this.chkGrid.Size = new System.Drawing.Size(158, 17);
            this.chkGrid.TabIndex = 0;
            this.chkGrid.Text = "Show Grid by Default (--grid)";
            this.chkGrid.UseVisualStyleBackColor = true;
            // 
            // chkLocaltime
            // 
            this.chkLocaltime.AutoSize = true;
            this.chkLocaltime.Location = new System.Drawing.Point(27, 48);
            this.chkLocaltime.Name = "chkLocaltime";
            this.chkLocaltime.Size = new System.Drawing.Size(206, 17);
            this.chkLocaltime.TabIndex = 1;
            this.chkLocaltime.Text = "Default to Local Timezone (--localtime)";
            this.chkLocaltime.UseVisualStyleBackColor = true;
            // 
            // sslPage
            // 
            this.sslPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sslPage.Controls.Add(this.btnBrowseCert);
            this.sslPage.Controls.Add(this.chkHttpOnly);
            this.sslPage.Controls.Add(this.txtCertPath);
            this.sslPage.Controls.Add(this.chkHttpsOnly);
            this.sslPage.Controls.Add(this.label13);
            this.sslPage.Location = new System.Drawing.Point(0, 30);
            this.sslPage.Name = "sslPage";
            this.sslPage.Size = new System.Drawing.Size(1327, 335);
            this.sslPage.TabIndex = 10;
            this.sslPage.Text = "SSL/TLS";
            // 
            // btnBrowseCert
            // 
            this.btnBrowseCert.Location = new System.Drawing.Point(574, 94);
            this.btnBrowseCert.Name = "btnBrowseCert";
            this.btnBrowseCert.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseCert.TabIndex = 4;
            this.btnBrowseCert.Text = "Browse...";
            this.btnBrowseCert.UseVisualStyleBackColor = true;
            this.btnBrowseCert.Click += new System.EventHandler(this.btnBrowseCert_Click);
            // 
            // chkHttpOnly
            // 
            this.chkHttpOnly.AutoSize = true;
            this.chkHttpOnly.Location = new System.Drawing.Point(43, 43);
            this.chkHttpOnly.Name = "chkHttpOnly";
            this.chkHttpOnly.Size = new System.Drawing.Size(164, 17);
            this.chkHttpOnly.TabIndex = 0;
            this.chkHttpOnly.Text = "Disable SSL/TLS (--http-only)";
            this.chkHttpOnly.UseVisualStyleBackColor = true;
            // 
            // txtCertPath
            // 
            this.txtCertPath.Location = new System.Drawing.Point(144, 96);
            this.txtCertPath.Name = "txtCertPath";
            this.txtCertPath.Size = new System.Drawing.Size(424, 20);
            this.txtCertPath.TabIndex = 3;
            // 
            // chkHttpsOnly
            // 
            this.chkHttpsOnly.AutoSize = true;
            this.chkHttpsOnly.Location = new System.Drawing.Point(43, 66);
            this.chkHttpsOnly.Name = "chkHttpsOnly";
            this.chkHttpsOnly.Size = new System.Drawing.Size(152, 17);
            this.chkHttpsOnly.TabIndex = 1;
            this.chkHttpsOnly.Text = "Force HTTPS (--https-only)";
            this.chkHttpsOnly.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Certificate File (--cert)";
            // 
            // secPage
            // 
            this.secPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secPage.Controls.Add(this.groupBox12);
            this.secPage.Location = new System.Drawing.Point(0, 30);
            this.secPage.Name = "secPage";
            this.secPage.Size = new System.Drawing.Size(1327, 335);
            this.secPage.TabIndex = 9;
            this.secPage.Text = "Security";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.label12);
            this.groupBox12.Controls.Add(this.label11);
            this.groupBox12.Controls.Add(this.txtBan403);
            this.groupBox12.Controls.Add(this.txtBanPw);
            this.groupBox12.Controls.Add(this.chkXDev);
            this.groupBox12.Controls.Add(this.chkXVol);
            this.groupBox12.Controls.Add(this.chkSafety3);
            this.groupBox12.Controls.Add(this.chkSafety2);
            this.groupBox12.Controls.Add(this.chkSafety1);
            this.groupBox12.Location = new System.Drawing.Point(12, 8);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(1256, 321);
            this.groupBox12.TabIndex = 0;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Safety Options";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(198, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "403 Ban (--ban-403)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "PW Ban (--ban-pw)";
            // 
            // txtBan403
            // 
            this.txtBan403.Location = new System.Drawing.Point(296, 132);
            this.txtBan403.Name = "txtBan403";
            this.txtBan403.Size = new System.Drawing.Size(84, 20);
            this.txtBan403.TabIndex = 6;
            this.mainTooltip.SetToolTip(this.txtBan403, "Format: N,W,B (Hits, Window, Ban duration)");
            // 
            // txtBanPw
            // 
            this.txtBanPw.Location = new System.Drawing.Point(95, 132);
            this.txtBanPw.Name = "txtBanPw";
            this.txtBanPw.Size = new System.Drawing.Size(84, 20);
            this.txtBanPw.TabIndex = 5;
            this.mainTooltip.SetToolTip(this.txtBanPw, "Format: N,W,B (Attempts, Window, Ban duration)");
            // 
            // chkXDev
            // 
            this.chkXDev.AutoSize = true;
            this.chkXDev.Location = new System.Drawing.Point(125, 68);
            this.chkXDev.Name = "chkXDev";
            this.chkXDev.Size = new System.Drawing.Size(135, 17);
            this.chkXDev.TabIndex = 4;
            this.chkXDev.Text = "Stay on device (--xdev)";
            this.mainTooltip.SetToolTip(this.chkXDev, "Do not descend into other devices (symlink or bind-mount to another HDD, ...)");
            this.chkXDev.UseVisualStyleBackColor = true;
            // 
            // chkXVol
            // 
            this.chkXVol.AutoSize = true;
            this.chkXVol.Location = new System.Drawing.Point(125, 45);
            this.chkXVol.Name = "chkXVol";
            this.chkXVol.Size = new System.Drawing.Size(224, 17);
            this.chkXVol.TabIndex = 3;
            this.chkXVol.Text = "Don\'t follow symlinks out of volume (--xvol)";
            this.chkXVol.UseVisualStyleBackColor = true;
            // 
            // chkSafety3
            // 
            this.chkSafety3.AutoSize = true;
            this.chkSafety3.Location = new System.Drawing.Point(10, 91);
            this.chkSafety3.Name = "chkSafety3";
            this.chkSafety3.Size = new System.Drawing.Size(106, 17);
            this.chkSafety3.TabIndex = 2;
            this.chkSafety3.Text = "Max Safety (-sss)";
            this.chkSafety3.UseVisualStyleBackColor = true;
            // 
            // chkSafety2
            // 
            this.chkSafety2.AutoSize = true;
            this.chkSafety2.Location = new System.Drawing.Point(10, 68);
            this.chkSafety2.Name = "chkSafety2";
            this.chkSafety2.Size = new System.Drawing.Size(105, 17);
            this.chkSafety2.TabIndex = 1;
            this.chkSafety2.Text = "More Safety (-ss)";
            this.chkSafety2.UseVisualStyleBackColor = true;
            // 
            // chkSafety1
            // 
            this.chkSafety1.AutoSize = true;
            this.chkSafety1.Location = new System.Drawing.Point(10, 45);
            this.chkSafety1.Name = "chkSafety1";
            this.chkSafety1.Size = new System.Drawing.Size(100, 17);
            this.chkSafety1.TabIndex = 0;
            this.chkSafety1.Text = "Base Safety (-s)";
            this.chkSafety1.UseVisualStyleBackColor = true;
            // 
            // protoPage
            // 
            this.protoPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.protoPage.Controls.Add(this.groupBox11);
            this.protoPage.Controls.Add(this.groupBox10);
            this.protoPage.Location = new System.Drawing.Point(0, 30);
            this.protoPage.Name = "protoPage";
            this.protoPage.Size = new System.Drawing.Size(1327, 335);
            this.protoPage.TabIndex = 8;
            this.protoPage.Text = "Protocols";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.chkDavInf);
            this.groupBox11.Controls.Add(this.chkDav);
            this.groupBox11.Location = new System.Drawing.Point(12, 181);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(1256, 148);
            this.groupBox11.TabIndex = 1;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "WebDAV";
            // 
            // chkDavInf
            // 
            this.chkDavInf.AutoSize = true;
            this.chkDavInf.Location = new System.Drawing.Point(7, 53);
            this.chkDavInf.Name = "chkDavInf";
            this.chkDavInf.Size = new System.Drawing.Size(212, 17);
            this.chkDavInf.TabIndex = 1;
            this.chkDavInf.Text = "Allow Infinite Depth Requests (--dav-inf)";
            this.mainTooltip.SetToolTip(this.chkDavInf, "Extremely server-heavy but required for spec compliance.");
            this.chkDavInf.UseVisualStyleBackColor = true;
            // 
            // chkDav
            // 
            this.chkDav.AutoSize = true;
            this.chkDav.Location = new System.Drawing.Point(7, 30);
            this.chkDav.Name = "chkDav";
            this.chkDav.Size = new System.Drawing.Size(181, 17);
            this.chkDav.TabIndex = 0;
            this.chkDav.Text = "Enable Full Write Support (--daw)";
            this.mainTooltip.SetToolTip(this.chkDav, "DANGEROUS: PUT operations will OVERWRITE existing files.");
            this.chkDav.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.numFtpsPort);
            this.groupBox10.Controls.Add(this.label10);
            this.groupBox10.Controls.Add(this.numFtpPort);
            this.groupBox10.Controls.Add(this.label9);
            this.groupBox10.Location = new System.Drawing.Point(12, 10);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(1256, 165);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "FTP / FTPS (0 = disabled)";
            // 
            // numFtpsPort
            // 
            this.numFtpsPort.Location = new System.Drawing.Point(129, 60);
            this.numFtpsPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numFtpsPort.Name = "numFtpsPort";
            this.numFtpsPort.Size = new System.Drawing.Size(120, 20);
            this.numFtpsPort.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "FTPS TLS Port (--ftps)";
            // 
            // numFtpPort
            // 
            this.numFtpPort.Location = new System.Drawing.Point(129, 30);
            this.numFtpPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numFtpPort.Name = "numFtpPort";
            this.numFtpPort.Size = new System.Drawing.Size(120, 20);
            this.numFtpPort.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "FTP Port (--ftp)";
            // 
            // dbPage
            // 
            this.dbPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbPage.Controls.Add(this.groupBox9);
            this.dbPage.Controls.Add(this.groupBox8);
            this.dbPage.Location = new System.Drawing.Point(0, 30);
            this.dbPage.Name = "dbPage";
            this.dbPage.Size = new System.Drawing.Size(1327, 335);
            this.dbPage.TabIndex = 7;
            this.dbPage.Text = "Database+Thumbs";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtThSize);
            this.groupBox9.Controls.Add(this.label8);
            this.groupBox9.Controls.Add(this.chkNoAThumb);
            this.groupBox9.Controls.Add(this.chkNoVThumb);
            this.groupBox9.Controls.Add(this.chkNoThumb);
            this.groupBox9.Location = new System.Drawing.Point(3, 176);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(1261, 147);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Thumbnails";
            // 
            // txtThSize
            // 
            this.txtThSize.Location = new System.Drawing.Point(268, 28);
            this.txtThSize.Name = "txtThSize";
            this.txtThSize.Size = new System.Drawing.Size(100, 20);
            this.txtThSize.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(198, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Size (--th-size)";
            // 
            // chkNoAThumb
            // 
            this.chkNoAThumb.AutoSize = true;
            this.chkNoAThumb.Location = new System.Drawing.Point(7, 75);
            this.chkNoAThumb.Name = "chkNoAThumb";
            this.chkNoAThumb.Size = new System.Drawing.Size(197, 17);
            this.chkNoAThumb.TabIndex = 2;
            this.chkNoAThumb.Text = "Disable Audio Thumbs (--no-athumb)";
            this.chkNoAThumb.UseVisualStyleBackColor = true;
            // 
            // chkNoVThumb
            // 
            this.chkNoVThumb.AutoSize = true;
            this.chkNoVThumb.Location = new System.Drawing.Point(7, 52);
            this.chkNoVThumb.Name = "chkNoVThumb";
            this.chkNoVThumb.Size = new System.Drawing.Size(197, 17);
            this.chkNoVThumb.TabIndex = 1;
            this.chkNoVThumb.Text = "Disable Video Thumbs (--no-vthumb)";
            this.chkNoVThumb.UseVisualStyleBackColor = true;
            // 
            // chkNoThumb
            // 
            this.chkNoThumb.AutoSize = true;
            this.chkNoThumb.Location = new System.Drawing.Point(7, 29);
            this.chkNoThumb.Name = "chkNoThumb";
            this.chkNoThumb.Size = new System.Drawing.Size(175, 17);
            this.chkNoThumb.TabIndex = 0;
            this.chkNoThumb.Text = "Disable All Thumbs (--no-thumb)";
            this.chkNoThumb.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.numRescan);
            this.groupBox8.Controls.Add(this.chkE2TSR);
            this.groupBox8.Controls.Add(this.chkE2TS);
            this.groupBox8.Controls.Add(this.chkE2T);
            this.groupBox8.Controls.Add(this.chkE2DSA);
            this.groupBox8.Controls.Add(this.chkE2DS);
            this.groupBox8.Controls.Add(this.chkE2D);
            this.groupBox8.Location = new System.Drawing.Point(6, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(1258, 167);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Database";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Rescan Interval (sec, 0=off)";
            // 
            // numRescan
            // 
            this.numRescan.Location = new System.Drawing.Point(170, 135);
            this.numRescan.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.numRescan.Name = "numRescan";
            this.numRescan.Size = new System.Drawing.Size(120, 20);
            this.numRescan.TabIndex = 6;
            // 
            // chkE2TSR
            // 
            this.chkE2TSR.AutoSize = true;
            this.chkE2TSR.Location = new System.Drawing.Point(232, 103);
            this.chkE2TSR.Name = "chkE2TSR";
            this.chkE2TSR.Size = new System.Drawing.Size(168, 17);
            this.chkE2TSR.TabIndex = 5;
            this.chkE2TSR.Text = "Full Metadata Rescan (--e2tsr)";
            this.mainTooltip.SetToolTip(this.chkE2TSR, "Delete all metadata from DB and do a full rescan.");
            this.chkE2TSR.UseVisualStyleBackColor = true;
            // 
            // chkE2TS
            // 
            this.chkE2TS.AutoSize = true;
            this.chkE2TS.Location = new System.Drawing.Point(7, 103);
            this.chkE2TS.Name = "chkE2TS";
            this.chkE2TS.Size = new System.Drawing.Size(183, 17);
            this.chkE2TS.TabIndex = 4;
            this.chkE2TS.Text = "Scan metadata on startup (--e2ts)";
            this.chkE2TS.UseVisualStyleBackColor = true;
            // 
            // chkE2T
            // 
            this.chkE2T.AutoSize = true;
            this.chkE2T.Location = new System.Drawing.Point(7, 80);
            this.chkE2T.Name = "chkE2T";
            this.chkE2T.Size = new System.Drawing.Size(154, 17);
            this.chkE2T.TabIndex = 3;
            this.chkE2T.Text = "Enable metadata DB (--e2t)";
            this.chkE2T.UseVisualStyleBackColor = true;
            // 
            // chkE2DSA
            // 
            this.chkE2DSA.AutoSize = true;
            this.chkE2DSA.Location = new System.Drawing.Point(232, 57);
            this.chkE2DSA.Name = "chkE2DSA";
            this.chkE2DSA.Size = new System.Drawing.Size(201, 17);
            this.chkE2DSA.TabIndex = 2;
            this.chkE2DSA.Text = "Scan ALL folders on startup (--e2dsa)";
            this.chkE2DSA.UseVisualStyleBackColor = true;
            // 
            // chkE2DS
            // 
            this.chkE2DS.AutoSize = true;
            this.chkE2DS.Location = new System.Drawing.Point(7, 57);
            this.chkE2DS.Name = "chkE2DS";
            this.chkE2DS.Size = new System.Drawing.Size(212, 17);
            this.chkE2DS.TabIndex = 1;
            this.chkE2DS.Text = "Scan writable folders on startup (--e2ds)";
            this.chkE2DS.UseVisualStyleBackColor = true;
            // 
            // chkE2D
            // 
            this.chkE2D.AutoSize = true;
            this.chkE2D.Location = new System.Drawing.Point(7, 34);
            this.chkE2D.Name = "chkE2D";
            this.chkE2D.Size = new System.Drawing.Size(174, 17);
            this.chkE2D.TabIndex = 0;
            this.chkE2D.Text = "Enable upload database (--e2d)";
            this.chkE2D.UseVisualStyleBackColor = true;
            // 
            // upPage
            // 
            this.upPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.upPage.Controls.Add(this.groupBox7);
            this.upPage.Location = new System.Drawing.Point(0, 30);
            this.upPage.Name = "upPage";
            this.upPage.Size = new System.Drawing.Size(1327, 335);
            this.upPage.TabIndex = 6;
            this.upPage.Text = "Uploads";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chkReflink);
            this.groupBox7.Controls.Add(this.chkHardlink);
            this.groupBox7.Controls.Add(this.chkDedup);
            this.groupBox7.Controls.Add(this.chkNoDupe);
            this.groupBox7.Controls.Add(this.chkDotPart);
            this.groupBox7.Location = new System.Drawing.Point(12, 10);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1252, 313);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Upload Behavior";
            // 
            // chkReflink
            // 
            this.chkReflink.AutoSize = true;
            this.chkReflink.Location = new System.Drawing.Point(219, 52);
            this.chkReflink.Name = "chkReflink";
            this.chkReflink.Size = new System.Drawing.Size(173, 17);
            this.chkReflink.TabIndex = 4;
            this.chkReflink.Text = "Enable Reflink Dedup (--reflink)";
            this.chkReflink.UseVisualStyleBackColor = true;
            // 
            // chkHardlink
            // 
            this.chkHardlink.AutoSize = true;
            this.chkHardlink.Location = new System.Drawing.Point(219, 29);
            this.chkHardlink.Name = "chkHardlink";
            this.chkHardlink.Size = new System.Drawing.Size(188, 17);
            this.chkHardlink.TabIndex = 3;
            this.chkHardlink.Text = "Enable Hardlink Dedup (--hardlink)";
            this.chkHardlink.UseVisualStyleBackColor = true;
            // 
            // chkDedup
            // 
            this.chkDedup.AutoSize = true;
            this.chkDedup.Location = new System.Drawing.Point(7, 75);
            this.chkDedup.Name = "chkDedup";
            this.chkDedup.Size = new System.Drawing.Size(178, 17);
            this.chkDedup.TabIndex = 2;
            this.chkDedup.Text = "Enable Symlink Dedup (--dedup)";
            this.chkDedup.UseVisualStyleBackColor = true;
            // 
            // chkNoDupe
            // 
            this.chkNoDupe.AutoSize = true;
            this.chkNoDupe.Location = new System.Drawing.Point(7, 52);
            this.chkNoDupe.Name = "chkNoDupe";
            this.chkNoDupe.Size = new System.Drawing.Size(183, 17);
            this.chkNoDupe.TabIndex = 1;
            this.chkNoDupe.Text = "Reject Duplicate Files (--no-dupe)";
            this.chkNoDupe.UseVisualStyleBackColor = true;
            // 
            // chkDotPart
            // 
            this.chkDotPart.AutoSize = true;
            this.chkDotPart.Location = new System.Drawing.Point(7, 29);
            this.chkDotPart.Name = "chkDotPart";
            this.chkDotPart.Size = new System.Drawing.Size(201, 17);
            this.chkDotPart.TabIndex = 0;
            this.chkDotPart.Text = "Dotfile Incomplete Uploads (--dotpart)";
            this.mainTooltip.SetToolTip(this.chkDotPart, "Hides partial uploads from clients.");
            this.chkDotPart.UseVisualStyleBackColor = true;
            // 
            // discovPage
            // 
            this.discovPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.discovPage.Controls.Add(this.groupBox15);
            this.discovPage.Controls.Add(this.groupBox14);
            this.discovPage.Controls.Add(this.groupBox13);
            this.discovPage.Location = new System.Drawing.Point(0, 30);
            this.discovPage.Name = "discovPage";
            this.discovPage.Size = new System.Drawing.Size(1327, 335);
            this.discovPage.TabIndex = 5;
            this.discovPage.Text = "Discovery";
            // 
            // groupBox15
            // 
            this.groupBox15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox15.Controls.Add(this.txtZsLoc);
            this.groupBox15.Controls.Add(this.label18);
            this.groupBox15.Controls.Add(this.chkZsVerbose);
            this.groupBox15.Controls.Add(this.chkZs);
            this.groupBox15.Location = new System.Drawing.Point(9, 230);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(1308, 99);
            this.groupBox15.TabIndex = 2;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "SSDP (Windows)";
            // 
            // txtZsLoc
            // 
            this.txtZsLoc.Location = new System.Drawing.Point(119, 50);
            this.txtZsLoc.Name = "txtZsLoc";
            this.txtZsLoc.Size = new System.Drawing.Size(264, 20);
            this.txtZsLoc.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 53);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "URL Suffix (--zsl)";
            // 
            // chkZsVerbose
            // 
            this.chkZsVerbose.AutoSize = true;
            this.chkZsVerbose.Location = new System.Drawing.Point(119, 27);
            this.chkZsVerbose.Name = "chkZsVerbose";
            this.chkZsVerbose.Size = new System.Drawing.Size(96, 17);
            this.chkZsVerbose.TabIndex = 1;
            this.chkZsVerbose.Text = "Verbose (--zsv)";
            this.chkZsVerbose.UseVisualStyleBackColor = true;
            // 
            // chkZs
            // 
            this.chkZs.AutoSize = true;
            this.chkZs.Location = new System.Drawing.Point(10, 27);
            this.chkZs.Name = "chkZs";
            this.chkZs.Size = new System.Drawing.Size(84, 17);
            this.chkZs.TabIndex = 0;
            this.chkZs.Text = "Enable (--zs)";
            this.chkZs.UseVisualStyleBackColor = true;
            // 
            // groupBox14
            // 
            this.groupBox14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox14.Controls.Add(this.numZmSpam);
            this.groupBox14.Controls.Add(this.label17);
            this.groupBox14.Controls.Add(this.txtZmsSvc);
            this.groupBox14.Controls.Add(this.label16);
            this.groupBox14.Controls.Add(this.chkZmVerbose);
            this.groupBox14.Controls.Add(this.chkZm6);
            this.groupBox14.Controls.Add(this.chkZm4);
            this.groupBox14.Controls.Add(this.chkZm);
            this.groupBox14.Location = new System.Drawing.Point(9, 107);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(1308, 117);
            this.groupBox14.TabIndex = 1;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "mDNS (macOS, Linux)";
            // 
            // numZmSpam
            // 
            this.numZmSpam.DecimalPlaces = 1;
            this.numZmSpam.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numZmSpam.Location = new System.Drawing.Point(232, 83);
            this.numZmSpam.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numZmSpam.Name = "numZmSpam";
            this.numZmSpam.Size = new System.Drawing.Size(87, 20);
            this.numZmSpam.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 85);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(193, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Unsolicited Announce (sec) (--zm-spam)";
            this.mainTooltip.SetToolTip(this.label17, "Not spec-compliant but can fix intermittent issues. Try 30.");
            // 
            // txtZmsSvc
            // 
            this.txtZmsSvc.Location = new System.Drawing.Point(119, 54);
            this.txtZmsSvc.Name = "txtZmsSvc";
            this.txtZmsSvc.Size = new System.Drawing.Size(200, 20);
            this.txtZmsSvc.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Announce Svc (--zms)";
            // 
            // chkZmVerbose
            // 
            this.chkZmVerbose.AutoSize = true;
            this.chkZmVerbose.Location = new System.Drawing.Point(286, 28);
            this.chkZmVerbose.Name = "chkZmVerbose";
            this.chkZmVerbose.Size = new System.Drawing.Size(99, 17);
            this.chkZmVerbose.TabIndex = 3;
            this.chkZmVerbose.Text = "Verbose (--zmv)";
            this.chkZmVerbose.UseVisualStyleBackColor = true;
            // 
            // chkZm6
            // 
            this.chkZm6.AutoSize = true;
            this.chkZm6.Location = new System.Drawing.Point(198, 28);
            this.chkZm6.Name = "chkZm6";
            this.chkZm6.Size = new System.Drawing.Size(104, 17);
            this.chkZm6.TabIndex = 2;
            this.chkZm6.Text = "IPv6 only (--zm6)";
            this.chkZm6.UseVisualStyleBackColor = true;
            // 
            // chkZm4
            // 
            this.chkZm4.AutoSize = true;
            this.chkZm4.Location = new System.Drawing.Point(110, 28);
            this.chkZm4.Name = "chkZm4";
            this.chkZm4.Size = new System.Drawing.Size(104, 17);
            this.chkZm4.TabIndex = 1;
            this.chkZm4.Text = "IPv4 only (--zm4)";
            this.chkZm4.UseVisualStyleBackColor = true;
            // 
            // chkZm
            // 
            this.chkZm.AutoSize = true;
            this.chkZm.Location = new System.Drawing.Point(10, 28);
            this.chkZm.Name = "chkZm";
            this.chkZm.Size = new System.Drawing.Size(87, 17);
            this.chkZm.TabIndex = 0;
            this.chkZm.Text = "Enable (--zm)";
            this.chkZm.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            this.groupBox13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox13.Controls.Add(this.numMcHop);
            this.groupBox13.Controls.Add(this.label15);
            this.groupBox13.Controls.Add(this.chkZVerbose);
            this.groupBox13.Controls.Add(this.chkZeroconf);
            this.groupBox13.Controls.Add(this.chkQrCode);
            this.groupBox13.Location = new System.Drawing.Point(9, 4);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(1308, 97);
            this.groupBox13.TabIndex = 0;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "General";
            // 
            // numMcHop
            // 
            this.numMcHop.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMcHop.Location = new System.Drawing.Point(201, 62);
            this.numMcHop.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numMcHop.Name = "numMcHop";
            this.numMcHop.Size = new System.Drawing.Size(120, 20);
            this.numMcHop.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(161, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Multicast Re-join (sec) (--mc-hop)";
            this.mainTooltip.SetToolTip(this.label15, "Workaround for routers that drop multicast. Try 300.");
            // 
            // chkZVerbose
            // 
            this.chkZVerbose.AutoSize = true;
            this.chkZVerbose.Location = new System.Drawing.Point(10, 44);
            this.chkZVerbose.Name = "chkZVerbose";
            this.chkZVerbose.Size = new System.Drawing.Size(123, 17);
            this.chkZVerbose.TabIndex = 2;
            this.chkZVerbose.Text = "Verbose Output (-zv)";
            this.chkZVerbose.UseVisualStyleBackColor = true;
            // 
            // chkZeroconf
            // 
            this.chkZeroconf.AutoSize = true;
            this.chkZeroconf.Location = new System.Drawing.Point(10, 21);
            this.chkZeroconf.Name = "chkZeroconf";
            this.chkZeroconf.Size = new System.Drawing.Size(136, 17);
            this.chkZeroconf.TabIndex = 1;
            this.chkZeroconf.Text = "Enable All Zeroconf (-z)";
            this.chkZeroconf.UseVisualStyleBackColor = true;
            // 
            // chkQrCode
            // 
            this.chkQrCode.AutoSize = true;
            this.chkQrCode.Location = new System.Drawing.Point(201, 21);
            this.chkQrCode.Name = "chkQrCode";
            this.chkQrCode.Size = new System.Drawing.Size(130, 17);
            this.chkQrCode.TabIndex = 0;
            this.chkQrCode.Text = "Enable QR Code (--qr)";
            this.chkQrCode.UseVisualStyleBackColor = true;
            // 
            // volsPage
            // 
            this.volsPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volsPage.Controls.Add(this.btnEditVolume);
            this.volsPage.Controls.Add(this.dgvVolumes);
            this.volsPage.Controls.Add(this.btnRemoveVolume);
            this.volsPage.Controls.Add(this.btnAddVolume);
            this.volsPage.Location = new System.Drawing.Point(0, 30);
            this.volsPage.Name = "volsPage";
            this.volsPage.Size = new System.Drawing.Size(1327, 335);
            this.volsPage.TabIndex = 4;
            this.volsPage.Text = "Volumes";
            // 
            // btnEditVolume
            // 
            this.btnEditVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditVolume.Location = new System.Drawing.Point(1246, 33);
            this.btnEditVolume.Name = "btnEditVolume";
            this.btnEditVolume.Size = new System.Drawing.Size(75, 23);
            this.btnEditVolume.TabIndex = 6;
            this.btnEditVolume.Text = "Edit";
            this.btnEditVolume.UseVisualStyleBackColor = true;
            this.btnEditVolume.Click += new System.EventHandler(this.btnEditVolume_Click);
            // 
            // dgvVolumes
            // 
            this.dgvVolumes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVolumes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVolumes.Location = new System.Drawing.Point(6, 4);
            this.dgvVolumes.Name = "dgvVolumes";
            this.dgvVolumes.ReadOnly = true;
            this.dgvVolumes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVolumes.Size = new System.Drawing.Size(1234, 327);
            this.dgvVolumes.TabIndex = 3;
            // 
            // btnRemoveVolume
            // 
            this.btnRemoveVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveVolume.Location = new System.Drawing.Point(1246, 62);
            this.btnRemoveVolume.Name = "btnRemoveVolume";
            this.btnRemoveVolume.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveVolume.TabIndex = 5;
            this.btnRemoveVolume.Text = "Remove";
            this.btnRemoveVolume.UseVisualStyleBackColor = true;
            this.btnRemoveVolume.Click += new System.EventHandler(this.btnRemoveVolume_Click);
            // 
            // btnAddVolume
            // 
            this.btnAddVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddVolume.Location = new System.Drawing.Point(1246, 4);
            this.btnAddVolume.Name = "btnAddVolume";
            this.btnAddVolume.Size = new System.Drawing.Size(75, 23);
            this.btnAddVolume.TabIndex = 4;
            this.btnAddVolume.Text = "Add";
            this.btnAddVolume.UseVisualStyleBackColor = true;
            this.btnAddVolume.Click += new System.EventHandler(this.btnAddVolume_Click);
            // 
            // accPage
            // 
            this.accPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accPage.Controls.Add(this.splitContainer2);
            this.accPage.Location = new System.Drawing.Point(0, 30);
            this.accPage.Name = "accPage";
            this.accPage.Size = new System.Drawing.Size(1327, 335);
            this.accPage.TabIndex = 3;
            this.accPage.Text = "Accounts+Groups";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox5);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox6);
            this.splitContainer2.Size = new System.Drawing.Size(1327, 335);
            this.splitContainer2.SplitterDistance = 157;
            this.splitContainer2.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnRemoveAccount);
            this.groupBox5.Controls.Add(this.btnAddAccount);
            this.groupBox5.Controls.Add(this.dgvAccounts);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1327, 157);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "User Accounts (-a)";
            // 
            // btnRemoveAccount
            // 
            this.btnRemoveAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveAccount.Location = new System.Drawing.Point(1246, 48);
            this.btnRemoveAccount.Name = "btnRemoveAccount";
            this.btnRemoveAccount.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveAccount.TabIndex = 5;
            this.btnRemoveAccount.Text = "Remove";
            this.btnRemoveAccount.UseVisualStyleBackColor = true;
            this.btnRemoveAccount.Click += new System.EventHandler(this.btnRemoveAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAccount.Location = new System.Drawing.Point(1246, 19);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(75, 23);
            this.btnAddAccount.TabIndex = 4;
            this.btnAddAccount.Text = "Add";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Location = new System.Drawing.Point(6, 19);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.Size = new System.Drawing.Size(1234, 132);
            this.dgvAccounts.TabIndex = 3;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnRemoveGroup);
            this.groupBox6.Controls.Add(this.btnAddGroup);
            this.groupBox6.Controls.Add(this.dgvGroups);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1327, 174);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Groups (--grp)";
            // 
            // btnRemoveGroup
            // 
            this.btnRemoveGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveGroup.Location = new System.Drawing.Point(1246, 48);
            this.btnRemoveGroup.Name = "btnRemoveGroup";
            this.btnRemoveGroup.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveGroup.TabIndex = 5;
            this.btnRemoveGroup.Text = "Remove";
            this.btnRemoveGroup.UseVisualStyleBackColor = true;
            this.btnRemoveGroup.Click += new System.EventHandler(this.btnRemoveGroup_Click);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddGroup.Location = new System.Drawing.Point(1246, 19);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(75, 23);
            this.btnAddGroup.TabIndex = 4;
            this.btnAddGroup.Text = "Add";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // dgvGroups
            // 
            this.dgvGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroups.Location = new System.Drawing.Point(6, 19);
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.Size = new System.Drawing.Size(1234, 149);
            this.dgvGroups.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1354, 463);
            this.Controls.Add(this.darkTabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.btnLaunchConfig);
            this.Controls.Add(this.btnLaunchCli);
            this.Controls.Add(this.btnBrowseExe);
            this.Controls.Add(this.txtCopyPartyPath);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Silver;
            this.MinimumSize = new System.Drawing.Size(700, 502);
            this.Name = "MainForm";
            this.Text = "Copyparty GUI Launcher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.darkTabControl1)).EndInit();
            this.darkTabControl1.ResumeLayout(false);
            this.generalPage.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCpuCores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxClients)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.serverLoggingPage.ResumeLayout(false);
            this.loggingPage.ResumeLayout(false);
            this.loggingPage.PerformLayout();
            this.uiPage.ResumeLayout(false);
            this.uiPage.PerformLayout();
            this.sslPage.ResumeLayout(false);
            this.sslPage.PerformLayout();
            this.secPage.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.protoPage.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFtpsPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFtpPort)).EndInit();
            this.dbPage.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRescan)).EndInit();
            this.upPage.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.discovPage.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZmSpam)).EndInit();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMcHop)).EndInit();
            this.volsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVolumes)).EndInit();
            this.accPage.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCopyPartyPath;
        private System.Windows.Forms.Button btnBrowseExe;
        private System.Windows.Forms.Button btnLaunchCli;
        private System.Windows.Forms.Button btnLaunchConfig;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolTip mainTooltip;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numCpuCores;
        private System.Windows.Forms.NumericUpDown numMaxClients;
        private System.Windows.Forms.CheckBox chkUsernames;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkReuseAddr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnRemoveAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnRemoveGroup;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.Button btnEditVolume;
        private System.Windows.Forms.Button btnRemoveVolume;
        private System.Windows.Forms.Button btnAddVolume;
        private System.Windows.Forms.DataGridView dgvVolumes;
        private System.Windows.Forms.CheckBox chkHttpsOnly;
        private System.Windows.Forms.CheckBox chkHttpOnly;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCertPath;
        private System.Windows.Forms.Button btnBrowseCert;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox chkNoDupe;
        private System.Windows.Forms.CheckBox chkDotPart;
        private System.Windows.Forms.CheckBox chkReflink;
        private System.Windows.Forms.CheckBox chkHardlink;
        private System.Windows.Forms.CheckBox chkDedup;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox chkE2D;
        private System.Windows.Forms.CheckBox chkE2DS;
        private System.Windows.Forms.CheckBox chkE2DSA;
        private System.Windows.Forms.CheckBox chkE2T;
        private System.Windows.Forms.CheckBox chkE2TS;
        private System.Windows.Forms.CheckBox chkE2TSR;
        private System.Windows.Forms.NumericUpDown numRescan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkNoThumb;
        private System.Windows.Forms.CheckBox chkNoVThumb;
        private System.Windows.Forms.CheckBox chkNoAThumb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtThSize;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numFtpPort;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numFtpsPort;
        private System.Windows.Forms.CheckBox chkDav;
        private System.Windows.Forms.CheckBox chkDavInf;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.CheckBox chkSafety1;
        private System.Windows.Forms.CheckBox chkSafety2;
        private System.Windows.Forms.CheckBox chkSafety3;
        private System.Windows.Forms.CheckBox chkXVol;
        private System.Windows.Forms.CheckBox chkXDev;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBanPw;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBan403;
        private System.Windows.Forms.CheckBox chkGrid;
        private System.Windows.Forms.CheckBox chkLocaltime;
        private System.Windows.Forms.CheckBox chkNoBranding;
        private System.Windows.Forms.CheckBox chkQuiet;
        private System.Windows.Forms.CheckBox chkLogConn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtLogFile;
        private System.Windows.Forms.Button btnBrowseLog;
        private System.Windows.Forms.CheckBox chkEnableDots;
        private System.Windows.Forms.CheckBox chkRMagic;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.TextBox txtZsLoc;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox chkZsVerbose;
        private System.Windows.Forms.CheckBox chkZs;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.NumericUpDown numZmSpam;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtZmsSvc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox chkZmVerbose;
        private System.Windows.Forms.CheckBox chkZm6;
        private System.Windows.Forms.CheckBox chkZm4;
        private System.Windows.Forms.CheckBox chkZm;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.NumericUpDown numMcHop;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chkZVerbose;
        private System.Windows.Forms.CheckBox chkZeroconf;
        private System.Windows.Forms.CheckBox chkQrCode;
        private System.Windows.Forms.RichTextBox serverLogBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox redirectOutputBox;
        private NativeDarkMode_Lib.DarkTabControl darkTabControl1;
        private NativeDarkMode_Lib.DarkTabPage generalPage;
        private NativeDarkMode_Lib.DarkTabPage serverLoggingPage;
        private NativeDarkMode_Lib.DarkTabPage accPage;
        private NativeDarkMode_Lib.DarkTabPage volsPage;
        private NativeDarkMode_Lib.DarkTabPage discovPage;
        private NativeDarkMode_Lib.DarkTabPage upPage;
        private NativeDarkMode_Lib.DarkTabPage dbPage;
        private NativeDarkMode_Lib.DarkTabPage protoPage;
        private NativeDarkMode_Lib.DarkTabPage secPage;
        private NativeDarkMode_Lib.DarkTabPage sslPage;
        private NativeDarkMode_Lib.DarkTabPage uiPage;
        private NativeDarkMode_Lib.DarkTabPage loggingPage;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}

