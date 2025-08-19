using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace NativeDarkMode_Lib
{
    public class ComboBoxPainter : NativeWindow, IDisposable
    {
        // Public Properties for Customization
        [DefaultValue(typeof(Color), "Gray")]
        public Color BorderColor { get; set; } = Color.Gray;

        [DefaultValue(typeof(Color), "LightGray")]
        public Color ButtonColor { get; set; } = Color.FromArgb(99, 99, 99);

        [DefaultValue(typeof(Color), "White")]
        public Color ArrowColor { get; set; } = Color.White;

        private readonly ComboBox originalComboBox;
        private Bitmap buffer; // Our double buffer for flicker-free drawing

        public ComboBoxPainter(ComboBox comboBox)
        {
            this.originalComboBox = comboBox;

            // Hook events to manage the buffer and force redraws
            originalComboBox.SizeChanged += OnSizeChanged;
            this.AssignHandle(comboBox.Handle);

            // *** THE FIX: Use reflection to call the protected SetStyle method ***
            SetControlStyle(originalComboBox, ControlStyles.OptimizedDoubleBuffer, true);
            SetControlStyle(originalComboBox, ControlStyles.ResizeRedraw, true);

            CreateBuffer();
        }

        /// <summary>
        /// Uses reflection to call the protected SetStyle method on a control.
        /// </summary>
        private static void SetControlStyle(Control control, ControlStyles style, bool value)
        {
            MethodInfo method = typeof(Control).GetMethod("SetStyle", BindingFlags.NonPublic | BindingFlags.Instance);
            if (method != null)
            {
                method.Invoke(control, new object[] { style, value });
            }
        }


        private void OnSizeChanged(object sender, EventArgs e)
        {
            CreateBuffer();
            originalComboBox.Invalidate();
        }

        private void CreateBuffer()
        {
            // Dispose of the old buffer if it exists
            buffer?.Dispose();

            // Create a new buffer if the control is valid
            if (originalComboBox.IsHandleCreated && originalComboBox.Width > 0 && originalComboBox.Height > 0)
            {
                buffer = new Bitmap(originalComboBox.Width, originalComboBox.Height);
            }
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                // We are taking full control of the WM_PAINT message.
                // We will not call base.WndProc here.
                case WM_PAINT:
                    if (originalComboBox.DropDownStyle != ComboBoxStyle.Simple && buffer != null)
                    {
                        // Start the painting process
                        PAINTSTRUCT ps = new PAINTSTRUCT();
                        IntPtr hdc = BeginPaint(originalComboBox.Handle, ref ps);

                        // 1. Draw the entire control's appearance to our in-memory buffer
                        using (Graphics g = Graphics.FromImage(buffer))
                        {
                            PaintComboBox(g);
                        }

                        // 2. Draw the completed buffer onto the screen in one operation
                        using (Graphics screenG = Graphics.FromHdc(hdc))
                        {
                            screenG.DrawImage(buffer, Point.Empty);
                        }

                        // End the painting process
                        EndPaint(originalComboBox.Handle, ref ps);
                    }
                    else
                    {
                        base.WndProc(ref m);
                    }
                    // Message is handled, do not call base.
                    return;

                // Prevent the OS from drawing its default non-client area (border/button)
                case WM_NCPAINT:
                    // By not calling base.WndProc, we suppress the default painting
                    // that causes the flicker.
                    break;

                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        private void PaintComboBox(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // --- Define Rectangles ---
            var clientRect = originalComboBox.ClientRectangle;
            var dropDownButtonWidth = SystemInformation.HorizontalScrollBarArrowWidth + 2;
            var borderRect = new Rectangle(clientRect.Location, new Size(clientRect.Width - 1, clientRect.Height - 1));
            var dropDownRect = new Rectangle(clientRect.Width - dropDownButtonWidth, 0, dropDownButtonWidth, clientRect.Height);
            // Define a text area with a small padding
            var textRect = new Rectangle(2, 2, clientRect.Width - dropDownButtonWidth - 4, clientRect.Height - 4);

            // --- Determine Colors based on state ---
            var currentBorderColor = originalComboBox.Enabled ? this.BorderColor : SystemColors.ControlDark;
            var currentButtonColor = originalComboBox.Enabled ? this.ButtonColor : SystemColors.Control;
            var currentArrowColor = originalComboBox.Enabled ? this.ArrowColor : SystemColors.ControlDark;
            var currentBackColor = originalComboBox.Enabled ? originalComboBox.BackColor : SystemColors.Control;
            var currentTextColor = originalComboBox.Enabled ? originalComboBox.ForeColor : SystemColors.GrayText;

            // --- Perform Drawing operations sequentially ---

            // 1. Draw Background
            using (var b = new SolidBrush(currentBackColor))
            {
                g.FillRectangle(b, clientRect);
            }

            // 2. Draw Text (This is now our responsibility)
            TextRenderer.DrawText(g,
                                  originalComboBox.Text,
                                  originalComboBox.Font,
                                  textRect,
                                  currentTextColor,
                                  TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);

            // 3. Draw Button Background
            using (var b = new SolidBrush(currentButtonColor))
            {
                g.FillRectangle(b, dropDownRect);
            }

            // 4. Draw Dropdown Arrow
            var middle = new Point(dropDownRect.Left + dropDownRect.Width / 2, dropDownRect.Top + dropDownRect.Height / 2);
            var arrow = new Point[]
            {
                new Point(middle.X - 3, middle.Y - 2),
                new Point(middle.X + 4, middle.Y - 2),
                new Point(middle.X, middle.Y + 2)
            };
            using (var b = new SolidBrush(currentArrowColor))
            {
                g.FillPolygon(b, arrow);
            }

            // 5. Draw Border
            using (var p = new Pen(currentBorderColor))
            {
                g.DrawRectangle(p, borderRect);
            }
        }

        // --- P/Invoke for custom painting ---
        private const int WM_PAINT = 0xF;
        private const int WM_NCPAINT = 0x85;

        [StructLayout(LayoutKind.Sequential)]
        public struct PAINTSTRUCT { public IntPtr hdc; public bool fErase; public RECT rcPaint; public bool fRestore; public bool fIncUpdate; [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] public byte[] rgbReserved; }
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT { public int Left, Top, Right, Bottom; }

        [DllImport("user32.dll")]
        private static extern IntPtr BeginPaint(IntPtr hWnd, ref PAINTSTRUCT lpPaint);
        [DllImport("user32.dll")]
        private static extern bool EndPaint(IntPtr hWnd, ref PAINTSTRUCT lpPaint);

        // --- IDisposable for cleaning up resources ---
        public void Dispose()
        {
            buffer?.Dispose();
            // This stops the message interception
            this.ReleaseHandle();
        }
    }
}
