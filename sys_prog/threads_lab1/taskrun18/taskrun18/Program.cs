using System.Diagnostics;

namespace taskrun18 {
    internal class Program {
        static void Main(string[] args) {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            GetResult();
            long elapsedTime = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Время выполнения: {elapsedTime} ms");
        }
        static ulong Rec(ulong x) {
            if (x <= 18)
                return x + 3;
            else if (x > 18 && x % 3 == 0)
                return x / 3 * Rec(x / 3) + x - 12;
            else
                return Rec(x - 1) + x * x + 5;
        }
        static ulong RecSum() {
            ulong k = 0;
            for (ulong i = 1; i <= 10000000; i++) {
                bool ch = true;
                ulong a = Rec(i);
                while (a != 0) {
                    if (a % 2 == 0) {
                        a /= 10;
                    }
                    else {
                        ch = false;
                        break;
                    }
                }
                if (ch == true) k++;
            }
            return k;
        }
        static void GetResult() {
            var TaskRec = new Task<ulong>(() => RecSum());
            TaskRec.Start();
            Console.WriteLine($"Результат вычислений {TaskRec.Result}");
        }
    }
    class NoThreadRecursion {

    }
    class ThreadRecursion {

    }
}
