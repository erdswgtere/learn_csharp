namespace random_generators {
    public class Lemer {
        const int N = 1500;
        const int A = 5;
        int Mn;
        int Y;
        public Lemer(int mn, int y) {
            Mn = mn;
            Y = y;
        }
        public double Rnd() {
            Y = (A * Y) % Mn;
            return (double)Y / Mn;
        }
        readonly double[] x = new double[N];
        public void Output() {
            for (int i = 0; i < N; i++) {
                x[i] = Rnd();
            }
            for (int i = 0; i < 10; i++) {
                Console.WriteLine($"{x[i]:f3}");
            }
            Console.WriteLine();
        }
    }
    public class Combined_Generator {
        const int N = 1500;
        const int A = 165;
        const int Mu = 3463;
        const int Mm = 4096 * 4;
        int Y;
        public Combined_Generator(int y) {
            Y = y;
        }
        public double Rnd() {
            Y = (A * Y + Mu) % Mm;
            return (double)Y / Mm;
        }
        double[] x = new double[N];
        public void Output() {
            for (int i = 0; i < N; i++) {
                x[i] = Rnd();
            }

            Console.WriteLine();
        }
    }
    public class Additive_Generator {
        const int N = 1500;
        int Y0;
        int Y1;
        const int Mm = 4096 * 4;
        public Additive_Generator(int y0, int y1) {
            Y0 = y0;
            Y1 = y1;
        }
        public double Rnd() {
            int y = (Y0 + Y1) % Mm;
            Y0 = Y1;
            Y1 = y;
            return (double)y / Mm;
        }
        readonly double[] x = new double[N];
        public void Output() {
            for (int i = 0; i < N; i++) {
                x[i] = Rnd();
            }
            for (int i = 0; i < 10; i++) {
                Console.WriteLine($"{x[i]:f3}");
            }
            Console.WriteLine();
        }
    }
    public class Combined_Additive_Gen {
        const int N = 1500;
        const int R = 6;
        public Combined_Additive_Gen() {

        }
        double[] Rand = new double[N];
        public double Rnd() {
            double s = 0.0;
            for (int k = 0; k < R; k++) {
                s += Rand[k];
            }
            for (int k = 1; k < R; k++) {
                Rand[k - 1] = Rand[k];
            }
            s -= Math.Truncate(s);
            Rand[R - 1] = s;
            return s;
        }
        readonly double[] x = new double[N];
        public void Output() {
            Random random = new Random();
            for (int i = 0; i < R; i++) {
                Rand[i] = random.NextDouble();
            }
            for (int i = 0; i < N; i++) {
                x[i] = Rnd();
            }
            for (int i = 0; i < 10; i++) {
                Console.WriteLine($"{x[i]:f3}");
            }
            Console.WriteLine();
        }
    }
    /* class Combination_of_gen
     {
         const int N = 1500;
         const int R = 6;
         public Combination_of_gen()
         {

         }
         double Rnd()
         {
             double s = 0.0;
             double[] x = new int[K];
             int[] yN = new int[K];

         }
     }*/
    public class Mak_Mas {
        const int N_MAX = 4000;
        const int K = 64;
        public Mak_Mas() {

        }
        static double[] Z1 = new double[K];
        static Random _Random = new Random();
        public double Rnd() {
            double g1 = _Random.NextDouble();
            double g2 = _Random.NextDouble();
            int m = (int)(g2 * K);
            double res = Z1[m];
            Z1[m] = g1;
            return res;
        }
        public void Output() {
            Random random = new Random();
            for (int i = 0; i < K; i++) {
                Z1[i] = random.NextDouble();
            }
            double x;
            for (int i = 0; i < 20; i++) {
                x = Rnd();
                Console.Write($"{x,6:f3}");
            }
            Console.WriteLine();
        }
    }
    public class Normal_gen {
        int N;
        public Normal_gen(int _N) {
            N = _N;
        }
        public double Approximate() {
            Random random = new Random();
            double r, x;
            double k = Math.Sqrt(8.0 / Math.PI);
            for (int i = 0; i < N; i++) {
                r = random.NextDouble(); 
                x = Math.Log((1 + r) / (1 - r)) / k;
                r = random.NextDouble();
                if (r < 0.5) x = -x;
                return x;
            }
            return 0.0;
        }
        public void Normal_for_test() {
            Console.Write("Математическое ожидание m: ");
            double m = double.Parse(Console.ReadLine());
            Console.Write("Дисперсия d: ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Количество случайных величин n: ");
            int n = int.Parse(Console.ReadLine());
            Random random = new Random();
            double s, r;
            for (int i = 0; i < n; i++) {
                s = 0;
                for (int j = 0; j < 12; j++) {
                    r = random.NextDouble();
                    s += r;
                }
                double x = s - 6;
                x = m + x * Math.Sqrt(d);
                Console.WriteLine("x[{0}] = {1:f3}", i + 1, x);
            }
            Console.WriteLine("Моделирование завершено");
            Console.ReadLine();
        }
        public double Normal(double M, double D) {
            Random random = new Random();
            double s, r;
            for (int i = 0; i < N; i++) {
                s = 0;
                for (int j = 0; j < 12; j++) {
                    r = random.NextDouble();
                    s += r;
                }
                double x = s - 6;
                x = M + x * Math.Sqrt(D);
                return x;
            }
            return 0.0;
        }
        public void Mak_bod() {
            Console.WriteLine("Параметры первого распределения");
            Console.Write("математическое ожидание m1: ");
            double m1 = double.Parse(Console.ReadLine());
            Console.Write("дисперсия d1: ");
            double d1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Параметры второго  распределения");
            Console.Write("математическое ожидание m2: ");
            double m2 = double.Parse(Console.ReadLine());
            Console.Write("дисперсия d2: ");
            double d2 = double.Parse(Console.ReadLine());
            Console.Write("Количество случайных величин n: ");
            int n = int.Parse(Console.ReadLine());
            Random random = new Random();
            double r1, r2, x, y;
            for (int i = 0; i < n; i++) {
                r1 = random.NextDouble();
                r2 = random.NextDouble();
                x = Math.Sqrt(-2 * Math.Log(r1)) *
                Math.Cos(2 * Math.PI * r2);
                x = m1 + x * Math.Sqrt(d1);
                y = Math.Sqrt(-2 * Math.Log(r1)) *
                Math.Sin(2 * Math.PI * r2);
                y = m2 + y * Math.Sqrt(d2);
                Console.WriteLine("x[{0}] = {1:f3} y[{0}] = { 2:f3} ", i + 1, x, y);
            }

        }
        public double mars_mar(double M, double D) {
            double m1 = M;
            double d1 = D;
            double m2 = M;
            double d2 = D;
            Random random = new Random();
            double r1, r2, u1, u2, s, x, y;
            int i = 0;
            while (i < N) {
                r1 = random.NextDouble();
                r2 = random.NextDouble();
                u1 = -1 + 2 * r1; u2 = -1 + 2 * r2;
                s = u1 * u1 + u2 * u2;
                if (s <= 1) {
                    x = u1 * Math.Sqrt(-2 * Math.Log(s) / s);
                    y = u2 * Math.Sqrt(-2 * Math.Log(s) / s);
                    x = m1 + x * Math.Sqrt(d1);
                    y = m2 + y * Math.Sqrt(d2);
                    return x;
                    i++;
                }
            }
            return 0.0;

        }
    }
}




