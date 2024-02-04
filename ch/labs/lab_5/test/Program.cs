using System;
 
namespace MetodRyngeKytta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            double x, y, f, g, k1, k2, k3, k4, h;
            x = 2;                  // Крайняя левая точка диапазона "х"
            y = 2/3;                 // Значение "у" в крайней левой точке
            h = 0.1;                // Шаг сетки "h"
            int t = 6;             // Округление до нужного знака, после запятой
            int n= 3;            // Количество итераций 
            double Function_f(double a, double b)
            {
                return a / 2 - (a * b / 2*(1 - a * b));  // Заданная функция, где х=а, у=b
            }
            for (int j = 1; j <= n; j++)
            {
                k1 = Function_f(x, y);
                k2 = Function_f(x + h / 2, y + (h * k1 / 2));
                k3 = Function_f(x + h / 2, y + (h * k2 / 2));
                k4 = Function_f(x + h, y + (h * k3));
                g = (h / 6) * (k1 + 2 * k2 + 2 * k3 + k4);
                y = (g + y);
                Console.WriteLine($"Значение <delta-y> в точке {j} : {Math.Round(g, t)}");
                Console.WriteLine($"Значение <y> в точке {j} : {Math.Round(y, t)}");
                x = x + h;
                if (j != n) 
                    Console.WriteLine("Нажмите любую клавишу для продолжения вычислений...");
                Console.ReadKey();
            }
            Console.WriteLine("Нажмите любую клавишу для завершения программы...");
            Console.ReadKey();
        }
 
    }
}