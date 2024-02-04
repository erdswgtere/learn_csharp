using System.Diagnostics;
var sw = new Stopwatch();
Stopwatch stopWatch = new Stopwatch();

int a, b, c;
Console.Write("a = ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("c = ");
c = Convert.ToInt32(Console.ReadLine());
stopWatch.Start();
if(a > b) {
    if(a > c) {
        Console.WriteLine($"Максимальное ={a, 3:d}");
    } else {
        Console.WriteLine($"Максимальное ={c, 3:d}");
    }
} else {
    if (b > c) {
        Console.WriteLine($"Максимальное ={b, 3:d}");
    } else {
        Console.WriteLine($"Максимальное ={c, 3:d}");
    }
}
int max = a;
if (b > max) {
    max = b;
} else{};
if(c > max){
    max = c;
} else{};
Console.WriteLine($"max ={max, 3:d}");

stopWatch.Stop();
TimeSpan ts = stopWatch.Elapsed;
 string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime);