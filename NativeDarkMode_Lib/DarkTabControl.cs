using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Windows.Forms;

namespace NativeDarkMode_Lib
{

    [Designer(typeof(DarkTabControlDesigner))]
    public partial class DarkTabControl : UserControl, ISupportInitialize
    {
        // 2. Add a flag to track the initialization state
        private bool _isInitializing;
        private DarkTabPage _selectedTab;

        // 1. THIS IS THE KEY: A private, persistent list to hold the pages.
        // This is the single source of truth for the collection editor.
        private readonly DarkList<DarkTabPage> _tabPages;

        #region --- Properties ---

        /// <summary>
        /// A proxy property that enables the Collection Editor in the designer.
        /// It works by reading from and writing to the control's main Controls collection.
        /// </summary>
        [Category("Data")]
        [Description("The collection of TabPage controls in the tab control.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor(typeof(DarkTabPageCollectionEditor), typeof(UITypeEditor))]
        public DarkList<DarkTabPage> TabPages
        {
            get
            {
                //RebuildTabs();
                // 2. Always return the SAME persistent list instance.
                return _tabPages;
            }
            set
            {
                // 3. This setter is now the synchronization point. It's called when the
                //    user clicks "OK" in the Collection Editor.
                if (value == null) return;

                this.SuspendLayout();

                // Remove all old pages from the master Controls collection.
                var oldPages = this.Controls.OfType<DarkTabPage>().ToArray();
                foreach (var page in oldPages)
                {
                    this.Controls.Remove(page);
                }

                // Clear our internal list.
                _tabPages.Clear();

                // Add the new pages from the editor to both our internal list
                // and the master Controls collection.
                if (value.Any())
                {
                    _tabPages.AddRange(value);
                    this.Controls.AddRange(value.ToArray());
                }

                this.ResumeLayout(true);
                RebuildTabs();
            }
        }

        //[Category("Data")]
        //[Description("The collection of TabPage controls in the tab control.")]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        //[Editor(typeof(DarkTabPageCollectionEditor), typeof(UITypeEditor))]
        //public DarkTabPage[] TabPages => this.Controls.OfType<DarkTabPage>().ToArray<DarkTabPage>();



        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DarkTabPage SelectedTab
        {
            get => _selectedTab;
            set
            {
                if (_selectedTab == value) return;
                _selectedTab = value;

                // Do not update the UI while the designer is initializing.
                // The full update will be triggered by EndInit() calling RebuildTabs().
                if (!_isInitializing)
                {
                    UpdateTabSelection();
                }
            }
        }

        [Category("Appearance")][DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] public Color ActiveTabColor { get; set; } = Color.FromArgb(60, 60, 60);
        [Category("Appearance")][DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] public Color InactiveTabColor { get; set; } = Color.FromArgb(45, 45, 45);
        [Category("Appearance")][DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] public Color HeaderBackgroundColor { get; set; } = Color.FromArgb(33, 33, 33);
        [Category("Appearance")][DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] public Color HeaderForegroundColor { get; set; } = Color.Silver;
        [Category("Appearance")][DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] public Color ContentBackgroundColor { get; set; } = Color.FromArgb(33, 33, 33);

        #endregion

        public DarkTabControl()
        {
            _tabPages = new DarkList<DarkTabPage>();
            //System.Diagnostics.Debugger.Launch();
            InitializeComponent();
            this.Resize += DarkTabControl_Resize;
            this.BackColor = ContentBackgroundColor;
        }

        #region --- ISupportInitialize Implementation ---

        // 3. Implement the BeginInit and EndInit methods
        public void BeginInit()
        {
            _isInitializing = true;
        }

        public void EndInit()
        {
            _isInitializing = false;
            // This single call will now correctly build the UI based on the
            // state configured by the designer.
            RebuildTabs();
        }

        #endregion

        #region --- Core Logic ---

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            // This logic can be removed or kept, but the EndInit is more reliable for the designer.
            if (!this.DesignMode)
            {
                RebuildTabs();
            }
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            if (e.Control is DarkTabPage page)
            {
                _tabPages.Add((DarkTabPage)e.Control);
                //page.Visible = this.DesignMode;
                // 4. Prevent RebuildTabs from being called during initialization
                if (this.DesignMode && !_isInitializing)
                {
                    RebuildTabs();
                }
            }
            base.OnControlAdded(e);
        }

        protected override void OnControlRemoved(ControlEventArgs e)
        {
            if (e.Control is DarkTabPage)
            {
                _tabPages.Remove((DarkTabPage)e.Control);
                // 5. Prevent RebuildTabs from being called during initialization
                if (this.DesignMode && !_isInitializing)
                {
                    RebuildTabs();
                }
            }
            base.OnControlRemoved(e);

        }

        private void DarkTabControl_Resize(object sender, EventArgs e)
        {
            UpdatePageLayout();
        }

        public void RebuildTabs()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(RebuildTabs));
                return;
            }

            this.BorderStyle = BorderStyle.None;

            panelTabButtons.Controls.Clear();
            panelTabButtons.BackColor = HeaderBackgroundColor;

            var val = this.Controls.OfType<DarkTabPage>().ToArray();
            for (int i = 0; i < val.Length; i++)
            {
                DarkTabPage page = val[i];
                RadioButton tabButton = new RadioButton
                {
                    Appearance = Appearance.Button,
                    Text = page.Text,
                    Tag = page,
                    Size = new Size(100, 24),
                    TextAlign = ContentAlignment.MiddleCenter,
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = HeaderForegroundColor,
                    BackColor = InactiveTabColor
                };
                tabButton.FlatAppearance.BorderSize = 0;
                tabButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 80);
                tabButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
                tabButton.FlatAppearance.CheckedBackColor = ActiveTabColor;
                tabButton.CheckedChanged += TabButton_CheckedChanged;
                panelTabButtons.Controls.Add(tabButton);
            }

            //foreach (DarkTabPage page in this.Controls.OfType<DarkTabPage>())
            //{
            //    RadioButton tabButton = new RadioButton
            //    {
            //        Appearance = Appearance.Button,
            //        Text = page.Text,
            //        Tag = page,
            //        Size = new Size(100, 24),
            //        TextAlign = ContentAlignment.MiddleCenter,
            //        FlatStyle = FlatStyle.Flat,
            //        ForeColor = HeaderForegroundColor,
            //        BackColor = InactiveTabColor
            //    };
            //    tabButton.FlatAppearance.BorderSize = 0;
            //    tabButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 80);
            //    tabButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(20, 20, 20);
            //    tabButton.FlatAppearance.CheckedBackColor = ActiveTabColor;
            //    tabButton.CheckedChanged += TabButton_CheckedChanged;
            //    panelTabButtons.Controls.Add(tabButton);
            //}

            var currentPages = this.Controls.OfType<DarkTabPage>();
            if (SelectedTab != null && !currentPages.Contains(SelectedTab))
            {
                SelectedTab = currentPages.FirstOrDefault();
            }
            else if (SelectedTab == null && currentPages.Any())
            {
                SelectedTab = currentPages.First();
            }
            else
            {
                UpdateTabSelection();
            }
        }

        private void TabButton_CheckedChanged(object sender, EventArgs e)
        {
            var selectedButton = sender as RadioButton;
            if (selectedButton != null && selectedButton.Checked)
            {
                SelectedTab = selectedButton.Tag as DarkTabPage;
            }
        }

        private void UpdateTabSelection()
        {
            UpdatePageLayout();

            foreach (var button in panelTabButtons.Controls.OfType<RadioButton>())
            {
                var page = button.Tag as DarkTabPage;
                if (page != null)
                {
                    bool isSelected = (page == _selectedTab);
                    button.Checked = isSelected;
                    button.BackColor = isSelected ? ActiveTabColor : InactiveTabColor;
                }
            }

            foreach (var page in this.Controls.OfType<DarkTabPage>())
            {
                bool isSelected = (page == _selectedTab);
                if (!this.DesignMode)
                {
                    if (page.Visible != isSelected) page.Visible = isSelected;
                }
                if (isSelected) page.BringToFront();
            }
        }

        private void UpdatePageLayout()
        {
            Rectangle contentBounds = new Rectangle(
                this.ClientRectangle.Left,
                this.ClientRectangle.Top + panelTabButtons.Height,
                this.ClientRectangle.Width,
                this.ClientRectangle.Height - panelTabButtons.Height);

            foreach (var page in this.Controls.OfType<DarkTabPage>())
            {
                page.Bounds = contentBounds;
                page.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            }
        }

        #endregion
    }
}