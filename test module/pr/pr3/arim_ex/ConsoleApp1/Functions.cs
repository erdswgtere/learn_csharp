﻿namespace MyFunctions6_21 {
    class Functions {
        double M;
        double N;
        public Functions(ref double M, ref double N) {
            this.M = M;
            this.N = N;
        }
        public double FirstFuction() {
            if (M < 0 || N < 0)
                throw new ArithmeticException("Из отрицательного числа нельзя извлечь корень.");
            if (Math.Sqrt((M * M * M * N) + N * M + M * M - M) == 0)
                throw new DivideByZeroException("В знаменателе получился 0!");
            if (M > double.MaxValue || M < double.MinValue)
                throw new OverflowException("Значение выходит за пределы целевого типа");
            if (N > double.MaxValue || N < double.MinValue)
                throw new OverflowException("Значение выходит за пределы целевого типа");
            double result = ((M - 1) * Math.Sqrt(M) - (N - 1) * Math.Sqrt(N)) / (Math.Sqrt(M * M * M * N) + N * M + Math.Pow(M, 2) - M);
            return result;
        }
        public double SecondFuction() {
            if (M < 0 || N < 0)
                throw new ArithmeticException("Из отрицательного числа нельзя извлечь корень.");
            if (M == 0)
                throw new DivideByZeroException("Знаменатель не может быть равен нулю!");
            if (M > double.MaxValue || M < double.MinValue)
                throw new OverflowException("Значение выходит за пределы целевого типа");
            if (N > double.MaxValue || N < double.MinValue)
                throw new OverflowException("Значение выходит за пределы целевого типа");
            double result = (Math.Sqrt(M) - Math.Sqrt(N)) / M;
            return result;
        }
    }
}
