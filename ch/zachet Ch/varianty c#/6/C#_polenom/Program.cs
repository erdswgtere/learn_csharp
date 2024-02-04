/*****************************************************
******************************************************
**                                                  **
**  Программа интерполирования функции в заданной   **
**  точке с помощью полинома Лагранжа 4-й степени   **
**  Описание входных и выходных данных:             **
**  size  - степень полинома                        **
**  xValues - массив значений x                     **
**  yValues - массив значений y                     **
**  x- точка для интерполирования                   **
**  f(x) - исходная функция                         **
**                                                  **
**  Вывод:                                          **
**  InterpolateLagrangePolynomial(x, xValues,       **
**  yValues,size) - функция интерполирования        **
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
            var xValues = new double[size]; // вводить только иксы из таблицы, игрики посчитаются сразу
            var yValues = new double[size];
            Console.WriteLine($"x[i]:");
            for (int i = 0; i < size; i++)
            {
                xValues[i] = Convert.ToSingle(Console.ReadLine());
            }
            Console.WriteLine($"y[i]:");
            for (int i = 0; i < size; i++)
            {
                yValues[i] = Convert.ToSingle(Console.ReadLine());
            }
            Console.Write("Задайте значение для интерполирования: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(InterpolateLagrangePolynomial(x, xValues, yValues, size));
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
    }
}
