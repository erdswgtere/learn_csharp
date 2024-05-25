using System.Threading.Tasks;
using System.Threading;
using Generators;
using System;
class Program
{

    static void Main()
    {
        const int CountOfSimulations = 100000;
        var source = new CancellationTokenSource();
        var token = source.Token;
        double count1 = 0;
        double count2 = 0;
        Parallel.For(0, CountOfSimulations, cycle =>
        {
            double Defect = Approximation.GenerateProbability();
            double Controller = Approximation.GenerateController();
            if (Defect == 1)
            {
                switch (Controller)
                {
                    case 1:
                        if (Approximation.GenerateProbability() < 7) ++count1; source.Cancel();
                        break;
                    case 2:
                        if (Approximation.GenerateProbability() < 8) ++count1; source.Cancel();
                        break;
                    case 3:
                        if (Approximation.GenerateProbability() < 10) ++count1; source.Cancel();
                        break;
                }
                if (Approximation.GenerateProbability() < 9) ++count2;
            }
        });

        double ProbB = count1 / CountOfSimulations;
        double ProbC = count2 / CountOfSimulations;
        double ProbA = ProbB * ProbC;
        Console.WriteLine($"Вероятность события А: {ProbA:f3}"); // изделие будет забраковано
        Console.WriteLine($"Вероятность события B: {ProbB:f3}"); // изделие будет забраковано в цехе
        Console.WriteLine($"Вероятность события C: {ProbC:f3}"); // изделие будет забраковано в ОТК
    }
}