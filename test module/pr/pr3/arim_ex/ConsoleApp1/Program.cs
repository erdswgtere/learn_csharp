using MyFunctions6_21;
namespace ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
           while (true) {
                try {
                    Console.Write("Введите значение m для функций: ");
                    double M = double.Parse(Console.ReadLine()!);
                    Console.Write("Введите значение n для функций: ");
                    double N = double.Parse(Console.ReadLine()!);
                    Functions functions = new Functions(ref M, ref N);
                    Console.WriteLine($"Значение первой функции равно {functions.FirstFuction()}");
                    Console.WriteLine($"Значение второй функции равно {functions.SecondFuction()}");
                    break;
                }
                catch (FormatException) {
                    Console.WriteLine("Введено некорректное значение;");
                }
                catch(ArithmeticException ex) {
                    switch (ex.InnerException) {
                        case DivideByZeroException inDex:
                            Console.WriteLine(inDex.Message);
                            break;
                        case OverflowException ovEx:
                            Console.WriteLine(ovEx.Message);
                            break;
                    }
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
           }
        }
    }
}
