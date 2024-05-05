using System.Security;
using static System.Console;
using static System.Convert;
class Information
{
    public static void Info()
    {
        Checkings ch = new();
        while (true) {
            Write("Введите путь файла для сохранения информации: ");
            string path = Console.ReadLine()!;
                if (File.Exists(path))
                {
                Write("Этот путь уже занят другим файлом!");
                continue;
                }
            StreamWriter swmain = File.CreateText(path);
            Write("Введите количество солдат: ");
            int n = ToInt32(ReadLine());
            if (n < 1)
            {
                Write("Некорректное количество солдат!\n");
                continue;
            }
            Dictionary<int, Soldier> SList = new(n);
            try
            {
                swmain.WriteLine("Солдаты\n\n");
                for (int i = 0; i < n; i++)
                {
                    int Number = i + 1;

                    Write($"\nСолдат {Number}: \n");
                    Write("Введите ФИО солдата: ");
                    string FIO = ReadLine()!;
                    if (!ch.FIO(FIO))
                    {
                        throw new MyException("Неправильно введена фамилия!");
                    }
                    Write("Введите его категорию годности: ");
                    char VC = ToChar(ReadLine()!);
                    if (ch.ValidityCategory(VC))
                    {
                        throw new MyException("Неправильно введена категория годности!");
                    }
                    Write($"Введите род войск: ");
                    string MB = ReadLine()!;
                    if (!ch.MilitaryBranch(MB))
                    {
                        throw new MyException("Неправильно введен род войск!");
                    }
                    Write("Введите его адрес проживания: ");
                    string Address = ReadLine()!;
                    if (!ch.Address(Address))
                    {
                        throw new MyException("Неправильно введен адрес!");
                    }
                    Write("Введите номер его паспорта (4 цифры): ");
                    string PassportNumber = ReadLine()!;
                    if (!ch.PassportNumber(PassportNumber))
                    {
                        throw new MyException("Неправильно введен номер паспорта!");
                    }
                    Write("Введите серию его паспорта (6 цифр): ");
                    string PassportSeries = ReadLine()!;
                    if (!ch.PassportSeries(PassportSeries))
                    {
                        throw new MyException("Неправильно введена серия паспорта!");
                    }
                    Soldier soldier = new(FIO, VC,
                        MB, Address, PassportNumber, PassportSeries);
                    SList.Add(Number, soldier);
                    swmain.WriteLine($"Солдат {Number}:\n");
                    swmain.WriteLine($"ФИО: {FIO}\n");
                    swmain.WriteLine($"Категория годности: {VC}\n");
                    swmain.WriteLine($"Род войск: {MB}\n");
                    swmain.WriteLine($"Адрес проживания: {Address}\n");
                    swmain.WriteLine($"Номер паспорта: {PassportNumber}\n");
                    swmain.WriteLine($"Серия паспорта: {PassportSeries}\n");
                }
                foreach (var x in SList)
                {
                    Selection(SList, swmain);
                    break;
                }
            }
            catch (FileNotFoundException)
            {
                WriteLine("Файл не найден");
            }
            catch (DirectoryNotFoundException)
            {
                WriteLine("Директория не найдена");
            }
            catch (DriveNotFoundException)
            {
                WriteLine("Вы указали несуществующий диск");
            }
            catch (PathTooLongException)
            {
                WriteLine("Слишком длинное имя файла/пути");
            }
            catch (SecurityException)
            {
                WriteLine("Ошибка безопасности");
            }
            catch (NotSupportedException)
            {
                WriteLine("Путь имеет недопустимый формат");
            }
            catch (FormatException)
            {
                Write("Проверьте правильность формата ввода.");
                continue;
            }
            catch (OverflowException)
            {
                Write("Значение выходит за пределы целевого типа.");
                continue;
            }
            catch (MyException ex)
            {
                WriteLine($"Ошибка! {ex.Message}");
                continue;
            }
            finally
            {
                if (swmain != null) swmain.Close();
            }
            break;

        }
            
    }
    public static void SoldierInformation(KeyValuePair<int, Soldier> SList)
    {
        WriteLine($"ФИО: {SList.Value.FIO}\n" +
            $"Категория годности: {SList.Value.ValidityCategory}\n" +
            $"Род войск: {SList.Value.MilitaryBranch}\n" +
            $"Адрес проживания: {SList.Value.Address}" +
            $"\nНомер паспорта: {SList.Value.PassportNumber}\n" +
            $"Серия паспорта: {SList.Value.PassportSeries}\n");
    }

    public static void Selection(Dictionary<int, Soldier> SList, StreamWriter file)
    {
        while (true)
        {
            ;
            WriteLine("\nВыберите действие: \n");
            WriteLine("1 - вывод информации о всех солдатах");
            WriteLine("2 - вывод информации о конкретном солдате");
            WriteLine("3 - добавить солдата");
            WriteLine("4 - удалить всех солдат");
            WriteLine("5 - удалить конкретного солдата");
            WriteLine("6 - отсортировать солдат");
            WriteLine("7 - выход\n");
            int Digit = ToInt32(ReadLine());
            WriteLine("");
            switch (Digit)
            {
                case 1:
                    foreach (var x in SList)
                    {
                        SoldierInformation(x);
                        file.WriteLine($"\n\nФамилия: {x.Value.FIO}\n");
                        file.WriteLine($"Категория годности: {x.Value.FIO}\n");
                        file.WriteLine($"Род войск: {x.Value.FIO}\n");
                        file.WriteLine($"Адрес: {x.Value.FIO}\n");
                        file.WriteLine($"Номер паспорта: {x.Value.FIO}\n");
                        file.WriteLine($"Серия паспорта: {x.Value.FIO}\n\n");

                    }
                    continue;
                case 2:
                    WriteLine("Введите номер солдата, о котором хотите узнать: ");
                    int s1 = ToInt32(ReadLine());
                    foreach (var x in SList)
                    {
                        if (s1 == x.Key)
                        {
                            WriteLine($"Фамилия: {x.Value.FIO}\n" +
                                $"Категория годности: {x.Value.ValidityCategory}\n" +
                                $"Род войск: {x.Value.MilitaryBranch}\n" +
                                $"Адрес: {x.Value.Address}\n" +
                                $"Номер паспорта: {x.Value.PassportNumber}\n" +
                                $"Серия паспорта: {x.Value.PassportSeries}");
                            file.WriteLine($"\n\nФамилия: {x.Value.FIO}\n");
                            file.WriteLine($"Категория годности: {x.Value.FIO}\n");
                            file.WriteLine($"Род войск: {x.Value.FIO}\n");
                            file.WriteLine($"Адрес: {x.Value.FIO}\n");
                            file.WriteLine($"Номер паспорта: {x.Value.FIO}\n");
                            file.WriteLine($"Серия паспорта: {x.Value.FIO}\n\n");
                        }
                    }
                    continue;
                case 3:
                    NewSoldier(SList);
                    continue;
                case 4:
                    SList.Clear();
                    continue;
                case 5:
                    WriteLine("Введите номер солдата, которого хотите удалить: ");
                    int s2 = ToInt32(ReadLine());
                    foreach (var x in SList)
                    {
                        if (s2 == x.Key)
                        {
                            SList.Remove(s2);
                        }
                    }
                    continue;
                case 6:
                    SoldiersSorting(SList, file);
                    continue;
                case 7: 
                    Environment.Exit(0);
                    break;
            }
        }
    }

    public static void NewSoldier(Dictionary<int, Soldier> SList)
    {
        while (true)
        {
            Checkings ch = new();
            try
            {
                int Number = SList.Count - 1;
                Write("Введите ФИО солдата: ");
                string FIO = ReadLine()!;
                if (!ch.FIO(FIO))
                {
                    throw new MyException("Неправильно введена фамилия!");
                }
                Write("Введите его категорию годности: ");
                char VC = ToChar(ReadLine()!);
                if (ch.ValidityCategory(VC))
                {
                    throw new MyException("Неправильно введена категория годности!");
                }
                Write($"Введите род войск: ");
                string MB = ReadLine()!;
                if (!ch.MilitaryBranch(MB))
                {
                    throw new MyException("Неправильно введен род войск!");
                }
                Write("Введите его адрес проживания: ");
                string Address = ReadLine()!;
                if (!ch.Address(Address))
                {
                    throw new MyException("Неправильно введен адрес!");
                }
                Write("Введите номер его паспорта (4 цифры): ");
                string PassportNumber = ReadLine()!;
                if (!ch.PassportNumber(PassportNumber))
                {
                    throw new MyException("Неправильно введен номер паспорта!");
                }
                Write("Введите серию его паспорта (6 цифр): ");
                string PassportSeries = ReadLine()!;
                if (!ch.PassportSeries(PassportSeries))
                {
                    throw new MyException("Неправильно введена серия паспорта!");
                }
                Soldier soldier = new Soldier(FIO, VC,
                    MB, Address, PassportNumber, PassportSeries);
                SList.Add(Number, soldier);
            }
            catch (FormatException)
            {
                WriteLine ("\nПроверьте правильность формата ввода.\n");
                continue;
            }
            catch (OverflowException)
            {
                WriteLine("\nЗначение выходит за пределы целевого типа.\n");
                continue;
            }
            catch (MyException ex)
            {
                WriteLine($"\nОшибка! {ex.Message}");
                continue;
            }
            break;
        }
    }

    public static void SoldiersSorting(Dictionary<int, Soldier> SList, StreamWriter file)
    {
        WriteLine("Выберите вид сортировки: ");
        WriteLine("1 - по ФИО (от А до Я)");
        WriteLine("2 - по номеру паспорта");
        int SortingSelect = ToInt32(ReadLine());
        switch (SortingSelect)
        {
            case 1:
                var SortedByAlphabet = SList.OrderBy(s => s.Value.FIO);
                foreach (var x in SortedByAlphabet)
                {
                    SoldierInformation(x);
                    file.WriteLine($"\n\nФамилия: {x.Value.FIO}\n");
                    file.WriteLine($"Категория годности: {x.Value.FIO}\n");
                    file.WriteLine($"Род войск: {x.Value.FIO}\n");
                    file.WriteLine($"Адрес: {x.Value.FIO}\n");
                    file.WriteLine($"Номер паспорта: {x.Value.FIO}\n");
                    file.WriteLine($"Серия паспорта: {x.Value.FIO}\n\n");
                }
                break;
            case 2: 
                var SortedByPassportNumber = SList.OrderBy(s => s.Value.PassportNumber);
                foreach (var x in SList)
                {
                    SoldierInformation(x);
                    file.WriteLine($"\n\nФамилия: {x.Value.FIO}\n");
                    file.WriteLine($"Категория годности: {x.Value.FIO}\n");
                    file.WriteLine($"Род войск: {x.Value.FIO}\n");
                    file.WriteLine($"Адрес: {x.Value.FIO}\n");
                    file.WriteLine($"Номер паспорта: {x.Value.FIO}\n");
                    file.WriteLine($"Серия паспорта: {x.Value.FIO}\n\n");
                }
                break;
        }
    }
    
}