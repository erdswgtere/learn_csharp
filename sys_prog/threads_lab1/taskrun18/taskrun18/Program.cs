using System.Diagnostics;

namespace taskrun18 {
    internal class Program {
        static void Main(string[] args) {
            
            var stopwatch = new Stopwatch();
            var tskrunrec = new TaskRunRecursion();
            Console.Write("Введите сколько задач вы хотите запустить: ");
            tskrunrec.Kol = ulong.Parse(Console.ReadLine()!);
            stopwatch.Start();
            tskrunrec.GetResult();
            stopwatch.Stop();
            long elapsedTime = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Время выполнения: {elapsedTime} ms");
            stopwatch.Reset();

            var notskrunrec = new NoTaskRunRecursion();
            stopwatch.Start();
            var k = notskrunrec.RecSum();
            Console.WriteLine($"Результат равен: {k}");
            stopwatch.Stop();
            elapsedTime = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Время выполнения: {elapsedTime} ms");
            
        }
        
    }
    class NoTaskRunRecursion {
        static ulong Rec(ulong x) {
            if (x <= 18)
                return x + 3;
            else if (x > 18 && x % 3 == 0)
                return x / 3 * Rec(x / 3) + x - 12;
            else
                return Rec(x - 1) + x * x + 5;
        }
       public ulong RecSum() {
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
    }
    class TaskRunRecursion {
       static ulong kol;
       static ulong k = 0;
        public ulong Kol{
            get => kol;
            set => kol = value;
        }
       static ulong Rec(ulong x) {
            if (x <= 18)
                return x + 3;
            else if (x > 18 && x % 3 == 0)
                return x / 3 * Rec(x / 3) + x - 12;
            else
                return Rec(x - 1) + x * x + 5;
        }
        static bool RecSum(ulong StartCount) {
            ulong i;
            for (i = 0 + StartCount; i <= 10000000; i+=kol) {
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
            return true;
        }
        public void GetResult() {
            var tasks = new List<Task<bool>>();
            ulong strCount = 0;
            for (uint ctr = 1; ctr <= kol; ctr++){
                tasks.Add(Task.Run(() => RecSum(strCount++)));
            }
            Task.WaitAll(tasks.ToArray());
            Console.WriteLine($"Результат вычислений {k}");
        }
    }
}
