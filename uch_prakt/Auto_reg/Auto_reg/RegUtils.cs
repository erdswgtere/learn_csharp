class RegUtils {
    static StreamWriter Swclassmain;
    public static StreamWriter SwMain {
        get => Swclassmain;
        set => Swclassmain = value;
    }
    public static void GiveNumOfRoom(bool Approved_or_ont, out int number_of_room) {
        if (Approved_or_ont) {
            Console.Write("Введите номер комнаты для заселения: ");
            number_of_room = int.Parse(Console.ReadLine()!);
        }
        else {
            number_of_room = 0;
        }
    }
    public static void ApprovedRoom(out bool Approved_or_ont) {
        while (true) {
            Console.Write("Одобряете ли вы его заселение?(Введите 0 или 1): ");
            int num = int.Parse(Console.ReadLine()!);
            if (num == 1) {
                Approved_or_ont = true;
                break;
            }
            else if (num == 0) {
                Approved_or_ont = false;
                break;
            }
            else {
                Console.WriteLine("Введите 0 или 1 для одобрения либо отказа в выдаче комнаты!");
                continue;
            }
        }
    }
    public static void ClientInformation(KeyValuePair<int, Client> ClientDic) {
        Console.WriteLine($"ФИО: {ClientDic.Value.FIO}\n" +
            $"Адрес проживания: {ClientDic.Value.Address}" +
            $"\nНомер паспорта: {ClientDic.Value.PassportNumber}\n" +
            $"Серия паспорта: {ClientDic.Value.PassportSeries}\n" +
            $"Заявка одобрена: {ClientDic.Value.Room_has_given}\n" +
            $"Номер комнаты: {ClientDic.Value.Number_of_room}");
    }
    public static void OneClientInf(Dictionary<int, Client> ClientDic) {
        Console.Write("Введите номер клиента, о котором хотите узнать: ");
        int s1 = int.Parse(Console.ReadLine()!);
        foreach (var x in ClientDic) {
            if (s1 == x.Key) {
                Console.WriteLine($"ФИО: {x.Value.FIO}\n" +
                    $"Адрес проживания: {x.Value.Address}" +
                    $"\nНомер паспорта: {x.Value.PassportNumber}\n" +
                    $"Серия паспорта: {x.Value.PassportSeries}\n" +
                    $"Заявка одобрена: {x.Value.Room_has_given}\n" +
                    $"Номер комнаты: {x.Value.Number_of_room}");
            }
        }
    }
    public static void RemoveClient(Dictionary<int, Client> ClientDic) {
        Console.Write("Введите номер клиента, которого хотите удалить: ");
        int s2 = int.Parse(Console.ReadLine()!);
        foreach (var x in ClientDic) {
            if (s2 == x.Key) {
                ClientDic.Remove(s2);
            }
        }
    }
    public static void NewClient(Dictionary<int, Client> ClientDic) {
        while (true) {
            try {
                int Number = ClientDic.Count + 1;

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
                ApprovedRoom(out Approved_or_ont);

                int number_of_room;
                GiveNumOfRoom(Approved_or_ont, out number_of_room);
                Checkings.NumroomCheck(number_of_room);

                Client newclient = new(FIO, Address, PassportNumber, PassportSeries, number_of_room);
                newclient.Room_has_given = Approved_or_ont;
                ClientDic.Add(Number, newclient);
                Swclassmain.WriteLine($"Номер клиента {Number}:");
                Swclassmain.WriteLine($"ФИО клиента: {FIO}");
                Swclassmain.WriteLine($"Адрес проживания: {Address}");
                Swclassmain.WriteLine($"Номер паспорта: {PassportNumber}");
                Swclassmain.WriteLine($"Серия паспорта: {PassportSeries}");
                Swclassmain.WriteLine($"Одобрена ли выдача номера: {Approved_or_ont}");
                Swclassmain.WriteLine();
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

    public static void ClientsSorting(Dictionary<int, Client> ClientDic) {
        Console.WriteLine("Выберите вид сортировки: ");
        Console.WriteLine("1 - по ФИО (от А до Я)");
        Console.WriteLine("2 - по номеру паспорта");
        Console.Write("Поле ввода: ");
        int SortingSelect = int.Parse(Console.ReadLine()!);
        switch (SortingSelect) {
            case 1:
                var SortedByAlphabet = ClientDic.OrderBy(s => s.Value.FIO);
                foreach (var x in SortedByAlphabet) {
                    ClientInformation(x);
                    Console.WriteLine();
                }
                break;
            case 2:
                var SortedByPassportNumber = ClientDic.OrderBy(s => s.Value.PassportNumber);
                foreach (var x in SortedByPassportNumber) {
                    ClientInformation(x);
                    Console.WriteLine();
                }
                break;
        }
    }
}
