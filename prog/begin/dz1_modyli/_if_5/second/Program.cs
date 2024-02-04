int a, b, c;
Console.Write("a = ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("c = ");
c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max) {
    max = b;
} else{};
if(c > max){
    max = c;
} else{};
Console.WriteLine($"max ={max, 3:d}");

