
int a, b, c;
Console.Write("a = ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("c = ");
c = Convert.ToInt32(Console.ReadLine());
if(a > b) {
    if(a > c) {
        Console.WriteLine($"Максимальное ={a, 3:d}");
    } else {
        Console.WriteLine($"Максимальное ={c, 3:d}");
    }
} else {
    if (b > c) {
        Console.WriteLine($"Максимальное ={b, 3:d}");
    } else {
        Console.WriteLine($"Максимальное ={c, 3:d}");
    }
}