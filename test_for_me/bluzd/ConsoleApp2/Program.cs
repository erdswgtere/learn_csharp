namespace ConsoleApp2 {
    internal class Program {
        static void Main(string[] args) {
            Random random = new Random(); 

            while (true) {
                double x1 = 0.0;
                double x2 = 0.0;
                double L;
                double D;
                Console.Write("Введите кол-во испытаний: ");
                int n = int.Parse(Console.ReadLine()!);
                Console.Write("Введите число шагов: ");
                int m = int.Parse(Console.ReadLine()!);
                Console.Write("Введите вероятность шага вправо (число не больше 1!): ");
                double pRight = double.Parse(Console.ReadLine()!);
                Console.Write("Введите вероятность смены направления влево (число не больше 1!): ");
                double pLeft = double.Parse(Console.ReadLine()!);
                for (int i = 0; i < n; i++) {
                    double x = 0.0;
                    Console.Write("Испытание " + (i + 1) + ": ");
                    for (int j = 0; j < m; j++) {
                        double r = random.NextDouble();
                        double stepLength = GenerateStepLength();
                        if (r < pRight) {
                            x += stepLength;
                            Console.Write($">> {stepLength:f5} ");
                        }
                        else if (r < pRight + pLeft) {
                            x -= stepLength;
                            Console.Write($"<< {stepLength:f5} ");
                        }
                        else {
                            Console.Write("0 ");
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Смещение для испытания " + (i + 1) + ": " + x); // Вывод смещения для каждого испытания
                    x1 += Math.Abs(x);
                    x2 += x * x;
                    Console.WriteLine();
                }
                L = x1 / n;
                D = x2 / n - L * L;
                Console.WriteLine("Среднее смещение точки от начала координат: " + L);
                Console.WriteLine("Дисперсия: " + D);
                Console.Write("Хотите продолжить испытания? (0 - выход, 1 - рестарт): ");
                int tr = int.Parse(Console.ReadLine()!);
                switch (tr) {
                    case 0:
                        Console.WriteLine("Выход из программы");
                        return;
                    case 1:
                        Console.WriteLine("Рестарт");
                        break;
                    default:
                        Console.WriteLine("Введите либо 0 либо 1");
                        break;
                }
            }
        }

        static double GenerateStepLength() {
            Random rand = new Random();
            double u = rand.NextDouble();
            double j = -Math.Log(u); // Длина шага согласно распределению P(j) = exp(-j)
            return j;
        }
    }
}
