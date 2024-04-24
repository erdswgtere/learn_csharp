static class Smo {
    const double lambda = 0.95;
    const double mu = 1.0;
    static double Zmax = Math.Round(lambda / (mu - lambda));
    static double[] z_arrive = new double[(int)Zmax];
    static double[] z_serve = new double[(int)Zmax];
    static double time = 0;
    static int Nin = 0;
    static double modelTime;
    static double timeEnd;
    static double[] Z_begin;
    static double[] Z_end;
    static int NServe;

    public static void Input_thread() {
        Console.WriteLine("ВСЕ ВНУТРЕННИЕ ПРОЦЕССЫ ДАННОЙ МОДЕЛИ СЧИТАЮТСЯ В МИНУТАХ!!!");
        Console.WriteLine("Максимальное кол-во обслуживаемых заявок: {0}", (int)Zmax);
        Console.Write("Введите время моделирования в минутах: ");
        modelTime = double.Parse(Console.ReadLine()!);
        for (int i = 0; i < Zmax; i++) {
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
        for (int i = 0; i < Nin; i++) {
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
        Z_begin = z_begin;
        Z_end = z_end;
        NServe = Nserve;
        timeEnd = time;
    }
    public static void Output_info() {
        double timeWait = 0;
        double timeSys = 0;
        double timeWork = 0;
        for (int i = 0; i < NServe; i++) {
            timeWait += (Z_begin[i] - z_arrive[i]);
            timeSys += (Z_end[i] - z_arrive[i]);
            timeWork += z_serve[i];
        }
        Console.WriteLine("Число поступивших заявок: {0}", Nin);
        Console.WriteLine("Число обслуженных заявок: {0}", NServe);
        Console.WriteLine("Среднее время ожидания в очереди: {0:f4}", (double)timeWait / NServe);
        Console.WriteLine("Среднее время пребывания в системе: {0:f4}", (double)timeSys / NServe);
        Console.WriteLine("Коэффициент использования СМО: {0:f4}", (double)timeWork / timeEnd);
    }
    static double rnd_expo(double lambda) {
        Random rand = new Random();
        double u = rand.NextDouble();
        double j = -Math.Log(u) / lambda;
        return j;
    }
}
