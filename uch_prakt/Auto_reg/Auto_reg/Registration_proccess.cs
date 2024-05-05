using System.Security;
namespace Registration_proccess {
    class Registration : IAllRegistrarion {
        public static void AllInfo() {
            StreamWriter swmain = null!;
            string path;
            while (true) {
                try {
                    Console.Write("Введите путь файла для сохранения информации: ");
                    path = Console.ReadLine()!;
                    swmain = File.CreateText(path);

                    Console.WriteLine("Проведите первую регистрацию:");
                    Console.Write("Введите количество клиентов для регистрации: ");
                    int n = int.Parse(Console.ReadLine()!);
                    if (n < 1) {
                        Console.Write("Некорректное количество клиентов!\n");
                        continue;
                    }
                    Dictionary<int, Client> ClientDic = new(n);
                    for (int i = 0; i < n; i++) {
                        int Number = i + 1;
                        Console.Write($"\nКлиент {Number}: \n");
                        Console.Write("Введите ФИО клиента: ");
                        string FIO = Console.ReadLine()!;
                        Checkings.FIOCheck(FIO);

                        Console.Write("Введите его адрес проживания: ");
                        string Address = Console.ReadLine()!;
                        Checkings.AddressCheck(Address);

                        Console.Write("Введите серию его паспорта (4 цифры): ");
                        string PassportSeries = Console.ReadLine()!;
                        Checkings.PassportSeriesCheck(PassportSeries);

                        Console.Write("Введите номер его паспорта (6 цифр): ");
                        string PassportNumber = Console.ReadLine()!;
                        Checkings.PassportNumberCheck(PassportNumber);

                        bool Approved_or_ont;
                        RegUtils.ApprovedRoom(out Approved_or_ont);

                        int number_of_room;
                        RegUtils.GiveNumOfRoom(Approved_or_ont, out number_of_room);
                        Checkings.NumroomCheck(number_of_room);

                        Client newclient = new(FIO, Address, PassportNumber, PassportSeries, number_of_room);
                        newclient.Room_has_given = Approved_or_ont;
                        ClientDic.Add(Number, newclient);
                        Console.WriteLine();
                        swmain.WriteLine($"Номер клиента {Number}:");
                        swmain.WriteLine($"ФИО клиента: {FIO}");
                        swmain.WriteLine($"Адрес проживания: {Address}");
                        swmain.WriteLine($"Номер паспорта: {PassportNumber}");
                        swmain.WriteLine($"Серия паспорта: {PassportSeries}");
                        swmain.WriteLine($"Одобрена ли выдача номера: {Approved_or_ont}");
                        swmain.WriteLine();
                    }
                    Selection(ClientDic, swmain);
                    break;
                }
                catch (IOException) {
                    Console.WriteLine("Некорректный ввод пути");
                }
                catch (UnauthorizedAccessException) {
                    Console.WriteLine("Не удаётся получить доступ к файлу");
                }
                catch (SecurityException) {
                    Console.WriteLine("Ошибка безопасности");
                }
                catch (NotSupportedException) {
                    Console.WriteLine("Путь имеет недопустимый формат");
                }
                catch (FormatException) {
                    Console.WriteLine("Проверьте правильность формата ввода.");
                    continue;
                }
                catch (OverflowException) {
                    Console.WriteLine("Значение выходит за пределы целевого типа.");
                    continue;
                }
                catch (RegException ex) {
                    Console.WriteLine($"Ошибка! {ex.Message}");
                    continue;
                }
                finally {
                    swmain?.Close();
                }
            }

        }
        public static void Selection(Dictionary<int, Client> ClientDic, StreamWriter SwMain) {
            RegUtils.SwMain = SwMain;
            while (true) {
                Console.WriteLine("\nВыберите действие: \n");
                Console.WriteLine("1 - вывод информации о всех клиентах гостиницы");
                Console.WriteLine("2 - вывод информации о конкретном клиенте гостиницы");
                Console.WriteLine("3 - внести информацию о клиенте");
                Console.WriteLine("4 - удалить информацию о всех клиентах");
                Console.WriteLine("5 - удалить конкретного клиента");
                Console.WriteLine("6 - отсортировать клиентов");
                Console.WriteLine("7 - выход\n");
                Console.Write("Поле ввода: ");
                int Digit = int.Parse(Console.ReadLine()!);
                Console.WriteLine("");
                switch (Digit) {
                    case 1:
                        foreach (var x in ClientDic) {
                            RegUtils.ClientInformation(x);
                            Console.WriteLine();
                        }
                        continue;
                    case 2:
                        RegUtils.OneClientInf(ClientDic);
                        continue;
                    case 3:
                        RegUtils.NewClient(ClientDic);
                        continue;
                    case 4:
                        ClientDic.Clear();
                        continue;
                    case 5:
                        RegUtils.RemoveClient(ClientDic);
                        continue;
                    case 6:
                        RegUtils.ClientsSorting(ClientDic);
                        continue;
                    case 7:
                        Console.WriteLine("Хорошего дня!:)");
                        break;
                }
                if (Digit == 7) {
                    break;
                }
            }
        }
    }
}

