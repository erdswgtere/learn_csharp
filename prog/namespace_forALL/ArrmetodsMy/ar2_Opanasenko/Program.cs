using MyNamespace.Matrices;
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[][] ar = new int[n][];
ArrMethodsMat.InputMas(ref ar, n);
ArrMethodsMat.PrintMas(ref ar, n);
ArrMethodsMat.CountZeroDiag(ref ar, n);
Console.WriteLine();
