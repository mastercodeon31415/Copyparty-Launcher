using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NativeDarkMode_Lib.Utils
{
	public class DarkModeTitleBar
	{
		[DllImport("dwmapi.dll", PreserveSig = true)]
		private static extern int DwmSetWindowAttribute(IntPtr hwnd, DWMWINDOWATTRIBUTE attr, ref int attrValue, int attrSize);

		[DllImport("dwmapi.dll", PreserveSig = true)]
		private static extern int DwmSetWindowAttribute(IntPtr hwnd, DWMWINDOWATTRIBUTE attr, ref COLORREF attrValue, int attrSize);

		private enum DWMWINDOWATTRIBUTE
		{
			DWMWA_USE_IMMERSIVE_DARK_MODE = 20,
			DWMWA_CAPTION_COLOR = 35,
			DWMWA_TEXT_COLOR = 36
		}

		[StructLayout(LayoutKind.Sequential)]
		private struct COLORREF
		{
			public byte R;
			public byte G;
			public byte B;
		}

		// Constants for the window messages
		private const int WM_NCACTIVATE = 0x0086;

		private static readonly COLORREF DarkModeBackColor = new COLORREF { R = 0x20, G = 0x20, B = 0x20 }; // #202020
		private static readonly COLORREF ActiveTextColor = new COLORREF { R = 0xC0, G = 0xC0, B = 0xC0 }; // Silver
		private static readonly COLORREF InactiveTextColor = new COLORREF { R = 0x66, G = 0x66, B = 0x66 }; // Darker Gray

		/// <summary>
		/// Enables a dark mode title bar for the given WinForms Form.
		/// </summary>
		/// <param name="form">The Form to modify.</param>
		public static void Enable(Form form)
		{
			if (form == null) throw new ArgumentNullException(nameof(form));

			try
			{
				// Enable immersive dark mode. This is the primary switch.
				int useImmersiveDarkMode = 1;
				var result = DwmSetWindowAttribute(form.Handle, DWMWINDOWATTRIBUTE.DWMWA_USE_IMMERSIVE_DARK_MODE, ref useImmersiveDarkMode, sizeof(int));

				if (result != 0)
				{
					// Log or handle the error if immersive dark mode is not supported.
					Console.WriteLine($"Failed to set DWMWA_USE_IMMERSIVE_DARK_MODE. HRESULT: {result:X}");
				}

				// Set the background color of the title bar
				// **FIX APPLIED HERE**
				var backColor = DarkModeBackColor;
				DwmSetWindowAttribute(form.Handle, DWMWINDOWATTRIBUTE.DWMWA_CAPTION_COLOR, ref backColor, Marshal.SizeOf<COLORREF>());

				// Initially set the active text color
				SetTitleBarTextColor(form.Handle, true);
			}
			catch (Exception ex)
			{
				// Log or handle the exception
				Console.WriteLine($"An error occurred while enabling dark mode: {ex.Message}");
			}
		}

		/// <summary>
		/// Overrides the window procedure to handle title bar color changes on activation.
		/// This method should be called from within the form's overridden WndProc.
		/// </summary>
		/// <param name="m">The window message.</param>
		public static void WndProc(ref Message m)
		{
			if (m.Msg == WM_NCACTIVATE)
			{
				// wParam is TRUE when the window is being activated, FALSE when deactivated.
				bool active = m.WParam != IntPtr.Zero;
				SetTitleBarTextColor(m.HWnd, active);
			}
		}

		private static void SetTitleBarTextColor(IntPtr hwnd, bool active)
		{
			try
			{
				var textColor = active ? ActiveTextColor : InactiveTextColor;
				DwmSetWindowAttribute(hwnd, DWMWINDOWATTRIBUTE.DWMWA_TEXT_COLOR, ref textColor, Marshal.SizeOf<COLORREF>());
			}
			catch (Exception ex)
			{
				Console.WriteLine($"An error occurred while setting text color: {ex.Message}");
			}
		}
	}
}
