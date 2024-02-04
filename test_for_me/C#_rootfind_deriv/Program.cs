using System.Diagnostics;
var sw = new Stopwatch();
Stopwatch stopWatch = new Stopwatch();

double f(double x){
    return x * Math.Log(x) - Math.Exp(-0.5 * (x * x));
}
double c, x1, x2, r, d, eps;
Console.Write("a = ");
x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b = ");
x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("eps = ");
eps = Convert.ToDouble(Console.ReadLine());
c = x1;
double dx1 = 1E-13;
double deriv;
deriv = (f(x1+dx1)-f(x1))/dx1;
int n = 0;
stopWatch.Start();
do{
   x1 -= f(x1) / deriv; //(Math.Exp(0.5 * Math.Pow(x1, 2)) * Math.Log(x1) + Math.Exp(0.5 * Math.Pow(x1, 2)) + x1) / Math.Exp(0.5 * Math.Pow(x1, 2));
   x2 = (c * f(x2) - x2 * f(c)) / (f(x2) - f(c));
   r = (x1 + x2)/2;
   d = (x1 - x2)/2; 
   n++;
} while(Math.Abs(d) > eps);
stopWatch.Stop();
TimeSpan ts = stopWatch.Elapsed;
Console.WriteLine($"x = {r:f4}; кол-во повторений {n:d1}");
string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}.{4:00}",
ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10, ts.Nanoseconds / 10);
Console.WriteLine("RunTime " + elapsedTime);