using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copyparty_Launcher_GUI.Logic
{
    public class AppSettings
    {
        public string CopyPartyExePath { get; set; }

        // All of the copyparty-specific configurations
        public CopyPartySettings PartyConfig { get; set; }

        public AppSettings()
        {
            // Ensure PartyConfig is never null
            PartyConfig = new CopyPartySettings();
        }
    }
}
