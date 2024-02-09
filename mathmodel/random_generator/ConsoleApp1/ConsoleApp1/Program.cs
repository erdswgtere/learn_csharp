using random_generators;

internal class Program {
    static void Main(string[] args) {
        Console.Write("Выберите генератор(1, 2, 3, 4, 5): ");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a == 1) {
            Console.WriteLine("Генератор Лемера ");
            Lemer lm1 = new(4096, 2451);
            lm1.Output();
        }
        if (a == 2) {
            Console.WriteLine("Генератор смешанный");
            Combined_Generator cm1 = new(3887);
            cm1.Output();
        }
        if (a == 3) {
            Console.WriteLine("Аддитивный генератор");
            Additive_Generator ad1 = new(3971, 1013);
            ad1.Output();
        }
        if (a == 4) {
            Console.WriteLine("Обобщённый аддитивный генератор");
            Combined_Additive_Gen cad1 = new();
            cad1.Output();
        }
        if (a == 5) {
            Console.WriteLine("Обобщённый аддитивный генератор");
            Mak_Mas maks = new();
            maks.Output();
        }
        else {
            Console.WriteLine("Вы не выбрали существующий генератор");
        }
    }
}