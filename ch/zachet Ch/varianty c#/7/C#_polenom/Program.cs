/*****************************************************
******************************************************
**                                                  **
**  Программа интерполирования функции в заданной   **
**  точке с помощью полинома Лагранжа 2-й степени   **
**  Описание входных и выходных данных:             **
**  size  - степень полинома                        **
**  xValues - массив значений x                     **
**  yValues - массив значений y                     **
**  x- точка для интерполирования                   **
**  TestF - полученный полином Лагранжа             **
**  delta - абсолютная погршность                   **
**  f(x) - исходная функция                         **
**                                                  **
**  Вывод:                                          **
**  InterpolateLagrangePolynomial(x, xValues,       **
**  yValues,size) - функция интерполирования        **
**  delta - погрешность                             **
**                                                  **
**  Выполнил: студент 2 курса ЕПК гр.               **
**                                                  ** 
**  Проверил: преподаватель (числ. мет.) Фомин А. Т.**
**                                                  **
******************************************************
*****************************************************/
// НЕ ЗАБУДЬ ДОПИСАТЬ ГРУППУ И СВОЁ ИМЯ В ШАПКУ!
// НЕ ЗАБУДЬ УДАЛИТЬ ЭТИ КОМЕНТАРИИ (КРОМЕ ШАПКИ:))!
namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Console.Write("Задайте степень полинома\nn = ");
            int size = Convert.ToInt32(Console.ReadLine());
            size++;
            var xValues = new double[size];
            var yValues = new double[size];
            Console.WriteLine($"x[i]:");
            for (int i = 0; i < size; i++)
            {
                xValues[i] = Convert.ToSingle(Console.ReadLine()); // вводить надо только иксы игрики сразу считаются
            }
            for (int i = 0; i < size; i++)
            {
                yValues[i] = f(xValues[i]);
            }
            Console.Write("Задайте значение для интерполирования: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Значение полинома в точке x: ");
            Console.WriteLine(InterpolateLagrangePolynomial(x, xValues, yValues, size));
            Console.Write("Значение исходной функции в точке x: ");
            Console.WriteLine(f(x));
            double delta = Math.Abs(f(x)-InterpolateLagrangePolynomial(x, xValues, yValues, size));
            Console.WriteLine($"Погрешность равна {delta:f6}");
        }
        static double InterpolateLagrangePolynomial (double x, double[] xValues, double[] yValues, int size)
        {
            double lagrangePol = 0;
            for (int i = 0; i < size; i++)
            {
                    double basicsPol = 1;
                    for (int j = 0; j < size; j++)
                    {
                        if (j != i)
                        {
                            basicsPol *= (x - xValues[j])/(xValues[i] - xValues[j]);
                        }
                    }
                    lagrangePol += basicsPol * yValues[i];
            }
            return lagrangePol;
        }
        static double TestF(double x)
        {
            return  0.256*Math.Pow(x, 3)- 0.064*Math.Pow(x, 2) + 0.42*x +0.323; // заменить полином на свой
        }
        static double f(double x){
            return Math.Exp(x)/3; // здесь писать исходную функцию
        }
    }
}
