using mystruct;
using System.Globalization;
internal class Program {
    private static void Main(string[] args) {
        Console.Write("Введите кол-во сотрудников: ");
        int n = Convert.ToInt32(Console.ReadLine());
        List<Labor> alllabor = new List<Labor>(n);
        for (int i = 0; i < n; i++) {
            Console.Write($"Введите ФИО сотрудника: ");
            string FIO = Convert.ToString(Console.ReadLine()!);
            Console.Write("Должность: ");
            string Post = Convert.ToString(Console.ReadLine()!);
            Console.Write("Введите стаж работника: ");
            int Staz = Convert.ToInt32(Console.ReadLine()!);
            Console.Write("Дата приема на работу (в формате дд/мм/гггг слитно, знак / используется как разделитель): ");
            DateTime dt1 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Labor labor1 = new Labor(FIO, Post, dt1, Staz);
            alllabor.Add(labor1);
            Console.WriteLine();
        }
        Console.WriteLine($"============");
        foreach (Labor x in alllabor) {
            x.Output();
            Console.WriteLine();
        }
        Console.WriteLine($"============");

        Console.Write("Хотите ли вы вывести инфоромацию о всех работниках?(1 или 0 на ввод): ");
        int t = Convert.ToInt32(Console.ReadLine()!);
        switch (t) {
            case 1:
                foreach (Labor x in alllabor) {
                    x.Output_ALL();
                }
                break;
            case 0:
                break;
            default:
                Console.WriteLine("Некоректный ввод");
                break;
        }
        Console.Write("Хотите ли вы вывести информацию о конкретных работниках?(1 или 0 на ввод):");
        t = Convert.ToInt32(Console.ReadLine()!);
        switch (t) {
            case 1:
                List<int> labornumbers = new List<int>(n);
                Console.Write("Введите номера работников информацию о которых вы хотете вывести(первый сотрудник под номером 0)\n" +
                              "При вводе кол-ва чисел большего чем кол-во работников будет ошибка\n" +
                              "Введите -1 если хотите закончить ввод ");
                Console.WriteLine();
                for (int i = 0; i != n; i++) {
                    Console.Write("Введите номер работника: ");
                    int d = Convert.ToInt32(Console.ReadLine()!);
                    if (d < n && d != -1) {
                        labornumbers.Add(d);
                        
                    }
                    else {
                        Console.WriteLine("Вы ввели число выходящее за кол-во работников или ввели -1 для завершения");
                        break;
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"============");
                for (int i = 0; i < labornumbers.Count; i++) {
                    alllabor[labornumbers[i]].Output_ALL();
                    Console.WriteLine();
                }
                break;
            case 0:
                Console.WriteLine("Программа завершена");
                break;
            default:
                Console.WriteLine("Некоректный ввод");
                break;
        }

    }
}