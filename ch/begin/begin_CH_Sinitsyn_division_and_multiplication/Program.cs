/*****************************************************
******************************************************
**                                                  **
**  Программа вычисления границ абсолютной и        **
**  относительной погрешностей арифметических       **
**  сложения и умножения                            **
**                                                  ** 
**  Выполнил: студент 2 курса ЕПК гр. И-22          **
**  Синицын Максим                                  ** 
**  Проверил: преподаватель (числ. мет.) Фомин А. Т. **
**                                                  **
******************************************************
*****************************************************/
using System.Diagnostics;
var timer = new Stopwatch();
timer.Start();
double x, y, dx, dy;
double Dres(double dx1, double dy1) {
return (Math.Abs(x) * dx) + (Math.Abs(y) * dy);
}
double dres(double x1, double y1, double dx1, double dy1) {
double delta_x = dx1 / x1;
double delta_y = dy1 / y1;
double res = delta_x + delta_y;
return res;
}
double x1, y1, dx1, dy1;
double Dres1(double dx1, double dy1) {
return (Math.Abs(x1) * dy1 + Math.Abs(y1) * dx1) / Math.Pow(y1, 2);
}
double dres1(double x1, double y1, double dx1, double dy1) {
double delta_x = dx1 / x1;
double delta_y = dy1 / y1;
double res = delta_x + delta_y;
return res;
}
timer.Stop();
TimeSpan ts = timer.Elapsed;
int i ;
Console.Write("Введите действие 1(*) или 2(/): ");
i = Convert.ToInt32(Console.ReadLine());
if(i == 1){
    Console.WriteLine("Введите величины:");
    Console.Write("x = ");
    x = Convert.ToDouble(Console.ReadLine());
    Console.Write("y = ");
    y = Convert.ToDouble(Console.ReadLine());
    Console.Write("dx = ");
    dx = Convert.ToDouble(Console.ReadLine());
    Console.Write("dy = ");
    dy = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Dres = {Dres(dx, dy):f4}");
    Console.WriteLine($"Dres = {dres(x, y, dx, dy):f4}"); 
}if(i == 2) {
    Console.WriteLine("Введите величины:");
    Console.Write("x = ");
    x1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("y = ");
    y1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("dx = ");
    dx1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("dy = ");
    dy1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Dres = {Dres1(dx1, dy1):f4}");
    Console.WriteLine($"Dres = {dres1(x1, y1, dx1, dy1):f4}"); 

} if(i > 2 | i < 1){
    Console.WriteLine("ЛИБО УМНОЖЕНИЕ(1) ЛИБО ДЕЛЕНИЕ(2)");
}
 // форматированный вывод времени.
string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}.{4:00}",
ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10, ts.Nanoseconds / 10 );
Console.WriteLine("RunTime " + elapsedTime);