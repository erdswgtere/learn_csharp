namespace Health_and_Medicine;

internal class Program {
    private static void Main(string[] args) {
        Console.WriteLine("ПРОГРАММА УЧЁТА ЛЕКАРСТВ В СЕТИ АПТЕК");
        Console.Write("Введите кол-во аптек: ");
        int n = int.Parse(Console.ReadLine()!);
        Dictionary<string, List<Health.Medicine>> Health_Base = new Dictionary<string, List<Health.Medicine>>(n);
        Health hlt = new Health(Health_Base);
        hlt.input_in_base(ref n);
        while (true) {
            Console.WriteLine();
            Console.WriteLine("Выберите вариант:");
            Console.WriteLine("1. Добавить запись в базу");
            Console.WriteLine("2. Удалить запись");
            Console.WriteLine("3. Редактировать запись");
            Console.WriteLine("4. Поиск информации по аптеке");
            Console.WriteLine("5. Вывести все записи");
            Console.WriteLine("6. Выход");

            int choice = int.Parse(Console.ReadLine()!);
            switch (choice) {
                case 1:
                    Console.Write("Введите кол-во аптек: ");
                    int m = int.Parse(Console.ReadLine()!);
                    hlt.input_in_base(ref m);
                    break;
                case 2:
                    hlt.RemoveAptek();
                    break;
                case 3:
                    hlt.EditAptek();
                    break;
                case 4:
                    hlt.output_from_base();
                    break;
                case 5:
                    hlt.PrintAll();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Вариант не выбран или введено некорректное значение");
                    break;
            }
        }
    }
}