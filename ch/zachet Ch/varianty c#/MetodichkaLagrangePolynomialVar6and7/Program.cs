Console.Write("Введите степень полинома: ");
int size = Convert.ToInt32(Console.ReadLine()); 
size++; // Данные собираем на единицу больше
Console.Write($"Введите значени аргумента, для которого требуется найти значение функции:\na = ");
double a = Convert.ToSingle(Console.ReadLine());
var xValues = new double[size]; // Табличные данные
var yValues = new double[size];

// === Если функция задана аналитически ==== // 
/*Console.WriteLine("Введите значения узлов интерполяции:");
for (int i = 0; i < size; i++) {
    double x_i;
    Console.Write($"x_{i} = ");
    x_i = Convert.ToSingle(Console.ReadLine());
    xValues[i] = x_i; 
    yValues[i] = F(x_i);
}

static double F(double x) {
    return  x * x * x + 3 * x * x + 3 * x + 1; // Ваша функция
}*/
//=== Конец Если функция задана аналитически === // 

// === Если функция задана таблично ==== //
Console.WriteLine("Введите значения узлов интерполяции и значения функции в этих узлах:");
for (int i = 0; i < size; i++) {
    double x_i, y_i;
    Console.Write($"x_{i} = ");
    x_i = Convert.ToSingle(Console.ReadLine());
     Console.Write($"y_{i} = ");
    y_i = Convert.ToSingle(Console.ReadLine());
    xValues[i] = x_i; 
    yValues[i] = y_i;
}
//=== Конец Если функция задана таблично === //
 
Console.WriteLine($"Результат интерполирования функции " + 
                  $"в данной точке:\n{Interpolate(a, xValues, yValues, size)}");

static double Interpolate(double x, double[] xValues, double[] yValues, int size) {
    double lagrangePol = 0;
 
    for (int i = 0; i < size; i++) {
        double basicsPol = 1;
        for (int j = 0; j < size; j++) {
            if (j != i) {
                basicsPol *= (x - xValues[j])/(xValues[i] - xValues[j]);
            }
        }
        lagrangePol += basicsPol * yValues[i];
    }
    return lagrangePol;
}



