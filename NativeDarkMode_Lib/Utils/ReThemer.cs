using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NativeDarkMode_Lib.Utils
{
	public class ReThemer
	{
		// A constant for setting the Mica effect.
		// The DWMWA_SYSTEMBACKDROP_TYPE attribute requires an integer value
		// to specify the backdrop type. 2 corresponds to Mica.
		public const int DWM_SYSTEMBACKDROP_TYPE_MICA = 2;

		// Enum to define the various attributes that can be set via DwmSetWindowAttribute.
		// The values correspond to the Win32 API definitions.
		public enum DwmWindowAttribute
		{
			// ... other attributes are omitted for brevity ...

			// This attribute is used to set the immersive dark mode for the window.
			DWMWA_USE_IMMERSIVE_DARK_MODE = 20,

			// This is the attribute to set a system backdrop type like Mica, Acrylic, or Tabbed.
			DWMWA_SYSTEMBACKDROP_TYPE = 38
		}

		/// <summary>
		/// Applies a visual style to a specified window.
		/// Used for applying the "DarkMode_Explorer" theme.
		/// </summary>
		/// <param name="hWnd">Handle to the window to which the theme is to be applied.</param>
		/// <param name="pszSubAppName">The theme name, e.g., "DarkMode_Explorer".</param>
		/// <param name="pszSubIdList">Null-terminated list of class IDs to apply the theme to.</param>
		/// <returns>Returns S_OK if successful, or an error value otherwise.</returns>
		[DllImport("uxtheme.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
		public static extern int SetWindowTheme(
			IntPtr hWnd,
			string pszSubAppName,
			string pszSubIdList
		);

		/// <summary>
		/// Sets the value of a specified Desktop Window Manager (DWM) attribute on a window.
		/// This is used to enable dark mode and the Mica effect.
		/// </summary>
		/// <param name="hwnd">The handle to the window to apply the attribute to.</param>
		/// <param name="attribute">The DWM attribute to set.</param>
		/// <param name="pvAttribute">A pointer to the attribute value.</param>
		/// <param name="cbAttribute">The size, in bytes, of the attribute value.</param>
		/// <returns>Returns S_OK if successful, or an error value otherwise.</returns>
		[DllImport("dwmapi.dll", PreserveSig = true)]
		public static extern int DwmSetWindowAttribute(
			IntPtr hwnd,
			DwmWindowAttribute attribute,
			ref int pvAttribute,
			int cbAttribute
		);

		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		public static extern IntPtr CreateRoundRectRgn
		(
			int nLeftRect,     // x-coordinate of upper-left corner
			int nTopRect,      // y-coordinate of upper-left corner
			int nRightRect,    // x-coordinate of lower-right corner
			int nBottomRect,   // y-coordinate of lower-right corner
			int nWidthEllipse, // width of ellipse
			int nHeightEllipse // height of ellipse
		);

		public static int WM_NCHITTEST = 0x84;
		public static int HT_CAPTION = 0x2;

		public static void ThemeAllControls(Control parent)
		{
			Action<Control> Theme = control => {
				int trueValue = 0x01;
				SetWindowTheme(control.Handle, "DarkMode_Explorer", null);
				DwmSetWindowAttribute(control.Handle, DwmWindowAttribute.DWMWA_USE_IMMERSIVE_DARK_MODE, ref trueValue, Marshal.SizeOf(typeof(int)));
				DwmSetWindowAttribute(control.Handle, DwmWindowAttribute.DWMWA_SYSTEMBACKDROP_TYPE, ref trueValue, Marshal.SizeOf(typeof(int)));
			};
			foreach (Control control in parent.Controls)
			{
				Theme(control);
				if (control.Controls.Count != 0)
					ThemeAllControls(control);
			}
		}

		public static void ThemeControl(Control control)
		{
            int trueValue = 0x01;
            SetWindowTheme(control.Handle, "DarkMode_Explorer", null);
            DwmSetWindowAttribute(control.Handle, DwmWindowAttribute.DWMWA_USE_IMMERSIVE_DARK_MODE, ref trueValue, Marshal.SizeOf(typeof(int)));
            DwmSetWindowAttribute(control.Handle, DwmWindowAttribute.DWMWA_SYSTEMBACKDROP_TYPE, ref trueValue, Marshal.SizeOf(typeof(int)));
        }

		public static void RestartExplorer()
		{
			var explorerProcess = Process.GetProcesses().FirstOrDefault(p => p.ProcessName == "explorer");
			if (explorerProcess != null)
				explorerProcess.Kill();
		}
	}
}
