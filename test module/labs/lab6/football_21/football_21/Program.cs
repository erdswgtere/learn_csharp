namespace football_21 {
    using System;
    using System.IO;

    class Program {
        static void Main() {
            var sw = OpenStream(@".\textfile");
            if (sw is null) return;
            sw.WriteLine("This is the first line.");
            sw.WriteLine("This is the second line.");
            sw.Close();
        }

        static StreamWriter? OpenStream(string path) {
            if (path is null) {
                Console.WriteLine("You did not supply a file path.");
                return null;
            }
            while (true) {
                try {
                    var fs = new FileStream(path, FileMode.CreateNew);
                    return new StreamWriter(fs);
                }
                catch (FileNotFoundException) {
                    Console.WriteLine("The file or directory cannot be found.");
                    continue;
                }
                catch (DirectoryNotFoundException) {
                    Console.WriteLine("The file or directory cannot be found.");
                    continue;
                }
                catch (DriveNotFoundException) {
                    Console.WriteLine("The drive specified in 'path' is invalid.");
                    continue;
                }
                catch (PathTooLongException) {
                    Console.WriteLine("'path' exceeds the maximum supported path length.");
                    continue;
                }
                catch (UnauthorizedAccessException) {
                    Console.WriteLine("You do not have permission to create this file.");
                    continue;
                }
                catch (IOException e) when ((e.HResult & 0x0000FFFF) == 32) {
                    Console.WriteLine("There is a sharing violation.");
                    continue;
                }
                catch (IOException e) when ((e.HResult & 0x0000FFFF) == 80) {
                    Console.WriteLine("The file already exists.");
                    continue;
                }
                catch (IOException e) {
                    Console.WriteLine($"An exception occurred:\nError code: " +
                                      $"{e.HResult & 0x0000FFFF}\nMessage: {e.Message}");
                    continue;
                }
            }
        }
    }
}
