using System;

namespace Generators
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
    class Approximation
    {
        public static double GenerateProbability()
        {
            double x;
            double minValue = 1;
            double maxValue = 10;
            double r;
            var rnd = new Random();
            double k = Math.Sqrt(8.0 / Math.PI);
            r = rnd.NextDouble();
            x = Math.Log((1 + r) / (1 - r) / k);
            x = minValue + r * (maxValue - minValue);
            return Math.Floor(x);
        }
        public static double GenerateController()
        {
            double x;
            double minValue = 1;
            double maxValue = 3;
            double r;
            var rnd = new Random();
            double k = Math.Sqrt(8.0 / Math.PI);
            r = rnd.NextDouble();
            x = Math.Log((1 + r) / (1 - r) / k);
            x = minValue + r * (maxValue - minValue);
            return Math.Floor(x);
        }

    }
    class CombinedGenerator
    {
        const int N = 1500;
        const int A = 165;
        const int Mu = 3463;
        const int Mm = 4096 * 4;
        int Y;
        public CombinedGenerator(int y)
        {
            Y = y;
        }
        double Rnd()
        {
            Y = (A * Y + Mu) % Mm;
            return (double)Y / Mm;
        }
        double[] x = new double[N];
        public void Output()
        {
            for (int i = 0; i < N; i++)
            {
                x[i] = Rnd();
            }

            Console.WriteLine();
        }
    }
    class AdditiveGenerator
    {
        const int N = 1500;
        int Y0;
        int Y1;
        const int Mm = 4096 * 4;
        public AdditiveGenerator(int y0, int y1)
        {
            Y0 = y0;
            Y1 = y1;
        }
        public int Rnd()
        {
            int y = (Y0 + Y1) % Mm;
            Y0 = Y1;
            Y1 = y;
            return y / Mm;
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
    class CombinedAdditiveGen
    {
        const int N = 1500;
        const int R = 6;
        public CombinedAdditiveGen()
        {

        }
        double[] Rand = new double[N];
        double Rnd()
        {
            double s = 0.0;
            for (int k = 0; k < R; k++)
            {
                s += Rand[k];
            }
            for (int k = 1; k < R; k++)
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
            for (int i = 0; i < R; i++)
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


