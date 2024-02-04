/*****************************************************
******************************************************
**                                                  **
**  Программа вычисления границ абсолютной и        **
**  относительной погрешностей арифметических       **
**  сложения и умножения                            **
**                                                  ** 
**  Выполнила: студентка 2 курса ЕПК гр. И-22       **
**  Данько Арина                                    ** 
**  Проверил: преподаватель (числ. мет.) Фомин А. Т.**
**                                                  **
******************************************************
*****************************************************/
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
Console.WriteLine($"dres = {dres(x, y, dx, dy):f4}"); 

