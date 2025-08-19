using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace NativeDarkMode_Lib
{
    public partial class DarkDateTimePicker : UserControl
    {
        private DateTime _value;
        private Form _popupForm;
        private DarkMonthCalendar _monthCalendar;

        [Category("Data")]
        public DateTime Value
        {
            get => _value;
            set
            {
                if (_value != value)
                {
                    _value = value;
                    txtDate.Text = _value.ToShortDateString();
                    // We don't need to set the calendar date here, it's handled when the popup opens.
                    OnValueChanged(EventArgs.Empty);
                }
            }
        }

        [Category("Action")]
        public event EventHandler ValueChanged;

        public DarkDateTimePicker()
        {
            InitializeComponent();
            InitializePopupCalendar();

            Value = DateTime.Now;
            txtDate.BackColor = Color.FromArgb(50, 50, 50);
            txtDate.ForeColor = Color.Silver;
            btnDropDown.BackColor = Color.FromArgb(50, 50, 50);
            btnDropDown.ForeColor = Color.Silver;
            btnDropDown.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80);
        }

        private void InitializePopupCalendar()
        {
            _monthCalendar = new DarkMonthCalendar { };
            _monthCalendar.DateSelected += MonthCalendar_DateSelected;

            Size calendarSize = _monthCalendar.Size;

            _popupForm = new Form
            {
                FormBorderStyle = FormBorderStyle.None,
                ShowInTaskbar = false,
                StartPosition = FormStartPosition.Manual,
                TopMost = true,
                Size = new Size(227, 162)
            };
            _popupForm.Controls.Add(_monthCalendar);
            // Use Hide() instead of Close() for better performance.
            _popupForm.Deactivate += (s, e) => _popupForm.Hide();
        }

        private void btnDropDown_Click(object sender, EventArgs e)
        {
            if (_popupForm.Visible)
            {
                _popupForm.Hide();
                return;
            }

            // <<< FIX #2: Set the calendar's date to the current value BEFORE showing it. >>>
            _monthCalendar.SetDate(this.Value);

            Rectangle screenRect = Screen.FromControl(this).WorkingArea;
            Point location = this.PointToScreen(new Point(0, this.Height));

            if (location.Y + _popupForm.Height > screenRect.Bottom)
            {
                location.Y = this.PointToScreen(Point.Empty).Y - _popupForm.Height;
            }

            _popupForm.Location = location;
            _popupForm.Show();
            _popupForm.Activate();
        }

        private void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            // <<< FIX #1: Use the event argument 'e.Start' directly for accuracy. >>>
            this.Value = e.Start;
            _popupForm.Hide();
        }

        protected virtual void OnValueChanged(EventArgs e)
        {
            ValueChanged?.Invoke(this, e);
        }
    }
}
