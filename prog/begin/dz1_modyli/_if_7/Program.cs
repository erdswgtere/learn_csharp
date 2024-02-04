int a, b, c;
Console.Write("a = ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("c = ");
c = Convert.ToInt32(Console.ReadLine());
int i = 0;
if (a > 0) i++;
if (b > 0) i++;
if (c > 0) i++;
if (i != 0) {
    Console.WriteLine($"Количество положительных чисел равно {i, 1:d}");
} else{
    Console.WriteLine("Положительных чисел нет!");
}
