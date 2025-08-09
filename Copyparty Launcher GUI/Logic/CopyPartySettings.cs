using System.Collections.Generic;
using System.ComponentModel;

namespace Copyparty_Launcher_GUI.Logic
{
    // ===================================================================
    // Helper classes for repeatable options and complex types
    // ===================================================================

    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class Group
    {
        public string Name { get; set; }
        public string Members { get; set; } // Comma-separated list of users
    }

    public class MimeType
    {
        public string Extension { get; set; }
        public string Mime { get; set; }
    }

    public class Permission
    {
        public string Type { get; set; } // r, rw, wG, etc.
        public string Users { get; set; } // *, ed, k, ed,k
    }

    public class Flag
    {
        public string Name { get; set; } // e2d, nodupe, fk
        public string Value { get; set; } // (null), (null), 4
    }

    public class Volume
    {
        public string SourcePath { get; set; }
        public string DestPath { get; set; }
        public BindingList<Permission> Permissions { get; set; } = new BindingList<Permission>();
        public BindingList<Flag> Flags { get; set; } = new BindingList<Flag>();
    }


    // ===================================================================
    // The main settings class, mirroring copyparty's options
    // ===================================================================
    public class CopyPartySettings
    {
        #region General Options
        public int MaxClients { get; set; } = 486; // -nc
        public int Cores { get; set; } = 1; // -j
        public BindingList<Account> Accounts { get; set; } = new BindingList<Account>(); // -a
        public BindingList<Volume> Volumes { get; set; } = new BindingList<Volume>(); // -v
        public BindingList<Group> Groups { get; set; } = new BindingList<Group>(); // --grp
        public bool Usernames { get; set; } // --usernames
        public bool EnableDots { get; set; } // -ed
        public string UrlForm { get; set; } = "print,xm"; // --urlform
        public string ServerName { get; set; } = "Copyparty GUI"; // --name
        public BindingList<MimeType> MimeTypes { get; set; } = new BindingList<MimeType>(); // --mime
        public bool RMagic { get; set; } // --rmagic
        #endregion

        #region Network Options
        public string Ip { get; set; } = "::"; // -i
        public string Port { get; set; } = "3923"; // -p
        public bool ReuseAddr { get; set; } // --reuseaddr
        #endregion

        #region SSL/TLS Options
        public bool HttpOnly { get; set; } // --http-only
        public bool HttpsOnly { get; set; } // --https-only
        public string CertPath { get; set; } = ""; // --cert
        #endregion

        #region Zeroconf & Discovery Options (NEW and existing)
        // General
        public bool EnableQrCode { get; set; } // --qr
        public bool EnableZeroconf { get; set; } // -z
        public string ZOnNets { get; set; } = ""; // --z-on
        public string ZOffNets { get; set; } = ""; // --z-off
        public int ZChkSec { get; set; } = 10; // --z-chk
        public bool ZVerbose { get; set; } // -zv
        public int McHopSec { get; set; } = 0; // --mc-hop
        public bool redirectOutput { get; set; } = false;

        // mDNS
        public bool Zm { get; set; } // --zm
        public bool Zm4 { get; set; } // --zm4
        public bool Zm6 { get; set; } // --zm6
        public bool Zmv { get; set; } // --zmv
        public string ZmsServices { get; set; } = ""; // --zms
        public double ZmSpamSec { get; set; } = 0; // --zm-spam

        // SSDP
        public bool Zs { get; set; } // --zs
        public bool Zsv { get; set; } // --zsv
        public string ZsLocation { get; set; } = "/?hc"; // --zsl
        #endregion

        #region Upload Options
        public bool DotPart { get; set; } // --dotpart
        public bool Dedup { get; set; } // --dedup
        public bool Hardlink { get; set; } // --hardlink
        public bool Reflink { get; set; } // --reflink
        public bool NoDupe { get; set; } // --no-dupe
        #endregion

        #region Database & Thumbs Options
        // General DB
        public bool EnableE2D { get; set; }
        public bool EnableE2DS { get; set; }
        public bool EnableE2DSA { get; set; }
        public string HistPath { get; set; } = ""; // --hist
        public int RescanMaxAge { get; set; } = 0; // --re-maxage

        // Metadata DB
        public bool EnableE2T { get; set; }
        public bool EnableE2TS { get; set; }
        public bool EnableE2TSR { get; set; }

        // Thumbnail
        public bool NoThumb { get; set; } // --no-thumb
        public bool NoVThumb { get; set; } // --no-vthumb
        public bool NoAThumb { get; set; } // --no-athumb
        public string ThSize { get; set; } = "320x256"; // --th-size
        #endregion

        #region Protocol Options
        // FTP
        public int FtpPort { get; set; } = 0; // --ftp
        public int FtpsPort { get; set; } = 0; // --ftps
                                               // WebDAV
        public bool Dav { get; set; } // --daw
        public bool DavInf { get; set; } // --dav-inf
        #endregion

        #region Security & Safety
        public bool Safety1 { get; set; } // -s
        public bool Safety2 { get; set; } // -ss
        public bool Safety3 { get; set; } // -sss
        public bool XVol { get; set; } // --xvol
        public bool XDev { get; set; } // --xdev
        public string BanPw { get; set; } = "9,60,1440"; // --ban-pw
        public string Ban403 { get; set; } = "9,2,1440"; // --ban-403
        #endregion

        #region UI Options
        public bool Grid { get; set; } // --grid
        public bool LocalTime { get; set; } // --localtime
        public bool NoBranding { get; set; } // -nb
        #endregion

        #region Logging Options
        public bool Quiet { get; set; } // -q
        public string LogFile { get; set; } = ""; // -lo
        public bool LogConn { get; set; } // --log-conn
        #endregion
    }
}
