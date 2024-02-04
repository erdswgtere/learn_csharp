using MyColletions;
using MyNamespace.Vectors;


Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите промежуток чисел для заполения массива: ");
Console.Write("a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int b = Convert.ToInt32(Console.ReadLine());

int[] ar = new int[n];
ArrMethodsVec.InputMas(ref ar, ref a, ref b);
Console.WriteLine("Стандартный массив: ");
ArrMethodsVec.PrintMasT<int>(ref ar);
Console.WriteLine();

List<int> lst = new List<int>(ar);
Console.WriteLine("Коллекция list: ");
MyColletionList.PrintMasL(ref lst);
Console.WriteLine();
MyColletionList.FoundUnsuccessStudL(ref lst);