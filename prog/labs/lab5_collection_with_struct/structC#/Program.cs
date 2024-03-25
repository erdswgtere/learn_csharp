namespace Health_and_Medicine;

internal class Program {
    private static void Main(string[] args) {
        Console.WriteLine("ПРОГРАММА УЧЁТА ЛЕКАРСТВА В СЕТИ АПТЕК");
        Console.Write("Введите кол-во аптек: ");
        int n = int.Parse(Console.ReadLine()!);
        Dictionary<string, List<Health.Medicine>> Health_Base = new Dictionary<string, List<Health.Medicine>>(n);
        Health hlt = new Health(Health_Base, n);
        while (true) {
            Console.WriteLine();
            Console.WriteLine("Выберите вариант:");
            Console.WriteLine("1. Добавить запись");
            Console.WriteLine("2. Удалить запись");
            Console.WriteLine("3. Редактировать запись");
            Console.WriteLine("4. Поиск информации");
            Console.WriteLine("5. Вывести все записи");
            Console.WriteLine("6. Выход");

            int choice = int.Parse(Console.ReadLine()!);
            if (choice >= 1 && choice <= 6) {
                switch (choice) {
                    case 1:
                        hlt.input_in_base();
                        break;
                    case 2:
                        RemoveFurniture();
                        break;
                    case 3:
                        EditFurniture();
                        break;
                    case 4:
                        hlt.output_from_base();
                        break;
                    case 5:
                        PrintAllFurniture();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                }
            }
            else {
                Console.WriteLine("Вариант не выбран или введено некорректное значение");
            }
        }
    }
}