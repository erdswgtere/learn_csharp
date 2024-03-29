namespace ConsoleApp2 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Введите количество пчёл:");
            int kol = int.Parse(Console.ReadLine()!);
            List<Bee> bees = new List<Bee>(kol);
            Console.Write("Введите кол-во испытаний: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.Write("Введите число шагов: ");
            int m = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < kol; i++) {
                Bee bee_one = new Bee(n, m);
                bees.Add(bee_one);
            }
            double L_from_all_bees = 0;
            for(int i = 0; i < kol; i++) {
                Console.WriteLine($"Среднее смещение пчелы № {i + 1} равно {bees[i].bluzd()}");
                L_from_all_bees += bees[i].bluzd();
            }
            Console.WriteLine($"Среднее смещение всего роя равно {L_from_all_bees / kol}");
        }
        struct Bee {
            int n;
            int m;
            public Bee(int n, int m) {
                this.n = n;
                this.m = m;
            }
            public double bluzd() {
                Random random = new Random();
                double L = 0;
                double P = 0;
                for (int i = 0; i < n; i++) {
                    int y;
                    int x = y = 0;
                    for (int j = 0; j < m; j++) {
                        double r = random.NextDouble();
                        if (r < 0.25) x++;
                        else if (r < 0.5) x--;
                        else if (r < 0.75) y--;
                        else y++;

                    }
                    L += Math.Sqrt(x * x + y * y);
                    P += x + y;
                }
                L /= n;
                return L;
            }
            
        }

    }
    static class RandomExtension {
        /// <summary>Возвращает случайное double число в заданном диапазоне</summary>
        /// <param name="random">Random экземпляр</param>
        /// <param name="minValue">Начало диапазона</param>
        /// <param name="maxValue">Конец диапазона</param>
        /// <returns></returns>
        static public double NextDouble(this Random random, double minValue = double.MinValue, double maxValue = double.MaxValue)
            => random.NextDouble() * (maxValue - minValue) + minValue;
    }
}
