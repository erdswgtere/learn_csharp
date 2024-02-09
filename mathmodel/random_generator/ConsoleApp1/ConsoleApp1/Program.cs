/*****************************************************
******************************************************
**                                                  **
**  Программа с реализацией генераторов случайных   **
**   чисел(генератор Лемера, генератор смешанный,   **
**   адитивный генератор, обобщённый аддитивный     **
**   генератор, генератор Макларена)                **
**                                                  ** 
**  Выполнил: студент 2 курса ЕПК гр. И-22          **
**  Синицын Максим                                  ** 
**  Проверил: преподаватель (прог. мод.) Фомин А. Т.**
**                                                  **
******************************************************
*****************************************************/
using random_generators;

internal class Program {
    static void Main(string[] args) {
        Console.Write("Выберите генератор(1, 2, 3, 4, 5): ");
        int a = Convert.ToInt32(Console.ReadLine());
        switch (a) {
            case 1:
                Console.WriteLine("Генератор Лемера ");
                Lemer lm1 = new(4096, 2451);
                lm1.Output();
                break;
            case 2:
                Console.WriteLine("Генератор смешанный");
                Combined_Generator cm1 = new(3887);
                cm1.Output();
                break;
            case 3:
                Console.WriteLine("Аддитивный генератор");
                Additive_Generator ad1 = new(3971, 1013);
                ad1.Output();
                break;
            case 4:
                Console.WriteLine("Обобщённый аддитивный генератор");
                Combined_Additive_Gen cad1 = new();
                cad1.Output();
                break;
            case 5:
                Console.WriteLine("Генератор Макларена");
                Mak_Mas maks = new();
                maks.Output();
                break;
            default:
                Console.WriteLine("Вы не выбрали генератор");
                break;
        }
    }
}