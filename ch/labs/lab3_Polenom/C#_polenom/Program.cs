﻿namespace ConsoleApp
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
                xValues[i] = Convert.ToSingle(Console.ReadLine());;
                yValues[i] = TestF(xValues[i]);
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
        static double TestF(double x)
        {
            return  0.256*Math.Pow(x, 3)- 0.064*Math.Pow(x, 2) + 0.42*x +0.323; // заменить поленом на свой
        }
    }
}
