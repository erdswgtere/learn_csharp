ulong a;
ulong n = 1;
ulong b = 0;
Console.Write("a = ");
a = Convert.ToUInt64(Console.ReadLine());
while(a != 0){
    b = a % 10;
    n *= b;
    a /= 10;

}
if(n < 50){
    Console.WriteLine("Верно");

} else{
    Console.WriteLine("Неверно");
}
