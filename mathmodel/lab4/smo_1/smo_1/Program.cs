namespace smo_1 {
    internal class Program {
        static void Main(string[] args) {
           double time = 0;
            int i, Nin = 0;
            for(i = 0; i < Zmax; i++) {
                time = time + rnd_expo(lambda);
                if (time < modeltime) {
                    Nin++;
                    z_arrive[i] = time;
                    z_serve[i] = rnd_expo(mu);
                }
                else
                    break;
            }
        }
    }
}
