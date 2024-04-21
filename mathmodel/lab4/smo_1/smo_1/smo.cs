class Smo {
    const double lambda = 0.95;
    const double mu = 1.0;
    static double Zmax = Math.Round(lambda / (mu - lambda));
    static double[] z_arrive = new double[(int)Zmax];
    static double[] z_serve = new double[(int)Zmax];
    static double time = 0;

    public static void Input_thread() {
        double Zmax = Math.Round(lambda / (mu - lambda));
        int i, Nin = 0;
        Console.WriteLine("ВСЕ ВНУТРЕННИЕ ПРОЦЕССЫ ДАННОЙ МОДЕЛИ СЧИТАЮТСЯ В МИНУТАХ!!!");
        Console.WriteLine("Максимальное кол-во обслуживаемых заявок: {0}", (int)Zmax);
        Console.Write("Введите время моделирования в минутах: ");
        double modelTime = double.Parse(Console.ReadLine()!);
        for (i = 0; i < Zmax; i++) {
            time = time + rnd_expo(lambda);
            if (time < modelTime) {
                Nin++;
                z_arrive[i] = time;
                z_serve[i] = rnd_expo(mu);
            }
            else
                break;
        }
    }
    public static void Provide() {
        double[] z_begin = new double[Nin];
        double[] z_end = new double[Nin];
        time = 0;
        double timeServe;
        int Nserve = 0;
        for (i = 0; i < Nin; i++) {
            if (z_arrive[i] < time)
                timeServe = time;
            else
                timeServe = z_arrive[i];
            if (timeServe < modelTime) {
                z_begin[i] = timeServe;
                time = timeServe + z_serve[i];
                z_end[i] = time;
                Nserve++;
            }
            else
                break;
        }
    }
    public static void Output_info() {

    }
    static double rnd_expo(double lambda) {
        Random rand = new Random();
        double u = rand.NextDouble();
        double j = -Math.Log(u) / lambda;
        return j;
    }
}
