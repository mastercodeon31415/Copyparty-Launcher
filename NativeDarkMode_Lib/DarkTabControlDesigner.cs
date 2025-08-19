using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace NativeDarkMode_Lib
{
    public class DarkTabControlDesigner : ParentControlDesigner
    {
        private IComponentChangeService _changeService;

        public override void Initialize(IComponent component)
        {
            base.Initialize(component);
            _changeService = (IComponentChangeService)GetService(typeof(IComponentChangeService));
            if (_changeService != null)
            {
                _changeService.ComponentChanged += OnComponentChanged;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (_changeService != null)
            {
                _changeService.ComponentChanged -= OnComponentChanged;
            }
            base.Dispose(disposing);
        }

        private void OnComponentChanged(object sender, ComponentChangedEventArgs e)
        {
            if (e.Component is DarkTabPage page && page.Parent == this.Control)
            {
                if (e.Member != null && e.Member.Name == "Text")
                {
                    (this.Control as DarkTabControl)?.RebuildTabs();
                }
            }
        }

        // Verbs are no longer needed as the CollectionEditor handles everything.
        //public override DesignerVerbCollection Verbs => new DesignerVerbCollection();

        // WndProc for handling design-time clicks remains essential.
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0x0201) // WM_LBUTTONDOWN
            {
                DarkTabControl tabControl = this.Control as DarkTabControl;
                if (tabControl == null) return;
                Point mousePos = new Point(m.LParam.ToInt32() & 0xFFFF, m.LParam.ToInt32() >> 16);
                var headerPanel = tabControl.panelTabButtons;

                if (headerPanel.Bounds.Contains(mousePos))
                {
                    Point relativeMousePos = headerPanel.PointToClient(this.Control.PointToScreen(mousePos));
                    foreach (Control child in headerPanel.Controls)
                    {
                        if (child is RadioButton tabButton && tabButton.Bounds.Contains(relativeMousePos))
                        {
                            DarkTabPage pageToSelect = tabButton.Tag as DarkTabPage;
                            if (pageToSelect != null)
                            {
                                var prop = TypeDescriptor.GetProperties(tabControl)["SelectedTab"];
                                prop?.SetValue(tabControl, pageToSelect);
                                tabControl.Invalidate(true);
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
