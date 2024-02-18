namespace ConsoleApp1 {
    internal class Program {
        static void Main() {
            double a, b, c;
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            switch (a) {
                case 0:
                    Console.WriteLine("Некорректный ввод");
                    Environment.Exit(0);
                    break;
            }
            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());
            switch (b) {
                case 0:
                    Console.WriteLine("Некорректный ввод");
                    Environment.Exit(0);
                    break;
            }
            Console.Write("c = ");
            c = Convert.ToDouble(Console.ReadLine());
            switch (c) {
                case 0:
                    Console.WriteLine("Некорректный ввод");
                    Environment.Exit(0);
                    break;
            }
            if ((a != b && a != c && b != c) && (a + b > c && a + c > b && b + c > a)) {
                Triange_NotEqualParts trNotEq = new(a, b, c);
                trNotEq.Square();
                trNotEq.Display();
                trNotEq.AngleType();
            }
            else if ((a == b && a == c && b == c) && (a + b > c && a + c > b && b + c > a)) {
                Triangle_EqualAllParts trAll = new(a, b, c);
                trAll.Square();
                trAll.Display();
            }
            else if ((a == b || a == c || b == c) && (a + b > c && a + c > b && b + c > a)) {
                Triangle_EqualTwoparts trTwo = new(a, b, c);
                trTwo.Square();
                trTwo.Display();
                trTwo.AngleType();
            }
            else {
                Console.WriteLine("Длина стороны больше суммы других сторон либо равна ей");
            }
            Console.ReadKey();
        }
    }
}
