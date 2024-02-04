using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Метод простой итерации для уточнения корня уравнения");

        // Исходное уравнение: f(x) = x^2 - 2 = 0
        Func<double, double> equation = x => x * x - 2;

        // Производная от уравнения (автоматически вычисленная)
        Func<double, double> derivative = x => NumericalDerivative(equation, x);

        // Начальное приближение к корню
        double initialGuess = 1.5;

        // Погрешность
        double tolerance = 1e-6;

        // Максимальное количество итераций
        int maxIterations = 1000;

        // Вызов метода простой итерации
        double result = SimpleIterationMethod(equation, derivative, initialGuess, tolerance, maxIterations);

        Console.WriteLine($"Приближенное значение корня: {result}");
    }

    static double SimpleIterationMethod(Func<double, double> equation, Func<double, double> derivative, double x0, double tolerance, int maxIterations)
    {
        double x = x0;

        for (int i = 0; i < maxIterations; i++)
        {
            double fx = equation(x);

            // Проверка на достижение необходимой точности
            if (Math.Abs(fx) < tolerance)
                return x;

            // Итерационный шаг
            x = x - fx / derivative(x);
        }

        throw new InvalidOperationException("Метод не сошелся к корню после максимального числа итераций.");
    }

    static double NumericalDerivative(Func<double, double> function, double x)
    {
        // Численное вычисление производной методом конечных разностей
        double h = 1e-8;
        return (function(x + h) - function(x)) / h;
    }
}
