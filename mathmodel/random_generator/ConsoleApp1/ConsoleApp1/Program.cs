using random_generator;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Выберите генератор :");
        int a = Convert.ToInt32(Console.ReadLine());
        if(a == 0)
        {
            Lemer lm1 = new(4096, 2451);
            lm1.Output();
        }
    }
}