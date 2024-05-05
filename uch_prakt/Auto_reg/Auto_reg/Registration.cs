using System.Security;
class Registration {
    public static void Info() {
        while (true) {
            Console.Write("Введите путь файла для сохранения информации: ");
            string path = Console.ReadLine()!;
            if (File.Exists(path)) {
                Console.Write("Этот путь уже занят другим файлом!");
                continue;
            }
            StreamWriter sw_clwr = File.CreateText(path);
            Console.Write("Введите количество клиентов для регистрации: ");
            int n = int.Parse(Console.ReadLine()!);
            if (n < 1) {
                Console.Write("Некорректное количество клиентов!\n");
                continue;
            }
            Dictionary<int, Client> ClientDic = new(n);
            try {
                for (int i = 0; i < n; i++) {
                    int Number = i + 1;
                    Console.Write($"\nКлиент {Number}: \n");
                    Console.Write("Введите ФИО клиента: ");
                    string FIO = Console.ReadLine()!;

                    Console.Write("Введите его адрес проживания: ");
                    string Address = Console.ReadLine()!;

                    Console.Write("Введите номер его паспорта (4 цифры): ");
                    string PassportNumber = Console.ReadLine()!;

                    Console.Write("Введите серию его паспорта (6 цифр): ");
                    string PassportSeries = Console.ReadLine()!;

                    Console.Write("Введите номер комнаты для заселения");
                    int number_of_room = int.Parse(Console.ReadLine()!);

                    Console.Write("Одобряете ли вы его заселение?");
                    int Approved_or_ont = int.Parse(Console.ReadLine()!);   

                    Client newclient = new(FIO,Address, PassportNumber, PassportSeries, number_of_room);
                    newclient.Room_has_given = ApprovedRoom(Approved_or_ont); 
                    ClientDic.Add(Number, newclient);
                    sw_clwr.WriteLine($"Номер клиента {Number}:\n");
                    sw_clwr.WriteLine($"ФИО: {FIO}\n");
                    sw_clwr.WriteLine($"Адрес проживания: {Address}\n");
                    sw_clwr.WriteLine($"Номер паспорта: {PassportNumber}\n");
                    sw_clwr.WriteLine($"Серия паспорта: {PassportSeries}\n"); 
                }
                foreach (var x in ClientDic) {
                    Selection(ClientDic, sw_clwr);
                    break;
                }
            }
            catch (FileNotFoundException) {
                Console.WriteLine("Файл не найден");
            }
            catch (DirectoryNotFoundException) {
                Console.WriteLine("Директория не найдена");
            }
            catch (DriveNotFoundException) {
                Console.WriteLine("Вы указали несуществующий диск");
            }
            catch (PathTooLongException) {
                Console.WriteLine("Слишком длинное имя файла/пути");
            }
            catch (SecurityException) {
                Console.WriteLine("Ошибка безопасности");
            }
            catch (NotSupportedException) {
                Console.WriteLine("Путь имеет недопустимый формат");
            }
            catch (FormatException) {
                Console.Write("Проверьте правильность формата ввода.");
                continue;
            }
            catch (OverflowException) {
                Console.Write("Значение выходит за пределы целевого типа.");
                continue;
            }
            catch (RegException ex) {
                Console.WriteLine($"Ошибка! {ex.Message}");
                continue;
            }
            finally {
                if (sw_clwr != null)
                    sw_clwr.Close();
            }
            break;

        }

    }
    public static bool ApprovedRoom(int num) {
        while(true) {
            if (num == 1) {
                return true;
                
            }
            else if (num == 2) {
                return false;
            }
            else {
                Console.WriteLine("Вы ввели некорректное значение введите 0 или 1 чтобы показать состаяние одобрение или отказа в выдаче команты");
            }
        }
    }
    public static void ClientInformation(KeyValuePair<int, Client> ClientDic) {
        Console.WriteLine($"ФИО: {ClientDic.Value.FIO}\n" +
            $"Адрес проживания: {ClientDic.Value.Address}" +
            $"\nНомер паспорта: {ClientDic.Value.PassportNumber}\n" +
            $"Серия паспорта: {ClientDic.Value.PassportSeries}\n" +
            $"Номер комнаты: {ClientDic.Value.Number_of_room}");
    }

    public static void Selection(Dictionary<int, Client> ClientDic, StreamWriter file) {
        while (true) {
            Console.WriteLine("\nВыберите действие: \n");
            Console.WriteLine("1 - вывод информации о всех клиентах гостиницы");
            Console.WriteLine("2 - вывод информации о конкретном клиенте гостиницы");
            Console.WriteLine("3 - внести информацию о клиенте");
            Console.WriteLine("4 - удалить информацию о всех клиентах");
            Console.WriteLine("5 - удалить конкретного клиента");
            Console.WriteLine("6 - отсортировать клиентов");
            Console.WriteLine("7 - выход\n");
            int Digit = int.Parse(Console.ReadLine()!);
            Console.WriteLine("");
            switch (Digit) {
                case 1:
                    foreach (var x in ClientDic) {
                        ClientInformation(x);
                        file.WriteLine($"\n\nФИО: {x.Value.FIO}\n");
                        file.WriteLine($"Номер комнаты: {x.Value.Number_of_room}\n");
                        file.WriteLine($"Одоберна ли выдача комнаты: {x.Value.Room_has_given}\n");
                        file.WriteLine($"Адрес: {x.Value.Address}\n");
                        file.WriteLine($"Номер паспорта: {x.Value.PassportNumber}\n");
                        file.WriteLine($"Серия паспорта: {x.Value.PassportSeries}\n\n");

                    }
                    continue;
                case 2:
                    Console.WriteLine("Введите номер клиента, о котором хотите узнать: ");
                    int s1 = int.Parse(Console.ReadLine()!);
                    foreach (var x in ClientDic) {
                        if (s1 == x.Key) {
                            Console.WriteLine($"ФИО: {x.Value.FIO}\n" +
                                $"Номер выделенной комнаты если есть: {x.Value.Number_of_room}\n" +
                                $"Одобрена ли выдача комнты?: {x.Value.Room_has_given}\n" +
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
                    NewClient(ClientDic);
                    continue;
                case 4:
                    ClientDic.Clear();
                    continue;
                case 5:
                    Console.WriteLine("Введите номер солдата, которого хотите удалить: ");
                    int s2 = int.Parse(Console.ReadLine()!);
                    foreach (var x in ClientDic) {
                        if (s2 == x.Key) {
                            ClientDic.Remove(s2);
                        }
                    }
                    continue;
                case 6:
                    ClientsSorting(ClientDic, file);
                    continue;
                case 7:
                    Environment.Exit(0);
                    break;
            }
        }
    }

    public static void NewClient(Dictionary<int, Client> ClientDic) {
        while (true) {
            Checkings ch = new();
            try {
                int Number = ClientDic.Count - 1;

                Console.Write("Введите ФИО клиента: ");
                string FIO = Console.ReadLine()!;
                if (!ch.FIO(FIO)) {
                    throw new RegException("Неправильно введена фамилия!");
                }

                Console.Write("Введите его адрес проживания: ");
                string Address = Console.ReadLine()!;
                if (!ch.Address(Address)) {
                    throw new RegException("Неправильно введен адрес!");
                }

                Console.Write("Введите номер его паспорта (4 цифры): ");
                string PassportNumber = Console.ReadLine()!;
                if (!ch.PassportNumber(PassportNumber)) {
                    throw new RegException("Неправильно введен номер паспорта!");
                }

                Console.Write("Введите серию его паспорта (6 цифр): ");
                string PassportSeries = Console.ReadLine()!;
                if (!ch.PassportSeries(PassportSeries)) {
                    throw new RegException("Неправильно введена серия паспорта!");
                }

                Console.Write("Введите номер комнаты для заселения");
                int number_of_room = int.Parse(Console.ReadLine()!);

                Console.Write("Одобряете ли вы его заселение?");
                int Approved_or_ont = int.Parse(Console.ReadLine()!);

                Client newclient = new(FIO, Address, PassportNumber, PassportSeries, number_of_room);
                newclient.Room_has_given = ApprovedRoom(Approved_or_ont);
                ClientDic.Add(Number, newclient);
            }
            catch (FormatException) {
                Console.WriteLine("\nПроверьте правильность формата ввода.\n");
                continue;
            }
            catch (OverflowException) {
                Console.WriteLine("\nЗначение выходит за пределы целевого типа.\n");
                continue;
            }
            catch (RegException ex) {
                Console.WriteLine($"\nОшибка! {ex.Message}");
                continue;
            }
            break;
        }
    }

    public static void ClientsSorting(Dictionary<int, Client> ClientDic, StreamWriter file) {
        Console.WriteLine("Выберите вид сортировки: ");
        Console.WriteLine("1 - по ФИО (от А до Я)");
        Console.WriteLine("2 - по номеру паспорта");
        int SortingSelect = int.Parse(Console.ReadLine()!);
        switch (SortingSelect) {
            case 1:
                var SortedByAlphabet = ClientDic.OrderBy(s => s.Value.FIO);
                foreach (var x in SortedByAlphabet) {
                    ClientInformation(x);
                    file.WriteLine($"\n\nФамилия: {x.Value.FIO}\n");
                    file.WriteLine($"Адрес: {x.Value.Address}\n");
                    file.WriteLine($"Номер паспорта: {x.Value.PassportNumber}\n");
                    file.WriteLine($"Серия паспорта: {x.Value.PassportSeries}\n\n");
                }
                break;
            case 2:
                var SortedByPassportNumber = ClientDic.OrderBy(s => s.Value.PassportNumber);
                foreach (var x in ClientDic) {
                    ClientInformation(x);
                    file.WriteLine($"\n\nФамилия: {x.Value.FIO}\n");
                    file.WriteLine($"Адрес: {x.Value.Address}\n");
                    file.WriteLine($"Номер паспорта: {x.Value.PassportNumber}\n");
                    file.WriteLine($"Серия паспорта: {x.Value.PassportSeries}\n\n");
                }
                break;
        }
    }
}

