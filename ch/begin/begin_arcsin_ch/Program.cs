System.Globalization.CultureInfo.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
double x, dx;
double Dres(double dx1, double x1){
    return dx1 / Math.Sqrt(1 - Math.Pow(x1, 2));
}
double dres(double dx1, double x1) {
    double delta_x = dx1 / x1;
    double res = Math.Abs(x1) / (Math.Abs(Math.Asin(x1)) * Math.Sqrt(1 - Math.Pow(x1, 2))) * delta_x;
    return res;
}
Console.WriteLine("Введите данные");
Console.Write("x = ");
x = Convert.ToDouble(Console.ReadLine());
Console.Write("dx = ");
dx = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Dres = {Dres(dx, x):f4}");
Console.WriteLine($"dres = {dres(dx, x):f4}");
Console.WriteLine("CurrentCulture is {0}.", System.Globalization.CultureInfo.CurrentCulture.Name);