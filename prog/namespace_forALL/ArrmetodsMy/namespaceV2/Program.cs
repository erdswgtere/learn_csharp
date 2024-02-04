/*****************************************************
******************************************************
**                                                  **
**  12.83. Составить программу: а) нахождения       **
**  минимального значения среди элементов любой     **
**  строки двумерного массива                       **
**                                                  **
**  Выполнил: студент 2 курса ЕПК гр. И-21          **
**            Иванов Иван                           **
**  Проверил: преподаватель (предмет) Фомин А. Т.   **
**                                                  **
******************************************************
*****************************************************/
using MyNamespace.Matrices;
// Размерность матрицы
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
// Массив массивов
int[][] ar = new int[n][];
// Заполнение и вывод двухмерного массива
ArrMethodsMat.InputMas(ref ar);
ArrMethodsMat.PrintMas(ref ar);
Console.WriteLine();
// Номер строки
Console.Write("RowNumber = ");
int RowNumber = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine($"\nmin = {ArrMethodsMat.RowMin(ref ar, RowNumber)}\n");