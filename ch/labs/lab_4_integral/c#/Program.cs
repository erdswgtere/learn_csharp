static double F(double x){
    return x / Math.Sqrt(x * x +1.8);
}
static double Compute(double a, double b, uint n){
    double h, x, s;
    s = (F(a) - F(b)) / 2; 
    h = (b - a) / n;
    x = a + h;
    do{
        s+= 2*F(x)+F(x + h);
        x += 2 * h;
    } while((x - b) < 0);
    s = 2 * h * s / 3;
    return s;
}
double eps, a, b, I1, I2;
Console.Write("a = ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("b = ");
b = Convert.ToDouble(Console.ReadLine());
Console.Write("n = ");
uint n = Convert.ToUInt32(Console.ReadLine());
Console.Write("eps = ");
eps = Convert.ToDouble(Console.ReadLine());
do{
    I1 = Compute(a, b, n);
    I2 = Compute(a, b, 2*n);
    n *= 2;
} while (Math.Abs(I1 - I2) > 15 * eps);
Console.WriteLine($"\nn = {n}\nIntegral = {I2} int1={I1}");

