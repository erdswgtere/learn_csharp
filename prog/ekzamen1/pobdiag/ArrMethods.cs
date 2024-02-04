
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
        }
    }


