namespace Copyparty_Launcher_GUI.Forms
{
    partial class VolumeEditorForm
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
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSourcePath = new System.Windows.Forms.TextBox();
            this.btnBrowseSource = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDestPath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemovePermission = new System.Windows.Forms.Button();
            this.btnAddPermission = new System.Windows.Forms.Button();
            this.dgvPermissions = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemoveFlag = new System.Windows.Forms.Button();
            this.btnAddFlag = new System.Windows.Forms.Button();
            this.dgvFlags = new System.Windows.Forms.DataGridView();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissions)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlags)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Path (Filesystem)";
            // 
            // txtSourcePath
            // 
            this.txtSourcePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourcePath.Location = new System.Drawing.Point(141, 12);
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.Size = new System.Drawing.Size(350, 20);
            this.txtSourcePath.TabIndex = 1;
            // 
            // btnBrowseSource
            // 
            this.btnBrowseSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseSource.Location = new System.Drawing.Point(497, 10);
            this.btnBrowseSource.Name = "btnBrowseSource";
            this.btnBrowseSource.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSource.TabIndex = 2;
            this.btnBrowseSource.Text = "Browse...";
            this.btnBrowseSource.UseVisualStyleBackColor = true;
            this.btnBrowseSource.Click += new System.EventHandler(this.btnBrowseSource_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination Path (UI)";
            // 
            // txtDestPath
            // 
            this.txtDestPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestPath.Location = new System.Drawing.Point(141, 38);
            this.txtDestPath.Name = "txtDestPath";
            this.txtDestPath.Size = new System.Drawing.Size(350, 20);
            this.txtDestPath.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnRemovePermission);
            this.groupBox1.Controls.Add(this.btnAddPermission);
            this.groupBox1.Controls.Add(this.dgvPermissions);
            this.groupBox1.Location = new System.Drawing.Point(15, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 150);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permissions (accs)";
            // 
            // btnRemovePermission
            // 
            this.btnRemovePermission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemovePermission.Location = new System.Drawing.Point(476, 48);
            this.btnRemovePermission.Name = "btnRemovePermission";
            this.btnRemovePermission.Size = new System.Drawing.Size(75, 23);
            this.btnRemovePermission.TabIndex = 2;
            this.btnRemovePermission.Text = "Remove";
            this.btnRemovePermission.UseVisualStyleBackColor = true;
            this.btnRemovePermission.Click += new System.EventHandler(this.btnRemovePermission_Click);
            // 
            // btnAddPermission
            // 
            this.btnAddPermission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPermission.Location = new System.Drawing.Point(476, 19);
            this.btnAddPermission.Name = "btnAddPermission";
            this.btnAddPermission.Size = new System.Drawing.Size(75, 23);
            this.btnAddPermission.TabIndex = 1;
            this.btnAddPermission.Text = "Add";
            this.btnAddPermission.UseVisualStyleBackColor = true;
            this.btnAddPermission.Click += new System.EventHandler(this.btnAddPermission_Click);
            // 
            // dgvPermissions
            // 
            this.dgvPermissions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPermissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermissions.Location = new System.Drawing.Point(6, 19);
            this.dgvPermissions.Name = "dgvPermissions";
            this.dgvPermissions.Size = new System.Drawing.Size(464, 125);
            this.dgvPermissions.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnRemoveFlag);
            this.groupBox2.Controls.Add(this.btnAddFlag);
            this.groupBox2.Controls.Add(this.dgvFlags);
            this.groupBox2.Location = new System.Drawing.Point(15, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 150);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Volume Flags (flags)";
            // 
            // btnRemoveFlag
            // 
            this.btnRemoveFlag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveFlag.Location = new System.Drawing.Point(476, 48);
            this.btnRemoveFlag.Name = "btnRemoveFlag";
            this.btnRemoveFlag.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveFlag.TabIndex = 2;
            this.btnRemoveFlag.Text = "Remove";
            this.btnRemoveFlag.UseVisualStyleBackColor = true;
            this.btnRemoveFlag.Click += new System.EventHandler(this.btnRemoveFlag_Click);
            // 
            // btnAddFlag
            // 
            this.btnAddFlag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFlag.Location = new System.Drawing.Point(476, 19);
            this.btnAddFlag.Name = "btnAddFlag";
            this.btnAddFlag.Size = new System.Drawing.Size(75, 23);
            this.btnAddFlag.TabIndex = 1;
            this.btnAddFlag.Text = "Add";
            this.btnAddFlag.UseVisualStyleBackColor = true;
            this.btnAddFlag.Click += new System.EventHandler(this.btnAddFlag_Click);
            // 
            // dgvFlags
            // 
            this.dgvFlags.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFlags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlags.Location = new System.Drawing.Point(6, 19);
            this.dgvFlags.Name = "dgvFlags";
            this.dgvFlags.Size = new System.Drawing.Size(464, 125);
            this.dgvFlags.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(416, 387);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(497, 387);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // VolumeEditorForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(584, 422);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDestPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowseSource);
            this.Controls.Add(this.txtSourcePath);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(450, 420);
            this.Name = "VolumeEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Volume Editor";
            this.Load += new System.EventHandler(this.VolumeEditorForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermissions)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlags)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSourcePath;
        private System.Windows.Forms.Button btnBrowseSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDestPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemovePermission;
        private System.Windows.Forms.Button btnAddPermission;
        private System.Windows.Forms.DataGridView dgvPermissions;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemoveFlag;
        private System.Windows.Forms.Button btnAddFlag;
        private System.Windows.Forms.DataGridView dgvFlags;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}