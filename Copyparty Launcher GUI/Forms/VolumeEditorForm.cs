using Copyparty_Launcher_GUI.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Copyparty_Launcher_GUI.Forms
{
    public partial class VolumeEditorForm : Form
    {
        public Volume VolumeData { get; private set; }

        public VolumeEditorForm(Volume volume)
        {
            InitializeComponent();
            this.VolumeData = volume;
        }

        private void VolumeEditorForm_Load(object sender, EventArgs e)
        {
            // Setup DataGridViews
            dgvPermissions.AutoGenerateColumns = true;
            dgvPermissions.DataSource = VolumeData.Permissions;
            dgvPermissions.Columns["Type"].HeaderText = "Permission (r, rw)";
            dgvPermissions.Columns["Users"].HeaderText = "Users (*, ed, k)";
            dgvPermissions.Columns["Users"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            dgvFlags.AutoGenerateColumns = true;
            dgvFlags.DataSource = VolumeData.Flags;
            dgvFlags.Columns["Name"].HeaderText = "Flag Name (e2d, nodupe)";
            dgvFlags.Columns["Value"].HeaderText = "Value (optional)";
            dgvFlags.Columns["Value"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Load data into controls
            txtSourcePath.Text = VolumeData.SourcePath;
            txtDestPath.Text = VolumeData.DestPath;
        }

        private void btnBrowseSource_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtSourcePath.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnAddPermission_Click(object sender, EventArgs e)
        {
            VolumeData.Permissions.Add(new Permission { Type = "r", Users = "*" });
        }

        private void btnRemovePermission_Click(object sender, EventArgs e)
        {
            if (dgvPermissions.CurrentRow != null && dgvPermissions.CurrentRow.Index < VolumeData.Permissions.Count)
            {
                VolumeData.Permissions.RemoveAt(dgvPermissions.CurrentRow.Index);
            }
        }

        private void btnAddFlag_Click(object sender, EventArgs e)
        {
            VolumeData.Flags.Add(new Flag { Name = "flag-name" });
        }

        private void btnRemoveFlag_Click(object sender, EventArgs e)
        {
            if (dgvFlags.CurrentRow != null && dgvFlags.CurrentRow.Index < VolumeData.Flags.Count)
            {
                VolumeData.Flags.RemoveAt(dgvFlags.CurrentRow.Index);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Validate
            if (string.IsNullOrWhiteSpace(txtSourcePath.Text) || string.IsNullOrWhiteSpace(txtDestPath.Text))
            {
                MessageBox.Show("Source and Destination paths cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Save data back to the Volume object
            VolumeData.SourcePath = txtSourcePath.Text;
            VolumeData.DestPath = txtDestPath.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
