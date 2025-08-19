using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace NativeDarkMode_Lib
{
    /// <summary>
    /// Represents a single page within the DarkTabControl. It is essentially a Panel
    /// with a visible Text property for the tab header.
    /// </summary>
    [ToolboxItem(false)] // This attribute prevents the control from appearing in the Visual Studio Toolbox.
                         // It should only be created and used as part of a DarkTabControl.
    [Serializable]
    public class DarkTabPage : DarkPanel
    {
        /// <summary>
        /// Gets or sets the text to be displayed on the tab's header button.
        /// The [Browsable(true)] attribute makes this property visible in the designer's Properties window.
        /// </summary>
        [Category("Appearance")]
        [Browsable(true)]
        public override string Text { get; set; }

        public DarkTabPage() : base()
        {
            this.BorderStyle = BorderStyle.None;

        }
    }
}