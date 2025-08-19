namespace NativeDarkMode_Lib
{
    partial class DarkDateTimePicker
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
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnDropDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDate
            // 
            this.txtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDate.Location = new System.Drawing.Point(0, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(171, 20);
            this.txtDate.TabIndex = 0;
            // 
            // btnDropDown
            // 
            this.btnDropDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDropDown.Location = new System.Drawing.Point(170, 0);
            this.btnDropDown.Name = "btnDropDown";
            this.btnDropDown.Size = new System.Drawing.Size(30, 20);
            this.btnDropDown.TabIndex = 1;
            this.btnDropDown.Text = "▼";
            this.btnDropDown.UseVisualStyleBackColor = true;
            this.btnDropDown.Click += new System.EventHandler(this.btnDropDown_Click);
            // 
            // DarkDateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDropDown);
            this.Controls.Add(this.txtDate);
            this.Name = "DarkDateTimePicker";
            this.Size = new System.Drawing.Size(200, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnDropDown;
    }
}
