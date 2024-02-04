namespace fib{
    public static class Fibre{
        public static int Fib(ref int k){
            int fibfirst=1, fibsecond = 1;
            int fib = 0;
            int i = 0;
            Console.Write($"{fibfirst} ");
            for(i = 0; i < k - 1 ; i++){
                fib = fibsecond + fibfirst;
                fibsecond = fibfirst;
                fibfirst = fib;
                Console.Write($"{fib} ");
            }
            Console.WriteLine();
            Console.Write($"{i+1}-ый член последовательности: ");
            return fib;
        }
    }
}