namespace MyNamespace
{
    namespace Matrices{
        public static class ArrMethodsMat
        {
            public static void InputMas(ref int[][] mas ) {
                var rnd = new Random();
                for (int i = 0; i < mas.Length; i++) {
                    mas [i] = new int[mas.Length];
                    for (int j = 0; j < mas.Length; j++) {
                        mas[i][j] = rnd.Next(-2, 20);
                    } 
                }
            }
            public static void PrintMas(ref int[][] mas) {
                for (int i = 0; i < mas.Length; i++) {
                    for (int j = 0; j < mas.Length; j++) {
                        Console.Write($"{mas[i][j],3}");
                    }
                    Console.WriteLine();
                }
            }
            public static void CountZeroDiag(ref int[][] mas) {
                int k = 0;
                for (int i = 0; i < mas.Length; i++) {
                    for (int j = 0; j < mas.Length; j++) {
                        if(i == j && mas[i][j] == 0){
                            k++;
                        }
                    }
                }
                Console.Write($"Количество нулевых элементов в главной диагонали {k, 2:d}");
            }
            public static void MinStrPlus(ref int[][] mas) {
                int line = 0;
                for (int i = 0; i < mas.Length; i++) {
                    int k = 0;
                    for (int j = 0; j < mas.Length; j++) {
                        if(mas[i][j] > 0){
                            k++;
                        }
                        if(k == mas.Length){
                            line = i + 1;
                            break;
                        }
                    }
                    if(line > 0){
                        break;
                    }
                }
                Console.Write($"Минимальный номер строки состоящей из положительных элементов {line, 2:d}");
            }
        }
    }

    namespace Vectors {
        public static class ArrMethodsVec
        {
            public static void InputMas(ref int[] mas ) {
                var rnd = new Random();
                for (int i = 0; i < mas.Length; i++)
                    mas[i] = rnd.Next(10, 99);
                
            }
            public static void PrintMas(ref int[] mas ) {
                for (int i = 0; i < mas.Length; i++) {
                    Console.Write($"{mas[i],3}");
                }
            }
        // Другие ваши функции
            
        }
            
        namespace SortMethods {
          
            public static class Sort{
                public static void BubbleSort (ref int[] mas, ref int count){
                    for (int i = 0; i < mas.Length-1; i++){
                        for (int j = mas.Length-2; j >= i; j--) {
                            if (mas[j] > mas[j+1]) {
                                SortUt.Sortutils.MySwap(ref mas[j], ref mas[j+1]);
                            }
                            count++;
                        }
                   }
                }
                public static void SelectionSort(ref int[] mas, ref int count) {
                    int min_idx;
                    for (int i = 0; i < mas.Length-1; i++) {
                        min_idx = i;
                        for (int j = i+1; j < mas.Length; j++) {
                            if (mas[j] < mas[min_idx])
                            min_idx = j;
                            count++;
                        }
                        SortUt.Sortutils.MySwap(ref mas[min_idx], ref mas[i]);
                    }
                }
                public static void InsertionSort(ref int[] mas, ref int count) {
                    for (int i = 1; i < mas.Length; i++) {
                        int key = mas[i];
                        int j = i - 1;
                        while (j >= 0 && mas[j] > key) {
                            mas[j + 1] = mas[j];
                            j = j - 1;
                            count++;
                        
                        }
                        mas[j + 1] = key;
                    }
                }
                public static void InsertionSort_iterationOut(ref int[] mas, ref int count) {
                    for (int i = 1; i < mas.Length; i++) {
                        int key = mas[i];
                        int j = i - 1;
                        while (j >= 0 && mas[j] > key) {
                            mas[j + 1] = mas[j];
                            j = j - 1;
                            count++;
                        }
                        Console.WriteLine();
                        Console.Write($"{i})".PadRight(2));
                        ArrMethodsVec.PrintMas(ref mas);
                        
                        mas[j + 1] = key;
                    }
                    Console.WriteLine();
                }
                public static void myQsort(ref int[] mas, int l, int r, ref int k) {
                    int L = l, R = r;
                    int M = mas[(l + r) / 2];
                    do {
                        k++;
                        while (mas[l] < M) l++;
                        while (mas[r] > M) r--;
                        if (l <= r) {
                            SortUt.Sortutils.MySwap(ref mas[l], ref mas[r]);
                            l++;
                            r--;
                        }
                    } while (l < r);
                    if (L < r) myQsort(ref mas, L, r, ref k);
                    if (l < R) myQsort(ref mas, l, R, ref k);
                }
            }
            
        }
    }   
}
namespace SortUt{
public static class Sortutils{
    public static void MySwap(ref int a, ref int b){
        int temp = a;
            a = b;
            b = temp;
        }
    }
} 
