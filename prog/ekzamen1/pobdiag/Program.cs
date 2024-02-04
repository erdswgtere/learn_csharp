using Matrices;
// Размерность матрицы
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
// Массив массивов
int[][] ar = new int[n][];
// Заполнение и вывод двухмерного массива
ArrMethodsMat.InputMas(ref ar);
ArrMethodsMat.PrintMas(ref ar);
Console.WriteLine();
SrSum(ref ar);

static void SrSum(ref int[][] mas) {
    int sum1 = 0;
    int sum2 = 0;
    for (int i = 0; i < mas.Length; i++) {
        for (int j = 0; j < mas.Length; j++) {
            if(i + j + 1 == mas.Length){
                continue;
            }if(i + j + 1 < mas.Length ){
                sum1 = mas[i][j] + sum1;
            }else{
                sum2 = mas[i][j] + sum2;
            }
        }
    }
    if(sum1 > sum2){
        Console.Write($"Сумма элементов выше побочной диагонали больше, сумма элементов равна {sum1}");
    }else{
        Console.Write($"Сумма элементов ниже побочной диагонали больше, сумма элементов равна {sum2}");
    }
    Console.WriteLine();
}
