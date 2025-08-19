using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Globalization;
using System.Windows.Forms;

namespace NativeDarkMode_Lib
{
    // Inherit from Control, not MonthCalendar. This gives us a blank canvas.
    public class DarkMonthCalendar : Control
    {
        #region --- Fields & Properties ---

        private DateTime _currentMonth;
        private DateTime _selectionStart;
        private readonly ContextMenuStrip _contextMenu;

        public DateTime SelectionStart
        {
            get => _selectionStart;
            set
            {
                if (_selectionStart.Date != value.Date)
                {
                    _selectionStart = value;
                    this.Invalidate();
                }
            }
        }

        public event DateRangeEventHandler DateSelected;

        // Colors
        private readonly Color _darkBackColor = Color.FromArgb(50, 50, 50);
        private readonly Color _darkForeColor = Color.FromArgb(220, 220, 220);
        private readonly Color _titleBackColor = Color.FromArgb(80, 80, 80);
        private readonly Color _arrowColor = Color.FromArgb(200, 200, 200);
        private readonly Color _dayOfWeekForeColor = Color.FromArgb(150, 150, 150);
        private readonly Color _trailingForeColor = Color.FromArgb(100, 100, 100);
        private readonly Color _selectedBackColor = Color.FromArgb(0, 120, 215);
        private readonly Color _todayCircleColor = Color.FromArgb(0, 120, 215);

        private const int HEADER_HEIGHT = 30;
        private const int DAYOFWEEK_HEIGHT = 20;

        #endregion

        public DarkMonthCalendar()
        {
            this.DoubleBuffered = true;
            _currentMonth = DateTime.Today;
            _selectionStart = DateTime.Today;
            this.Size = new Size(227, 162);

            _contextMenu = new ContextMenuStrip();
            var goToTodayItem = new ToolStripMenuItem("Go to Today");
            goToTodayItem.Click += GoToToday_Click;
            _contextMenu.Items.Add(goToTodayItem);
            _contextMenu.Renderer = new DarkMenuRenderer();
            this.ContextMenuStrip = _contextMenu;
        }

        #region --- Public Methods ---

        public void SetDate(DateTime date)
        {
            this.SelectionStart = date;
            _currentMonth = new DateTime(date.Year, date.Month, 1);
            this.Invalidate();
        }

        #endregion

        #region --- Interaction, Events & Drawing ---

        private void GoToToday_Click(object sender, EventArgs e)
        {
            // Set the view to the current month.
            _currentMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);

            // Set the visual selection highlight to today's date.
            // This will trigger a repaint via the property's setter.
            this.SelectionStart = DateTime.Today;

            // <<< THIS IS THE FIX >>>
            // We DO NOT fire the DateSelected event here. This leaves the user in control
            // to make the final selection with a left-click.
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            // Handle header navigation clicks
            if (e.Button == MouseButtons.Left && e.Y <= HEADER_HEIGHT)
            {
                if (e.X < 25) _currentMonth = _currentMonth.AddMonths(-1);
                else if (e.X > this.Width - 25) _currentMonth = _currentMonth.AddMonths(1);
                this.Invalidate();
                return;
            }

            // Handle date grid clicks for final selection
            if (e.Button == MouseButtons.Left)
            {
                DateTime? clickedDate = HitTestDate(e.Location);
                if (clickedDate.HasValue)
                {
                    this.SelectionStart = clickedDate.Value;
                    // Firing the event here finalizes the selection and closes the popup.
                    DateSelected?.Invoke(this, new DateRangeEventArgs(clickedDate.Value, clickedDate.Value));
                }
            }

            base.OnMouseDown(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // ... The entire OnPaint method is unchanged ...
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            g.Clear(_darkBackColor);
            var headerRect = new Rectangle(0, 0, Width, HEADER_HEIGHT);
            g.FillRectangle(new SolidBrush(_titleBackColor), headerRect);
            string title = $"{_currentMonth:MMMM yyyy}";
            TextRenderer.DrawText(g, title, Font, headerRect, _darkForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
            var arrowBrush = new SolidBrush(_arrowColor);
            g.FillPolygon(arrowBrush, new[] { new Point(10, 10), new Point(10, 20), new Point(5, 15) });
            g.FillPolygon(arrowBrush, new[] { new Point(Width - 10, 10), new Point(Width - 10, 20), new Point(Width - 5, 15) });
            var dayOfWeekRect = new Rectangle(0, headerRect.Bottom, Width, DAYOFWEEK_HEIGHT);
            float dayWidth = Width / 7f;
            for (int i = 0; i < 7; i++) { string dayName = CultureInfo.CurrentCulture.DateTimeFormat.GetShortestDayName((DayOfWeek)i); var rect = new RectangleF(i * dayWidth, dayOfWeekRect.Y, dayWidth, dayOfWeekRect.Height); g.DrawString(dayName, Font, new SolidBrush(_dayOfWeekForeColor), rect, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center }); }
            float cellWidth = Width / 7f;
            float cellHeight = (Height - dayOfWeekRect.Bottom) / 6f;
            DateTime firstDayToDraw = GetFirstDayToDraw();
            DateTime currentDate = firstDayToDraw;
            for (int row = 0; row < 6; row++) { for (int col = 0; col < 7; col++) { var cellRect = new RectangleF(col * cellWidth, dayOfWeekRect.Bottom + row * cellHeight, cellWidth, cellHeight); Color foreColor = (currentDate.Month == _currentMonth.Month) ? _darkForeColor : _trailingForeColor; var backgroundRect = cellRect; backgroundRect.Inflate(-2, -2); if (this.SelectionStart.Date == currentDate.Date) { g.FillRectangle(new SolidBrush(_selectedBackColor), backgroundRect); foreColor = Color.White; } if (currentDate.Date == DateTime.Today) { using (var pen = new Pen(_todayCircleColor, 1)) { g.DrawRectangle(pen, backgroundRect.X, backgroundRect.Y, backgroundRect.Width - 1, backgroundRect.Height - 1); } } g.DrawString(currentDate.Day.ToString(), Font, new SolidBrush(foreColor), cellRect, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center }); currentDate = currentDate.AddDays(1); } }
        }

        #endregion

        #region --- Helper Methods & Classes ---

        private DateTime GetFirstDayToDraw()
        {
            var firstDayOfPrimaryMonth = new DateTime(_currentMonth.Year, _currentMonth.Month, 1);
            int daysToSubtract = (int)firstDayOfPrimaryMonth.DayOfWeek - (int)CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek;
            if (daysToSubtract < 0) daysToSubtract += 7;
            return firstDayOfPrimaryMonth.AddDays(-daysToSubtract);
        }

        private DateTime? HitTestDate(Point location)
        {
            if (location.Y <= HEADER_HEIGHT + DAYOFWEEK_HEIGHT) return null;
            float cellWidth = Width / 7f;
            float cellHeight = (Height - HEADER_HEIGHT + DAYOFWEEK_HEIGHT) / 6f;
            int row = (int)((location.Y - (HEADER_HEIGHT + DAYOFWEEK_HEIGHT)) / cellHeight);
            int col = (int)(location.X / cellWidth);
            if (row < 0 || row > 5 || col < 0 || col > 6) return null;
            DateTime firstDayToDraw = GetFirstDayToDraw();
            int dayOffset = (row * 7) + col;
            return firstDayToDraw.AddDays(dayOffset);
        }

        private class DarkMenuRenderer : ToolStripProfessionalRenderer
        {
            public DarkMenuRenderer() : base(new DarkMenuColorTable()) { }
            protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e) { e.TextColor = Color.FromArgb(220, 220, 220); base.OnRenderItemText(e); }
        }

        private class DarkMenuColorTable : ProfessionalColorTable
        {
            private readonly Color _backColor = Color.FromArgb(50, 50, 50);
            private readonly Color _selectedColor = Color.FromArgb(80, 80, 80);
            private readonly Color _borderColor = Color.FromArgb(100, 100, 100);
            public override Color MenuItemSelected => _selectedColor;
            public override Color ToolStripDropDownBackground => _backColor;
            public override Color ImageMarginGradientBegin => _backColor;
            public override Color ImageMarginGradientMiddle => _backColor;
            public override Color ImageMarginGradientEnd => _backColor;
            public override Color MenuBorder => _borderColor;
            public override Color MenuItemBorder => _borderColor;
            public override Color SeparatorDark => _borderColor;
            public override Color MenuItemSelectedGradientBegin => _selectedColor;
            public override Color MenuItemSelectedGradientEnd => _selectedColor;
            public override Color MenuItemPressedGradientBegin => _selectedColor;
            public override Color MenuItemPressedGradientEnd => _selectedColor;
        }

        #endregion
    }
}
