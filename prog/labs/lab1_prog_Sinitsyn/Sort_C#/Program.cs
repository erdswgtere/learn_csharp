using MyNamespace.Vectors;
using MyNamespace.Vectors.SortMethods;
using System.Diagnostics;



Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[] ar = new int[n];
int r = 0;

Console.Write("----Вставками----\n");
ArrMethodsVec.InputMas(ref ar);
ArrMethodsVec.PrintMas(ref ar);
Console.Write($"--Исходный массив".PadLeft(2));
Console.WriteLine();
Console.Write($"=====ПРОЦЕСС СОРТИРОВКИ=====".PadLeft(2));
Console.WriteLine();
Sort.InsertionSort_iterationOut(ref ar, ref r);
Console.WriteLine();
ArrMethodsVec.PrintMas(ref ar);

Console.Write($"--Сортированный массив".PadLeft(2));
Console.WriteLine($"\nКоличество итераций: {r}\n");

Console.Write("----Быстрая----\n");
r = 0;
ArrMethodsVec.InputMas(ref ar);
ArrMethodsVec.PrintMas(ref ar);
Console.WriteLine();
Sort.myQsort(ref ar, 0, ar.Length - 1, ref r);
Console.WriteLine();
ArrMethodsVec.PrintMas(ref ar);
Console.WriteLine($"\nКоличество итераций: {r}\n");

Console.WriteLine("ПРОВЕДЕНИЕ ТЕСТОВ:");
Console.Write("k = ");
int k = Convert.ToInt32(Console.ReadLine());
int[] test = new int[k];
int it = 0;

var swV = new Stopwatch();
ArrMethodsVec.InputMas(ref test);
swV.Start();
Sort.InsertionSort(ref test, ref it);
swV.Stop();
TimeSpan tsV = swV.Elapsed;
Console.Write($"\nКоличество итераций метода вставки: {it}\n");
string elapsedTimeV = String.Format("{0:00}:{1:00}:{2:00}.{3:00}.{4:00}",
        tsV.Hours, tsV.Minutes, tsV.Seconds,
        tsV.Milliseconds / 10, tsV.Nanoseconds / 10);
Console.WriteLine("Время выполения сортировки методом вставок: " + elapsedTimeV);

var swQ = new Stopwatch();
it = 0;
ArrMethodsVec.InputMas(ref test);
swQ.Start();
Sort.myQsort(ref test, 0, test.Length - 1, ref it);
swQ.Stop();
TimeSpan tsQ = swQ.Elapsed;
Console.Write($"\nКоличество итераций быстрой сортировки: {it}\n");
string elapsedTimeQ = String.Format("{0:00}:{1:00}:{2:00}.{3:00}.{4:00}",
        tsQ.Hours, tsQ.Minutes, tsQ.Seconds,
        tsQ.Milliseconds / 10, tsQ.Nanoseconds / 10);
Console.WriteLine("Время выполнения быстрой сортировки: " + elapsedTimeQ);