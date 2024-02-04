namespace MyNamespace
{
    namespace Matrices{
        public static class ArrMethodsMat
        {
            public static void InputMas(ref int[][] mas, int x) {
                var rnd = new Random();
                for (int i = 0; i < x; i++) {
                    mas [i] = new int[x];
                    for (int j = 0; j < x; j++) {
                        mas[i][j] = rnd.Next(0, 2);
                    } 
                }
            }
            public static void PrintMas(ref int[][] mas, int x) {
                for (int i = 0; i < x; i++) {
                    for (int j = 0; j < x; j++) {
                        Console.Write($"{mas[i][j],3}");
                    }
                    Console.WriteLine();
                }
            }
            public static void CountZeroDiag(ref int[][] mas, int x) {
                int k = 1;
                for (int i = 0; i < x; i++) {
                    for (int j = 0; j < x; j++) {
                        if(i + j + 1 = n && mas[i][j] < 10){
                            k *= ;
                        }
                    }
                }
                Console.Write($"Количество нулевых элементов в главной диагонали {k, 2:d}");
            }
        }
    }

    namespace Vectors {
        public static class ArrMethodsVec
        {
            public static void InputMas(ref int[] mas, int x) {
                var rnd = new Random();
                for (int i = 0; i < x; i++)
                    mas[i] = rnd.Next(10, 99);
                
            }
            public static void PrintMas(ref int[] mas, int x) {
                for (int i = 0; i < x; i++) {
                    Console.Write($"{mas[i],3}");
                }
            }
        // Другие ваши функции
            
        }
            
        namespace SortMethods {

        }
    }   
}
