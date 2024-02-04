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

        }
    }   
}
