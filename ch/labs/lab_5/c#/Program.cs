double f(double x1, double y2){
   return -4 * Math.Pow(x1, 3) + 4 * x1 * y2;
}
double R_K(double x, double y, double h){
    double r1 = h * f(x, y);
    double r2 = h * f(x + h / 2, y + r1 / 2);
    double r3 = h * f(x + h / 2, y + r2 / 2);
    double r4 = h * f(x + h, y + r3);
    return y + (r1 + 2 * r2 + 2 * r3 + r4) / 6;
}
Console.Write("Начальное значение x = ");
double x = Convert.ToDouble(Console.ReadLine());
double y = 0.5;
Console.Write("Шаг интегрирования h = ");
double h = Convert.ToDouble(Console.ReadLine());
Console.Write("Конец отрезка b = ");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\nТаблица значений искомой функции:");
do {
    Console.WriteLine($"{x:f7}\t{y:f7}");
    y = R_K(x, y, h);
    x += h;
} while (x < (b + h / 2));