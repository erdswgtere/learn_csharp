namespace football_21 {
    class Program {
        static void Main() {
            StreamWriter sw = null!;
            string path;
            while (true) {
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
                    break;
                }
                catch (FileNotFoundException) {
                    Console.WriteLine("Файл не найден!");
                    continue;
                }
                catch (FormatException) {
                    Console.WriteLine("Некорректный ввод параметров");
                    continue;
                }
                catch (DirectoryNotFoundException) {
                    Console.WriteLine("Путь не найден!");
                    continue;
                }
                catch (DriveNotFoundException) {
                    Console.WriteLine("Такого диска нет в системе!");
                    continue;
                }
                catch (PathTooLongException) {
                    Console.WriteLine("Система не может читать слишком длинное название файла!");
                    continue;
                }
                catch (UnauthorizedAccessException) {
                    Console.WriteLine("Система не может изменить данный файл!");
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
                finally {
                    sw?.Close();
                }
            }
            while (true) {
                try {
                    Console.Write("Введите полный путь для создания файла с необходимой для вывода информацией: ");
                    string path2 = Console.ReadLine()!;
                    sw = File.CreateText(path2);
                    string[] playCount;
                    foreach (string line in File.ReadLines(path)) {
                        playCount = line.Split(" ");
                        if (Convert.ToUInt32(playCount[27]) > 50) {
                            Console.WriteLine(line);
                            sw.WriteLine(line);
                        }
                    }
                    break;
                }
                catch (FileNotFoundException) {
                    Console.WriteLine("Ошибка: Файл не найден!");
                    continue;
                }
                catch (DirectoryNotFoundException) {
                    Console.WriteLine("Ошибка: Путь не найден!");
                    continue;
                }
                catch (DriveNotFoundException) {
                    Console.WriteLine("Ошибка: Такого диска нет в системе!");
                    continue;
                }
                catch (PathTooLongException) {
                    Console.WriteLine("Ошибка: Система не может читать слишком длинное название файла");
                    continue;
                }
                catch (UnauthorizedAccessException) {
                    Console.WriteLine("Ошибка: Вы указали путь, ведущий к каталогу, но не к конкретному файлу!");
                    continue;
                }
                finally {
                    sw?.Close();
                }
            }
        }
    }
}
