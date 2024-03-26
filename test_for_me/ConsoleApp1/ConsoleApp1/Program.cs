namespace ConsoleApp1 {
    class MyException : Exception {

        private int detail;
        public MyException(int a) {
            detail = a;
        }
        public string toString() {
            return "MyException!" + detail;
        }
    }
    class MultiNest {
        static void procedure() {
            try {
                int[] c = { 1 };
                c[42] = 99;
            }
            catch (IndexOutOfRangeException e) {
                Console.WriteLine("array index oob: " + e);
            }
        }
        public static void main(string[] args) {
            try {
                int a = args.Length;
                Console.WriteLine("a = " + a);
                int b = 42 / a;
                procedure();
            }
            catch (ArithmeticException e) {
                Console.WriteLine("div by 0: " + e);
            }
        }
    }
    class ExceptionDemo {
        static void compute(int a) {
            Console.WriteLine("Вызван compute(" + a + ")");
            if (a > 10)
                throw new MyException(a);
            Console.WriteLine("Нормальное завершение");
        }
        static void Main(string[] args) {
            try {
                compute(1);
                compute(20);
            }
            catch (MyException e) {
                Console.WriteLine("Перехвачено " + e);
            }
        }
    }
}
