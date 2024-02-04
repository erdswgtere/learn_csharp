/*****************************************************
******************************************************
**                                                  **
**  Программа вычисления корня функции с заданной   **
**  точностью с помощью комбинированного метода     **
**  Ньютона.                                        **
**                                                  **
**  Описание входных и выходных данных:             **
**  x1 - первая граница отрезка                     **
**  x2 - вторая граница отрезка                     **
**  eps - погрешность 10^-6(0,000001)               **                           **
**                                                  **
**  Вывод:                                          **
**  n - счётчик итераций                            **
**  x - уточнённый корень                           **
**  elapsedTime- время выполнения программы         **
**                                                  **
**                                                  ** 
**  Выполнил: студент 2 курса ЕПК гр.               **
**                                                  ** 
**  Проверил: преподаватель (числ. мет.) Фомин А. Т.**
**                                                  **
******************************************************
*****************************************************/
// НЕ ЗАБУДЬ ДОПИСАТЬ ГРУППУ И СВОЁ ИМЯ В ШАПКУ!
// НЕ ЗАБУДЬ УДАЛИТЬ ЭТИ КОМЕНТАРИИ (КРОМЕ ШАПКИ:))!

double F(double x){
    return Math.Pow(x, 3)+ 2 * Math.Pow(x, 2)- 15*x - 36; // поменять функцию на свою
}
Console.WriteLine("Введите величины");
Console.Write("x = ");
double x = Convert.ToDouble(Console.ReadLine()); // x начальный
Console.Write("b = ");
double b = Convert.ToDouble(Console.ReadLine()); // правый конец отрезка
double dx1 = 1E-10;
double derivX;
derivX = (F(x+dx1)-F(x))/dx1;
Console.Write("eps = ");
double eps = Convert.ToDouble(Console.ReadLine());
double m = -1/Math.Abs(deriv(b));
double derivf;
derivf = (f(x+dx1, m)-f(x, m))/dx1;
double q = x * Math.Abs(derivf);
double a = eps * (1 - q) / q;
double p, y;
do {
   y = x - m * F(x);
   p = x - y;
   x = y;
} while (Math.Abs(p) > a);
Console.Write($"x = {x:f6}\n derivB = {deriv(b):f6}\n m = {m:f6}\n derivX = {derivX:f6}\n q = {q:f6}");

double f(double x, double m){
    double y;
    y = 1 - m * derivX;
    return y;
}
double deriv(double a){
    double derrivative=(F(a+dx1)-F(a))/dx1;
    return derrivative;
}