namespace NativeDarkMode_Lib
{
    partial class DarkTabControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.panelTabButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panelTabButtons
            // 
            this.panelTabButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTabButtons.Location = new System.Drawing.Point(0, 0);
            this.panelTabButtons.Name = "panelTabButtons";
            this.panelTabButtons.Size = new System.Drawing.Size(600, 30);
            this.panelTabButtons.TabIndex = 0;
            // 
            // DarkTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelTabButtons);
            this.Name = "DarkTabControl";
            this.Size = new System.Drawing.Size(600, 400);
            this.ResumeLayout(false);

        }

        #endregion

        // Ensure this is internal so the designer can access it
        internal System.Windows.Forms.FlowLayoutPanel panelTabButtons;
    }
}