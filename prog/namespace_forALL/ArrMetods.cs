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
                        mas[i][j] = rnd.Next(10, 99);
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
            // Другие ваши функции
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
