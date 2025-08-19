using Microsoft.Win32;
using System;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NativeDarkMode_Lib.Utils
{
	public static class DarkMessageBox
	{
		#region PInvoke and Structures for Dark Title Bar
		[DllImport("dwmapi.dll", PreserveSig = true)]
		private static extern int DwmSetWindowAttribute(IntPtr hwnd, DWMWINDOWATTRIBUTE attr, ref int attrValue, int attrSize);

		private enum DWMWINDOWATTRIBUTE
		{
			DWMWA_USE_IMMERSIVE_DARK_MODE = 20
		}
		#endregion

		#region Private Fields - Theming Colors
		private static readonly Color DarkModeContentBack = Color.FromArgb(43, 43, 43);
		private static readonly Color DarkModeActionBarBack = Color.FromArgb(32, 32, 32);
		private static readonly Color DarkModeFore = Color.White;
		private static readonly Color DarkModeButtonBorder = Color.FromArgb(80, 80, 80);
		private static readonly Color DefaultButtonBack = Color.FromArgb(0, 120, 215);
		#endregion

		#region Public Show Methods (Mirrors System.Windows.Forms.MessageBox)
		// All 12 overloads are included for drop-in replacement
		public static DialogResult Show(string text) => ShowMessageBox(null, text, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.None);
		public static DialogResult Show(string text, string caption) => ShowMessageBox(null, text, caption, MessageBoxButtons.OK, MessageBoxIcon.None);
		public static DialogResult Show(string text, string caption, MessageBoxButtons buttons) => ShowMessageBox(null, text, caption, buttons, MessageBoxIcon.None);
		public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon) => ShowMessageBox(null, text, caption, buttons, icon);
		public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton) => ShowMessageBox(null, text, caption, buttons, icon, defaultButton);
		public static DialogResult Show(Form owner, string text) => ShowMessageBox(owner, text, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.None);
		public static DialogResult Show(Form owner, string text, string caption) => ShowMessageBox(owner, text, caption, MessageBoxButtons.OK, MessageBoxIcon.None);
		public static DialogResult Show(Form owner, string text, string caption, MessageBoxButtons buttons) => ShowMessageBox(owner, text, caption, buttons, MessageBoxIcon.None);
		public static DialogResult Show(Form owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon) => ShowMessageBox(owner, text, caption, buttons, icon);
		public static DialogResult Show(Form owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton) => ShowMessageBox(owner, text, caption, buttons, icon, defaultButton);
		public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options) => ShowMessageBox(null, text, caption, buttons, icon, defaultButton, options);
		public static DialogResult Show(Form owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options) => ShowMessageBox(owner, text, caption, buttons, icon, defaultButton, options);
		#endregion

		#region Core Logic

		private static bool IsSystemInDarkMode()
		{
			try
			{
				return (int?)Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize")?.GetValue("AppsUseLightTheme") == 0;
			}
			catch { return false; }
		}

		private static DialogResult ShowMessageBox(Form owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon = MessageBoxIcon.Information, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1, MessageBoxOptions options = 0)
		{
			using (var msgBox = new Form())
			{
				msgBox.Text = caption;
				msgBox.BackColor = DarkModeContentBack;
				msgBox.ForeColor = DarkModeFore;
				msgBox.FormBorderStyle = FormBorderStyle.FixedDialog;
				msgBox.StartPosition = owner == null ? FormStartPosition.CenterScreen : FormStartPosition.CenterParent;
				msgBox.MaximizeBox = false;
				msgBox.MinimizeBox = false;
				msgBox.ShowInTaskbar = false;
				msgBox.Font = SystemFonts.MessageBoxFont;
				if (owner != null)
				{
					if (owner.Icon != null)
					{
						msgBox.Icon = owner.Icon;
					}
				}

				int useImmersiveDarkMode = 1;
				DwmSetWindowAttribute(msgBox.Handle, DWMWINDOWATTRIBUTE.DWMWA_USE_IMMERSIVE_DARK_MODE, ref useImmersiveDarkMode, sizeof(int));

				var actionBarPanel = new FlowLayoutPanel { FlowDirection = FlowDirection.RightToLeft, Dock = DockStyle.Bottom, BackColor = DarkModeActionBarBack, Height = 50, Padding = new Padding(0, 10, 8, 10) };
				var contentPanel = new TableLayoutPanel { Dock = DockStyle.Fill, BackColor = DarkModeContentBack, ColumnCount = 2, RowCount = 1, Padding = new Padding(24, 24, 24, 12), ColumnStyles = { new ColumnStyle(SizeType.AutoSize), new ColumnStyle(SizeType.Percent, 100F) } };

				msgBox.Controls.Add(contentPanel);
				msgBox.Controls.Add(actionBarPanel);

				if (icon == MessageBoxIcon.None) icon = MessageBoxIcon.Information;

				PictureBox iconPictureBox = AddIcon(contentPanel, icon);
				iconPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;

				var messageLabel = new Label { Text = text, Dock = DockStyle.Fill, TextAlign = ContentAlignment.TopLeft, AutoSize = false, Margin = new Padding(10, 10, 0, 0) };
				contentPanel.Controls.Add(messageLabel, 1, 0);

				AddButtons(actionBarPanel, buttons, defaultButton, msgBox);

				// --- NEW SIZING LOGIC ---
				int minWidth = 350;
				int buttonsWidth = actionBarPanel.Controls.Cast<Control>().Sum(c => c.Width + c.Margin.Left + c.Margin.Right) + actionBarPanel.Padding.Horizontal;
				int textAndIconWidth = TextRenderer.MeasureText(text, msgBox.Font).Width + (iconPictureBox?.Width ?? 0) + contentPanel.Padding.Horizontal + messageLabel.Margin.Horizontal;
				int finalWidth = Math.Max(minWidth, Math.Max(buttonsWidth, textAndIconWidth));

				int labelWidth = finalWidth - contentPanel.Padding.Horizontal - (iconPictureBox?.Width ?? 0) - messageLabel.Margin.Horizontal;
				Size textSize = TextRenderer.MeasureText(text, msgBox.Font, new Size(labelWidth, 0), TextFormatFlags.WordBreak);

				int contentHeight = Math.Max(iconPictureBox?.Height ?? 0, textSize.Height) + contentPanel.Padding.Vertical;

				msgBox.ClientSize = new Size(finalWidth, contentHeight + actionBarPanel.Height);

				ReThemer.ThemeAllControls(msgBox);

				PlayIconSound(icon);

				return owner == null ? msgBox.ShowDialog() : msgBox.ShowDialog(owner);
			}
		}

		private static PictureBox AddIcon(TableLayoutPanel panel, MessageBoxIcon icon)
		{
			Icon systemIcon;
			switch (icon)
			{
				case MessageBoxIcon.Information: systemIcon = SystemIcons.Information; break;
				case MessageBoxIcon.Question: systemIcon = SystemIcons.Question; break;
				case MessageBoxIcon.Warning: systemIcon = SystemIcons.Warning; break;
				case MessageBoxIcon.Error: systemIcon = SystemIcons.Error; break;
                case MessageBoxIcon.None: systemIcon = null; break;
                default:
				panel.ColumnStyles[0].Width = 0;
				panel.Padding = new Padding(12, 24, 24, 12);
				return null;
			}
            var iconPictureBox = new PictureBox { Image = new Bitmap(systemIcon.ToBitmap(), new Size(32, 32)), SizeMode = PictureBoxSizeMode.CenterImage, Size = new Size(40, 40), Dock = DockStyle.Top };
			panel.Controls.Add(iconPictureBox, 0, 0);
			return iconPictureBox;
		}

		private static void AddButtons(FlowLayoutPanel panel, MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton, Form parentForm)
		{
			Button CreateButton(string text, DialogResult result, bool isDefault)
			{
				var button = new Button { Text = text, DialogResult = result, FlatStyle = FlatStyle.System, MinimumSize = new Size(85, 25), Margin = new Padding(5, 0, 0, 0), AutoSize = true };
				button.FlatAppearance.BorderColor = DarkModeButtonBorder;
				button.FlatAppearance.BorderSize = 1;

				int useImmersiveDarkMode = 1;
				DwmSetWindowAttribute(button.Handle, DWMWINDOWATTRIBUTE.DWMWA_USE_IMMERSIVE_DARK_MODE, ref useImmersiveDarkMode, sizeof(int));

				if (isDefault)
				{
					button.BackColor = DefaultButtonBack;
					button.ForeColor = DarkModeFore;
					parentForm.AcceptButton = button;
				}
				else
				{
					button.BackColor = panel.BackColor;
					button.ForeColor = DarkModeFore;
				}

				button.Click += (sender, e) => { parentForm.Close(); };
				panel.Controls.Add(button);
				return button;
			}

			switch (buttons)
			{
				case MessageBoxButtons.OK: CreateButton("OK", DialogResult.OK, true); break;
				case MessageBoxButtons.OKCancel: CreateButton("Cancel", DialogResult.Cancel, defaultButton == MessageBoxDefaultButton.Button2); CreateButton("OK", DialogResult.OK, defaultButton == MessageBoxDefaultButton.Button1); break;
				case MessageBoxButtons.YesNo: CreateButton("No", DialogResult.No, defaultButton == MessageBoxDefaultButton.Button2); CreateButton("Yes", DialogResult.Yes, defaultButton == MessageBoxDefaultButton.Button1); break;
				case MessageBoxButtons.YesNoCancel: CreateButton("Cancel", DialogResult.Cancel, defaultButton == MessageBoxDefaultButton.Button3); CreateButton("No", DialogResult.No, defaultButton == MessageBoxDefaultButton.Button2); CreateButton("Yes", DialogResult.Yes, defaultButton == MessageBoxDefaultButton.Button1); break;
				case MessageBoxButtons.RetryCancel: CreateButton("Cancel", DialogResult.Cancel, defaultButton == MessageBoxDefaultButton.Button2); CreateButton("Retry", DialogResult.Retry, defaultButton == MessageBoxDefaultButton.Button1); break;
				case MessageBoxButtons.AbortRetryIgnore: CreateButton("Ignore", DialogResult.Ignore, defaultButton == MessageBoxDefaultButton.Button3); CreateButton("Retry", DialogResult.Retry, defaultButton == MessageBoxDefaultButton.Button2); CreateButton("Abort", DialogResult.Abort, defaultButton == MessageBoxDefaultButton.Button1); break;
			}
		}

		private static void PlayIconSound(MessageBoxIcon icon)
		{
			switch (icon)
			{
				case MessageBoxIcon.Information: SystemSounds.Asterisk.Play(); break;
				case MessageBoxIcon.Question: SystemSounds.Question.Play(); break;
				case MessageBoxIcon.Warning: SystemSounds.Exclamation.Play(); break;
				case MessageBoxIcon.Error: SystemSounds.Hand.Play(); break;
			}
		}

		#endregion
	}
}
