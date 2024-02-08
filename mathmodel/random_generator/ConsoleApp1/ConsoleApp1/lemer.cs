namespace random_generator
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
        int Y = 3887;
        public Combined_Generator()
        {

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
}
