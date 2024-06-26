﻿/*****************************************************
******************************************************
**                                                  **
**  Программа для численного дифференцироания       **
**  функции методом Рунге-Кутта                     **
**                                                  **
**  Описание входных и выходных данных:             **
**  x - начальное значение x из задания(x0)         **
**  y - начальное значения y из задания(y0)         **
**  eps - погрешность 10^-6(0,000001)               **
**  h- шаг дифференцирования                        **
**  f(x1, y2)- правая часть диффур'a                **
**  R_K(x, y, h)- метод Рунге-Кутта                 **
**  для численного дифференцирования                **
**                                                  **
**                                                  **
**  Вывод:                                          **
**  x- итерационный вывод значений x с шагом h на   **
**  заданном отрезке                                **
**  y - итерационный вывод таблицы значений         **
**  исходной функции                                **
**                                                  ** 
**  Выполнил: студент 2 курса ЕПК гр.               **
**                                                  ** 
**  Проверил: преподаватель (числ. мет.) Фомин А. Т.**
**                                                  **
******************************************************
*****************************************************/
// НЕ ЗАБУДЬ ДОПИСАТЬ ГРУППУ И СВОЁ ИМЯ В ШАПКУ!
// НЕ ЗАБУДЬ УДАЛИТЬ ЭТИ КОМЕНТАРИИ (КРОМЕ ШАПКИ:))!
double f(double x1, double y2){
   return -4 * Math.Pow(x1, 3) + 4 * x1 * y2; // заменить праву часть диффура на свою (надо чтобы y' оказался в левой части а остальное перенести вправо поменяв знак и записать это сюда)
}
double R_K(double x, double y, double h){
    double r1 = h * f(x, y);
    double r2 = h * f(x + h / 2, y + r1 / 2);
    double r3 = h * f(x + h / 2, y + r2 / 2);
    double r4 = h * f(x + h, y + r3);
    return y + (r1 + 2 * r2 + 2 * r3 + r4) / 6;
}
Console.Write("Начальное значение x = "); // начальное значение x(из условий задачи)
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Начальное значение y = "); // начальное значение y(из условий задачи)
double y = Convert.ToDouble(Console.ReadLine());
Console.Write("Шаг интегрирования h = "); // шаг интегрирования (скорее всего будет 0.1)- НАДО СПРОСИТЬ?
double h = Convert.ToDouble(Console.ReadLine());
Console.Write("Конец отрезка b = "); // правая граница отрезка интегрирования (левая задалась через x) скорее всего здесь будет x0+1(начальный x + 1)
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\nТаблица значений искомой функции:");
do {
    Console.WriteLine($"{x:f7}\t{y:f7}");
    y = R_K(x, y, h);
    x += h;
} while (x < (b + h / 2));