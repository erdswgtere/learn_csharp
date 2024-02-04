ulong n;
ulong i = 1;
Console.Write("a = ");
n = Convert.ToUInt64(Console.ReadLine());
ulong raz = n % 10;
n = n / 10;
while(n != 0){
    if(n % 10 == raz){
        i = i + 1;
    }

    n /= 10;

}
Console.WriteLine($"Количество цифр равных последнему разряду = {i, 1:d}");