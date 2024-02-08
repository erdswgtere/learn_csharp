namespace random_generator
{
    class Lemer
    {
        const int N = 1500;
        const int A = 5;
        int Mn;
        int Y;
        Lemer(int mn, int y)
        {
            Mn = mn;
            Y = y;
        }
        double Rnd() {
            Y = (A * Y) % Mn;
            return (double)Y / Mn;
        }
        double[] x = new double[N];
        void output( int NN,)
        {

        }
    }
}
