namespace random_generators
{
    class Lemer
    {
        const int N = 1500;
        const int A = 5;
        int Mn;
        int Y;
        public Lemer(int mn, int y)
        {
            Mn = mn;
            Y = y;
        }
        double Rnd()
        {
            Y = (A * Y) % Mn;
            return (double)Y / Mn;
        }
        readonly double[] x = new double[N];
        public void Output()
        {
            for (int i = 0; i < N; i++)
            {
                x[i] = Rnd();
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{x[i]:f3}");
            }
            Console.WriteLine();
        }
    }
    class Combined_Generator
    {
        const int N = 1500;
        const int A = 165;
        const int Mu = 3463;
        const int Mm = 4096 * 4;
        int Y;
        public Combined_Generator(int y)
        {
            Y = y;
        }
        double Rnd()
        {
            Y = (A * Y + Mu) % Mm;
            return (double)Y / Mm;
        }
        readonly double[] x = new double[N];
        public void Output()
        {
            for (int i = 0; i < N; i++)
            {
                x[i] = Rnd();
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{x[i]:f3}");
            }
            Console.WriteLine();
        }
    }
    class Additive_Generator
    {
        const int N = 1500;
        int Y0;
        int Y1;
        const int Mm = 4096 * 4;
        public Additive_Generator(int y0, int y1)
        {
            Y0 = y0;
            Y1 = y1;
        }
        double Rnd()
        {
            int y = (Y0 +  Y1) % Mm;
            Y0 = Y1;
            Y1 = y;
            return (double)y / Mm;
        }
        readonly double[] x = new double[N];
        public void Output()
        {
            for (int i = 0; i < N; i++)
            {
                x[i] = Rnd();
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{x[i]:f3}");
            }
            Console.WriteLine();
        }
    }
    class Combined_Additive_Gen
    {
        const int N = 1500;
        const int R = 6;
        public Combined_Additive_Gen()
        {

        }
        double[] Rand = new double[N];
        double Rnd()
        {
            double s = 0.0;
            for(int k = 0; k < R; k++)
            {
                s += Rand[k];
            }
            for(int k = 1; k < R; k++)
            {
                Rand[k - 1] = Rand[k];
            }
            s -= Math.Truncate(s);
            Rand[R - 1] = s;
            return s;
        }
        readonly double[] x = new double[N];
        public void Output()
        {
            Random random = new Random();
            for(int i = 0; i < R; i++)
            {
                Rand[i] = random.NextDouble();
            }
            for (int i = 0; i < N; i++)
            {
                x[i] = Rnd();
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{x[i]:f3}");
            }
            Console.WriteLine();
        }
    }
}
