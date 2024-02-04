double f(double x){
    double y;
    y = 0.5 * Math.Exp(Math.Pow(-x, 2)) + x * Math.Cos(x);
    return y;
}
double a, b, eps, x;
Console.WriteLine("Введите данные:");
Console.WriteLine("")