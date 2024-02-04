namespace MyNamespace
{
    namespace Matrices{
        public static class ArrMethodsMat
        {
            public static void InputMas(ref int[][] mas) {
                var rnd = new Random();
                for (int i = 0; i < mas.Length; i++) {
                    mas [i] = new int[mas.Length];
                    for (int j = 0; j < mas.Length; j++) {
                        mas[i][j] = rnd.Next(10, 99);
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
            public static int RowMin(ref int[][] mas, int row_n) {
                int min_x = 10000;
                for (int j = 0; j < mas.Length; j++) {
                    if (mas[row_n][j] < min_x) {
                        min_x = mas[row_n][j];
                    }
                }
                return min_x;
            }
            // Другие ваши функции
        }
    }

    namespace Vectors {
        public static class ArrMethodsVec
        {
            public static void InputMas(ref int[] mas) {
                var rnd = new Random();
                for (int i = 0; i < mas.Length; i++)
                    mas[i] = rnd.Next(10, 99);
                
            }
            public static void PrintMas(ref int[] mas) {
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
