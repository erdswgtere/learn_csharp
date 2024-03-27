using prr2;
namespace ConsoleApp1 {

    internal class Program {
        static void Main(string[] args) {
            while (true) {
                Console.WriteLine("СОТРУДНИК: ");
                try {
                    Sotr sotr = new Sotr();
                    Console.Write("Введите фио сотрудника: ");
                    sotr.fullname = Console.ReadLine()!;
                    Console.Write("Введите должность сотрудника: ");
                    sotr.place_in_ierachy = Console.ReadLine()!;
                    Console.Write("Введите оклад сотрудника: ");
                    sotr.oklad = int.Parse(Console.ReadLine()!);
                    Console.WriteLine($"Зарплата сотрудника равна {sotr.Raschet()}");
                    break;
                }
                catch (OkladException ex) {
                    Console.WriteLine(ex.Message);
                    continue;
                    
                }
                catch (FormatException) {
                    Console.WriteLine("Введён неверный формат");
                    continue;
                }
            }
            Console.WriteLine("ШТАТНЫЙ СОТРУДНИК: ");
            while (true) {
                try {
                    Stat_sotr stat_Sotr = new Stat_sotr();
                    Console.Write("Введите фио сотрудника: ");
                    stat_Sotr.fullname = Console.ReadLine()!;
                    Console.Write("Введите должность сотрудника: ");
                    stat_Sotr.place_in_ierachy = Console.ReadLine()!;
                    Console.Write("Введите оклад сотрудника: ");
                    stat_Sotr.oklad = int.Parse(Console.ReadLine()!);
                    Console.Write("Введите премию сотрудника: ");
                    stat_Sotr.prem = int.Parse(Console.ReadLine()!);
                    Console.WriteLine($"Зарплата сотрудника равна {stat_Sotr.Raschet()}");
                    break;
                }
                catch (OkladException ex) {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                catch (PremiyaException ex) {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                catch (FormatException) {
                    Console.WriteLine("Введён неверный формат");
                    continue;
                }
            }
        }
    }
}
