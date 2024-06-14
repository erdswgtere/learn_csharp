using random_generators;

namespace ShootingProbabilityMonteCarlo {
    class Program {
        const double M = 0.5;
        const double D = 0.0833;
        static void Main(string[] args) {
            Console.Write("Введите кол-во испытаний: ");
            int experiments = int.Parse(Console.ReadLine()!);

            Normal_gen rnd = new(12);
            double p1 = rnd.Normal(M, D);
            double p2 = rnd.Normal(M, D);
            double p3 = rnd.Normal(M, D);
            double p4 = rnd.Normal(M, D);

            int count_0_hits = 0;
            int count_1_hit = 0;
            int count_2_hits = 0;
            int count_3_hits = 0;
            int count_4_hits = 0;

            for (int i = 0; i < experiments; i++) {
                int hits = 0;
                if (rnd.Normal(M, D) < p1) hits++;
                if (rnd.Normal(M, D) < p2) hits++;
                if (rnd.Normal(M, D) < p3) hits++;
                if (rnd.Normal(M, D) < p4) hits++;

                if (hits == 0) count_0_hits++;
                if (hits == 1) count_1_hit++;
                if (hits == 2) count_2_hits++;
                if (hits == 3) count_3_hits++;
                if (hits == 4) count_4_hits++;
            }

            double P_0_4 = (double)count_0_hits / experiments;
            double P_1_4 = (double)count_1_hit / experiments;
            double P_2_4 = (double)count_2_hits / experiments;
            double P_3_4 = (double)count_3_hits / experiments;
            double P_4_4 = (double)count_4_hits / experiments;
            double R_X_4 = 1 - P_0_4;
            double R_2_4 = P_2_4 + P_3_4 + P_4_4;

            Console.WriteLine($"p1 = {p1:F2}, p2 = {p2:F2}, p3 = {p3:F2}, p4 = {p4:F2}");
            Console.WriteLine($"Вероятность ни одного попадания: {P_0_4:F4}");
            Console.WriteLine($"Вероятность одного попадания: {P_1_4:F4}");
            Console.WriteLine($"Вероятность двух попаданий: {P_2_4:F4}");
            Console.WriteLine($"Вероятность трех попаданий: {P_3_4:F4}");
            Console.WriteLine($"Вероятность четырех попаданий: {P_4_4:F4}");
            Console.WriteLine($"Вероятность хотя бы одного попадания: {R_X_4:F4}");
            Console.WriteLine($"Вероятность не менее двух попаданий: {R_2_4:F4}");
        }
    }
}


