using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NativeDarkMode_Lib
{
    [ToolboxItem(false)] // This attribute prevents the control from appearing in the Visual Studio Toolbox.
                         // It should only be created and used as part of a DarkTabControl.
    [Serializable]
    public class DarkPanel : Panel
    {
        public DarkPanel()
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            base.BorderStyle = BorderStyle.None;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new BorderStyle BorderStyle
        {
            get { base.BorderStyle = BorderStyle.None; return BorderStyle.None; }
            set
            {
                base.BorderStyle = BorderStyle.None;
            }
        }
    }
}
