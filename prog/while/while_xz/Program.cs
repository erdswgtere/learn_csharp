ulong min = 10;
ulong max = 0;
ulong n;
Console.WriteLine("Введите число");
n = Convert.ToUInt64(Console.ReadLine());
while(n > 0){
    if (max < n % 10){
        max = n % 10;
    } if (min >  n % 10){
        min = n % 10;

    }
    n /= 10;
}
Console.WriteLine(max);
Console.WriteLine(min);