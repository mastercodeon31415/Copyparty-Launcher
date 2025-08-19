using NativeDarkMode_Lib.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NativeDarkMode_Lib
{
    // Custom renderer classes for MenuStrip and ToolStrip styling
    internal class DarkThemeColorTable : ProfessionalColorTable
    {
        private Color backColor = Color.FromArgb(33, 33, 33);
        private Color selectedColor = Color.FromArgb(60, 60, 60);
        private Color borderColor = Color.FromArgb(80, 80, 80);

        public override Color MenuBorder => borderColor;
        public override Color MenuItemBorder => borderColor;
        public override Color MenuItemSelected => selectedColor;
        public override Color ToolStripDropDownBackground => backColor;
        public override Color ImageMarginGradientBegin => backColor;
        public override Color ImageMarginGradientMiddle => backColor;
        public override Color ImageMarginGradientEnd => backColor;
        public override Color MenuItemPressedGradientBegin => backColor;
        public override Color MenuItemPressedGradientEnd => backColor;
        public override Color MenuItemSelectedGradientBegin => selectedColor;
        public override Color MenuItemSelectedGradientEnd => selectedColor;
        public override Color MenuStripGradientBegin => backColor;
        public override Color MenuStripGradientEnd => backColor;
        public override Color ToolStripGradientBegin => backColor;
        public override Color ToolStripGradientMiddle => backColor;
        public override Color ToolStripGradientEnd => backColor;
        public override Color StatusStripGradientBegin => backColor;
        public override Color StatusStripGradientEnd => backColor;
        public override Color SeparatorDark => borderColor;
        public override Color SeparatorLight => borderColor;
    }

    internal class DarkThemeRenderer : ToolStripProfessionalRenderer
    {
        public DarkThemeRenderer() : base(new DarkThemeColorTable())
        {
            this.RoundedEdges = false;
        }
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            e.TextColor = Color.Silver;
            base.OnRenderItemText(e);
        }
        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {

        }
    }

    public class Converter
    {
        public static void DarkModeEnable(Form frm)
        {
            ReThemer.ThemeAllControls(frm);

            // The DarkTabControl handles its own theme. We just need to theme the main form
            // and the contents of the tab pages.
            frm.BackColor = Color.FromArgb(33, 33, 33);
            ApplyDarkTheme(frm.Controls);
        }

        private static void ApplyDarkTheme(Control.ControlCollection controls)
        {
            Color backColor = Color.FromArgb(33, 33, 33);
            Color foreColor = Color.Silver;
            Color borderColor = Color.FromArgb(80, 80, 80);

            foreach (Control control in controls)
            {

                // Set default back and fore colors
                try { if (!(control is DarkTabControl)) control.BackColor = backColor; } catch { }
                try { control.ForeColor = foreColor; } catch { }

                // --- Handle Specific Control Types ---
                if (control is Button button)
                {
                    button.FlatStyle = FlatStyle.System;
                    button.FlatAppearance.BorderColor = borderColor;
                    button.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60);
                    button.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
                    ReThemer.ThemeControl(button);
                }
                else if (control is TextBox || control is RichTextBox || control is MaskedTextBox)
                {
                    control.BackColor = Color.FromArgb(50, 50, 50);
                    if (control is TextBoxBase tb) { tb.BorderStyle = BorderStyle.FixedSingle; ReThemer.ThemeControl(tb); }
                    if (control is RichTextBox rb) {rb.BorderStyle = BorderStyle.None; }
                }
                else if (control is ListBox || control is CheckedListBox)
                {
                    control.BackColor = Color.FromArgb(50, 50, 50);
                    if (control is ListBox lb) { lb.BorderStyle = BorderStyle.FixedSingle; ReThemer.ThemeControl(lb); }
                    if (control is CheckedListBox clb) { clb.BorderStyle = BorderStyle.FixedSingle; ReThemer.ThemeControl(clb); }
                }
                else if (control is ComboBox cb)
                {
                    control.BackColor = Color.FromArgb(50, 50, 50);
                    cb.FlatStyle = FlatStyle.Flat;
                    ReThemer.ThemeControl(cb);

                    ComboBoxPainter painter = new ComboBoxPainter(cb);
                    
                }
                else if (control is DataGridView dgv)
                {
                    //dgv.BackgroundColor = backColor;
                    //dgv.GridColor = borderColor;
                    //dgv.BorderStyle = BorderStyle.FixedSingle;
                    //dgv.EnableHeadersVisualStyles = false;
                    //dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
                    //dgv.ColumnHeadersDefaultCellStyle.ForeColor = foreColor;
                    //dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                    //dgv.DefaultCellStyle.BackColor = backColor;
                    //dgv.DefaultCellStyle.ForeColor = foreColor;
                    //dgv.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
                    //dgv.DefaultCellStyle.SelectionForeColor = Color.White;
                    //dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
                    ReThemer.ThemeControl(dgv);

                    // Make sure to set this property to false to apply your custom styles
                    dgv.EnableHeadersVisualStyles = false;

                    // --- Style for the Main Grid ---
                    dgv.BackgroundColor = Color.FromArgb(45, 45, 48);
                    dgv.GridColor = Color.FromArgb(60, 60, 60);
                    dgv.BorderStyle = BorderStyle.None;


                    // --- Style for the Column Headers ---
                    DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                    columnHeaderStyle.BackColor = Color.FromArgb(60, 60, 60);
                    columnHeaderStyle.ForeColor = Color.White;
                    // MODIFICATION: Changed FontStyle.Bold to FontStyle.Regular
                    columnHeaderStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                    columnHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dgv.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
                    dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                    dgv.ColumnHeadersHeight = 30;
                    // NEW: Remove the 3D border around the column headers
                    dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;


                    // --- Style for the Row Headers (the leftmost column) ---
                    DataGridViewCellStyle rowHeaderStyle = new DataGridViewCellStyle();
                    rowHeaderStyle.BackColor = Color.FromArgb(60, 60, 60);
                    rowHeaderStyle.ForeColor = Color.White;
                    rowHeaderStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
                    rowHeaderStyle.SelectionForeColor = Color.White;
                    dgv.RowHeadersDefaultCellStyle = rowHeaderStyle;
                    // NEW: Remove the 3D border around the row headers
                    dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;


                    // --- Style for the Data Cells ---
                    DataGridViewCellStyle defaultCellStyle = new DataGridViewCellStyle();
                    defaultCellStyle.BackColor = Color.FromArgb(45, 45, 48);
                    defaultCellStyle.ForeColor = Color.White;
                    defaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
                    defaultCellStyle.SelectionForeColor = Color.White;
                    defaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    dgv.DefaultCellStyle = defaultCellStyle;


                    // --- Style for Alternating Rows ---
                    DataGridViewCellStyle alternatingRowStyle = new DataGridViewCellStyle();
                    alternatingRowStyle.BackColor = Color.FromArgb(52, 52, 55);
                    alternatingRowStyle.ForeColor = Color.White;
                    alternatingRowStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
                    alternatingRowStyle.SelectionForeColor = Color.White;
                    dgv.AlternatingRowsDefaultCellStyle = alternatingRowStyle;
                }
                else if (control is ListView lv)
                {
                    lv.BackColor = Color.FromArgb(50, 50, 50);
                    lv.ForeColor = foreColor;
                    lv.BorderStyle = BorderStyle.FixedSingle;
                    ReThemer.ThemeControl(lv);

                    // --- SETUP ---
                    // 1. Ensure OwnerDraw is true on your ListView (listView1 in this example)
                    lv.OwnerDraw = true;

                    // 2. Add a dummy "filler" column at the end. 
                    //    Set its text to empty and you can give it an initial small width.
                    //    We will resize it automatically in the Resize event.
                    lv.Columns.Add("", -2, HorizontalAlignment.Left);

                    // 3. Hook up the drawing and resize events
                    lv.DrawColumnHeader += new DrawListViewColumnHeaderEventHandler(lv_DrawColumnHeader);
                    lv.DrawSubItem += new DrawListViewSubItemEventHandler(lv_DrawSubItem); // For drawing item text
                    lv.Resize += new EventHandler(lv_Resize);
                }
                else if (control is TreeView tv)
                {
                    tv.BackColor = Color.FromArgb(50, 50, 50);
                    tv.ForeColor = foreColor;
                    tv.LineColor = borderColor;
                    tv.BorderStyle = BorderStyle.FixedSingle;
                    ReThemer.ThemeControl(tv);
                }
                else if (control is ToolStrip ts)
                {
                    ts.Renderer = new DarkThemeRenderer();
                    ReThemer.ThemeControl(ts);
                }
                else if (control is GroupBox gb)
                {
                    gb.ForeColor = foreColor;
                    ReThemer.ThemeControl(gb);
                }

                ReThemer.ThemeControl(control);

                // Recursively apply to child controls
                if (control.HasChildren)
                {
                    ApplyDarkTheme(control.Controls);
                }
            }
        }

        // --- EVENT HANDLERS ---

        // 1. Draw the column headers
        private static void lv_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // Define your dark theme colors
            Color headerBackColor = Color.FromArgb(60, 60, 60);
            Color headerTextColor = Color.White;
            Color headerBorderColor = Color.FromArgb(80, 80, 80);

            // Fill the background
            using (SolidBrush backBrush = new SolidBrush(headerBackColor))
            {
                e.Graphics.FillRectangle(backBrush, e.Bounds);
            }

            // Draw the header text
            TextRenderer.DrawText(e.Graphics, e.Header.Text, e.Font, e.Bounds, headerTextColor,
                                  TextFormatFlags.VerticalCenter | TextFormatFlags.Left);

            // Draw the border (a line on the right of each header)
            using (Pen borderPen = new Pen(headerBorderColor))
            {
                e.Graphics.DrawLine(borderPen, e.Bounds.Right - 1, 0, e.Bounds.Right - 1, e.Bounds.Height);
            }
        }

        // 2. Draw the item text (to ensure it's visible on a dark background)
        private static void lv_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            // This ensures the text is drawn. Without this, you may see no text.
            e.DrawText();
        }


        // 3. Automatically resize the last "filler" column
        private static void lv_Resize(object sender, EventArgs e)
        {
            // This is the trick to remove the white space on the right.
            // We resize the last column to fill the empty space.
            ListView listView = sender as ListView;
            if (listView == null || listView.Columns.Count == 0) return;

            int totalColumnWidths = 0;
            // Get the total width of all columns except the last one
            for (int i = 0; i < listView.Columns.Count - 1; i++)
            {
                totalColumnWidths += listView.Columns[i].Width;
            }

            // Get the last column
            ColumnHeader lastColumn = listView.Columns[listView.Columns.Count - 1];

            // Calculate the remaining width and set it for the last column
            int remainingWidth = listView.ClientSize.Width - totalColumnWidths;
            lastColumn.Width = remainingWidth;
        }
    }
}
