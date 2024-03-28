namespace ConsoleApp2 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Введите кол-во испытаний");
            int n = int.Parse(Console.ReadLine()!);
            Console.Write("Введите число шагов");
            int m = int.Parse(Console.ReadLine()!);
            Random random = new Random();
            double L = 0;
            for (int i = 0; i < n; i++) {
                x = у = 0;
                for (int j = 0; j < m; j++) {
                    double r = random.NextDouble();
                    if (r < 0.25) x++;
                    else if (r < 0.5) x--;
                    else if (r < 0.75) y--;
                    else y++;
                }
                L += Math.Sqrt(x * x + у * y);
            }
            L /= n;
            //...

        }
    }
}
