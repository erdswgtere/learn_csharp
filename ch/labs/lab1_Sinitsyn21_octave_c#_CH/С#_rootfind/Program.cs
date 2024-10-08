﻿/*****************************************************
******************************************************
**                                                  **
**  Программа вычисления корня функции с заданной   **
**  точностью методом дихотомии                     **
**                                                  **
**                                                  ** 
**  Выполнил: студент 2 курса ЕПК гр. И-22          **
**  Синицын Максим                                  ** 
**  Проверил: преподаватель (прог. мод.) Фомин А. Т.**
**                                                  **
******************************************************
*****************************************************/

double f(double x){
    double y;
    y = 0.5 * Math.Exp(-(x * x)) + x * Math.Cos(x);
    return y;
}
double a, b, eps, x;
Console.Write("(первая граница)a = ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("(вторая граница)b = ");
b = Convert.ToDouble(Console.ReadLine());
Console.Write("(точность вычислений)eps = ");
eps = Convert.ToDouble(Console.ReadLine());
int n = 0; // кол - во итераций
do {
    double c;
    c = (a + b) / 2;
    if(f(a) * f(c) < 0){
        b = c;
    } else{
        a = c;
    }
    n++;
} while(Math.Abs(b - a) > eps);
x = (a + b) / 2;
Console.WriteLine($"x = {x:f4}, n = {n:f2}");
