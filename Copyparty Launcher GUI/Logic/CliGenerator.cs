using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Copyparty_Launcher_GUI.Logic
{
    public static class CliGenerator
    {
        private static void AddIf(List<string> args, bool condition, string arg)
        {
            if (condition) args.Add(arg);
        }

        private static void AddIfVal(List<string> args, string value, string argFormat)
        {
            if (!string.IsNullOrWhiteSpace(value)) args.Add(string.Format(argFormat, value));
        }

        public static string Generate(CopyPartySettings s)
        {
            var args = new List<string>();

            // General
            if (s.MaxClients != 486) args.Add($"-nc {s.MaxClients}");
            if (s.Cores != 1) args.Add($"-j {s.Cores}");
            AddIfVal(args, s.ServerName, "--name \"{0}\"");
            AddIf(args, s.Usernames, "--usernames");
            AddIf(args, s.EnableDots, "-ed");
            AddIf(args, s.RMagic, "--rmagic");

            // Network
            AddIfVal(args, s.Ip, "-i \"{0}\"");
            AddIfVal(args, s.Port, "-p {0}");
            AddIf(args, s.ReuseAddr, "--reuseaddr");

            // Accounts & Groups
            foreach (var acc in s.Accounts) args.Add($"-a {acc.Username}:{acc.Password}");
            foreach (var grp in s.Groups) args.Add($"--grp {grp.Name}:{grp.Members}");

            // Volumes
            foreach (var vol in s.Volumes)
            {
                var perms = vol.Permissions.Select(p => (string.IsNullOrWhiteSpace(p.Users) || p.Users.Trim() == "*") ? p.Type : $"{p.Type},{p.Users}");
                var flags = vol.Flags.Select(f => string.IsNullOrWhiteSpace(f.Value) ? f.Name : $"{f.Name}={f.Value}");
                var volArgs = string.Join(":", perms.Concat(flags));
                args.Add($"-v \"{vol.SourcePath}:{vol.DestPath}:{volArgs}\"");
            }

            // Discovery (Zeroconf, mDNS, SSDP)
            AddIf(args, s.EnableQrCode, "--qr");
            AddIf(args, s.EnableZeroconf, "-z");
            AddIfVal(args, s.ZOnNets, "--z-on \"{0}\"");
            AddIfVal(args, s.ZOffNets, "--z-off \"{0}\"");
            if (s.ZChkSec != 10) args.Add($"--z-chk {s.ZChkSec}");
            AddIf(args, s.ZVerbose, "-zv");
            if (s.McHopSec > 0) args.Add($"--mc-hop {s.McHopSec}");
            AddIf(args, s.Zm, "--zm");
            AddIf(args, s.Zm4, "--zm4");
            AddIf(args, s.Zm6, "--zm6");
            AddIf(args, s.Zmv, "--zmv");
            AddIfVal(args, s.ZmsServices, "--zms {0}");
            if (s.ZmSpamSec > 0) args.Add($"--zm-spam {s.ZmSpamSec.ToString(CultureInfo.InvariantCulture)}");
            AddIf(args, s.Zs, "--zs");
            AddIf(args, s.Zsv, "--zsv");
            if (s.ZsLocation != "/?hc") AddIfVal(args, s.ZsLocation, "--zsl \"{0}\"");

            // Uploads
            AddIf(args, s.DotPart, "--dotpart");
            AddIf(args, s.Dedup, "--dedup");
            AddIf(args, s.Hardlink, "--hardlink");
            AddIf(args, s.Reflink, "--reflink");
            AddIf(args, s.NoDupe, "--no-dupe");

            // Database & Thumbs
            AddIf(args, s.EnableE2D, "-e2d");
            AddIf(args, s.EnableE2DS, "-e2ds");
            AddIf(args, s.EnableE2DSA, "-e2dsa");
            AddIf(args, s.EnableE2T, "-e2t");
            AddIf(args, s.EnableE2TS, "-e2ts");
            AddIf(args, s.EnableE2TSR, "-e2tsr");
            if (s.RescanMaxAge > 0) args.Add($"--re-maxage {s.RescanMaxAge}");
            AddIf(args, s.NoThumb, "--no-thumb");
            AddIf(args, s.NoVThumb, "--no-vthumb");
            AddIf(args, s.NoAThumb, "--no-athumb");
            if (s.ThSize != "320x256") AddIfVal(args, s.ThSize, "--th-size {0}");

            // Protocols
            if (s.FtpPort > 0) args.Add($"--ftp {s.FtpPort}");
            if (s.FtpsPort > 0) args.Add($"--ftps {s.FtpsPort}");
            AddIf(args, s.Dav, "--daw");
            AddIf(args, s.DavInf, "--dav-inf");

            // Security
            AddIf(args, s.Safety1, "-s");
            AddIf(args, s.Safety2, "-ss");
            AddIf(args, s.Safety3, "-sss");
            AddIf(args, s.XVol, "--xvol");
            AddIf(args, s.XDev, "--xdev");
            if (s.BanPw != "9,60,1440") AddIfVal(args, s.BanPw, "--ban-pw {0}");
            if (s.Ban403 != "9,2,1440") AddIfVal(args, s.Ban403, "--ban-403 {0}");

            // SSL
            AddIf(args, s.HttpOnly, "--http-only");
            AddIf(args, s.HttpsOnly, "--https-only");
            AddIfVal(args, s.CertPath, "--cert \"{0}\"");

            // UI
            AddIf(args, s.Grid, "--grid");
            AddIf(args, s.LocalTime, "--localtime");
            AddIf(args, s.NoBranding, "-nb");

            // Logging
            AddIf(args, s.Quiet, "-q");
            AddIfVal(args, s.LogFile, "-lo \"{0}\"");
            AddIf(args, s.LogConn, "--log-conn");

            return string.Join(" ", args);
        }
    }
}
