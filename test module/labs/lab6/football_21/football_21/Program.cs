namespace football_21 {
    class Program {
        static void Main() {
            StreamWriter sw = null!;
            string path;
            
            try {
                Console.Write("Введите полный путь для создания файла с записанной информацией: ");
                path = Console.ReadLine()!;
                sw = File.CreateText(path);
                Console.Write("Введите кол-во футболистов информацию о которых хотите записать в файл: ");
                int n = int.Parse(Console.ReadLine()!);
                for (int i = 0; i < n; i++) {
                    sw.Write($"Футболист№{i + 1}:");
                    Console.Write("Фамилия: ");
                    sw.Write("Фамилия: {0}", Console.ReadLine());
                    Console.Write("Имя: ");
                    sw.Write(" Имя: {0}", Console.ReadLine());
                    Console.Write("Отчество: ");
                    sw.Write(" Отчество:{0}", Console.ReadLine());
                    Console.Write("Рост: ");
                    sw.Write(" Рост: {0}", Console.ReadLine());
                    Console.Write("Вес: ");
                    sw.Write(" Вес: {0}", Console.ReadLine());
                    Console.Write("Дата рождения: ");
                    sw.Write(" Дата рождения: {0}", Console.ReadLine());
                    Console.Write("Номер телефона: ");
                    sw.Write(" Номер телефона: {0}", Console.ReadLine());
                    Console.Write("Название команды: ");
                    sw.Write(" Название команды: {0}", Console.ReadLine());
                    Console.Write("Номер в команде: ");
                    sw.Write(" Номер в команде: {0}", Console.ReadLine());
                    Console.Write("Амплуа: ");
                    sw.Write(" Амплуа:{0};", Console.ReadLine());
                    Console.Write("Результативность: ");
                    sw.Write(" Результативность: {0}", Console.ReadLine());
                    Console.Write("Количество игр: ");
                    sw.Write(" Количество игр: {0}", Console.ReadLine());
                    sw.WriteLine();
                }
            }
            catch (FileNotFoundException) {
                Console.WriteLine("Файл не найден!");
                return;
            }
            catch (FormatException) {
                Console.WriteLine("Некорректный ввод параметров");
                return;
            }
            catch (DirectoryNotFoundException) {
                Console.WriteLine("Путь не найден!");
                return;
            }
            catch (DriveNotFoundException) {
                Console.WriteLine("Такого диска нет в системе!");
                return;
            }
            catch (PathTooLongException) {
                Console.WriteLine("Система не может читать слишком длинное название файла!");
                return;
            }
            catch (UnauthorizedAccessException) {
                Console.WriteLine("Система не может изменить данный файл!");
                return;
            }
            finally {
                sw.Close();
            }
            try {
                
                Console.Write("Введите полный путь для создания файла с необходимой для вывода информацией: ");
                string path2 = Console.ReadLine()!;
                sw = File.CreateText(path2);
                string[] playCount;
                foreach (string line in File.ReadLines(path)) {
                    playCount = line.Split(" ");
                    foreach (string l in playCount) {
                        Console.WriteLine(l);
                    }
                    if (Convert.ToUInt32(playCount[27]) > 50) {
                        Console.WriteLine(line);
                        sw.WriteLine(line);
                    }
                }
                /* Console.Write("Введите полный путь для создания файла с необходимой для вывода информацией: ");
                 string path2 = Console.ReadLine()!;
                 sw = File.CreateText(path2);
                 string word;
                 string[] playCount;
                 foreach (string line in File.ReadLines(path)) {
                     word = line;
                     playCount = word.Split(" ");
                     foreach (string play in playCount) {
                         if (play.Contains("Количество игр")) {
                             // Получаем количество игр футболиста
                             string[] parts = line.Split(':');
                             int games = int.Parse(parts[1].Trim());
                             if (games > 50) {
                                 // Создаем новый файл для записи
                                 sw.WriteLine("Футболист с более чем 50 играми:");
                                 sw.Write(line); // Записываем информацию о футболисте
                                                 // Продолжаем чтение и запись остальной информации о футболисте
                                 for (int i = 0; i < 11; i++) {
                                     sw.WriteLine(word);
                                 }
                             }
                         }
                     }
                 }*/
            }
            catch (FileNotFoundException) {
                Console.WriteLine("Ошибка: Файл не найден!");
            }
            catch (DirectoryNotFoundException) {
                Console.WriteLine("Ошибка: Путь не найден!");
            }
            catch (DriveNotFoundException) {
                Console.WriteLine("Ошибка: Такого диска нет в системе!");
            }
            catch (PathTooLongException) {
                Console.WriteLine("Ошибка: Система не может читать слишком длинное название файла");
            }
            catch (UnauthorizedAccessException) {
                Console.WriteLine("Ошибка: Вы указали путь, ведущий к каталогу, но не к конкретному файлу!");
            }
            finally {
                sw.Close();
            }
        }
    }
}
