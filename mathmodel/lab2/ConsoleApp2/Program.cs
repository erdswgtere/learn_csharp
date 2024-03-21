using dislin_my;
using random_generators;
namespace Mult_RND_test {
    class Program {
        // Количество случайных чисел (размер массива values)
        const int _N = 1500;
        // Параметр мультипликативного датчика
        static int _A; // Модуль 
        static int _Mm;
        // Случайное число
        static int _Y;
        // Число интервалов разбиения
        static int _K;
        /// <summary> Генератор случайных чисел
        /// </summary> 
        /// <returns> Случайное значение </returns> 

        /// <summary> формировать набор данных 
        /// </summary> 
        /// <param name = "parValues"> Mассив случайных
        /// чисел </param>
        static void GenerateData(out double[] parValues) {
            parValues = new double[_N];
            Normal_gen nrmlgen = new Normal_gen(_N, _K);
            // получение случайных чисел
            for (int i = 0; i < _N; i++)
                parValues[i] = nrmlgen.Normal(3,1); //для примера вставлен комбинированный генератор
        }
        /// <summary> Получить массивы оценок для плотности и функции
        /// pаспределения </summary>
        /// <param name = "parValues"> Массив случайных чисел </param>
        /// <param name = "parDataPlot"> Mассив частот </param>
        /// <pаram name = "parDataFunc"> Mассив функции распределения </param>
        /// <param name = "parMin"> Левая граница интервала </param>
        /// <param name = "parMax"> Правая граница интервала </param> 
        static void MakeData(double[] parValues, out double[] parDataPlot, out double[] parDataFunc, double parMin, double parMax) {
            double delta = (parMax - parMin) / _K;
            parDataPlot = new double[_K];
            parDataFunc = new double[_K];
            for (int i = 0; i < _N; i++) {
                int j = (int)((parValues[i] - parMin) / delta);
                if (j >= _K) j = _K - 1;
                else if (j < 0) j = 0;
                parDataPlot[j]++;
            }
            for (int i = 0; i < _K; i++)
                parDataPlot[i] /= _N;
            parDataFunc[0] = parDataPlot[0];
            for (int i = 1; i < _K; i++)
                parDataFunc[i] = parDataFunc[i - 1] + parDataPlot[i];
            Console.WriteLine($"Кол-во элементов {parValues.Length}");
        }
        /* static void MakeTheoryData(out double pt) {
            int m = 3;
            int d = 1;
            double a = 0.05;
            double[] parValuestest = new double[_K];
            Normal_gen nrmlgentest = new Normal_gen(_N, _K);
            parValuestest[i] = nrmlgentest.Normal(3, 1);
            for (int i = 0; i < _K; i++) {
                if (parValuestest[i] > 1.0 && parValuestest[i] < 5.0) {

                }
            }
        } */
        /// <summary> Получить статистические оценки</summary> 
        /// <param name = "parValues"> Случайные числа
        /// <param name = "parMx"> Mатематическое ожидание</param>
        /// <раrаm пame = "раrS2"> Исправленная выборочная дисперсия </раrаm>
        static void Estimate(double[] parValues, out double parMx, out double parS2) {
            double m2 = 0;
            parMx = 0;
            for (int i = 0; i < _N; i++) {
                parMx += parValues[i];
                m2 += parValues[i] * parValues[i];
            }
            parMx /= _N;
            m2 /= _N;
            parS2 = (m2 - parMx * parMx) * _N / (_N - 1);
            Console.WriteLine($"мат. ожидание = {parMx}, дисперсия = {parS2}");
        }
       static double xi2(double[] hst, double[] pt, int k, long n) {
            double xi = 0.0;
            for (int i = 0; i < k; i++)
                xi += Math.Pow(hst[i] - n * pt[i], 2) / (n * pt[i]);
            return xi;
        }
        /// <summary> Основная программа </summary>
        /// <param name = "args"> Аргументы </param> 
        static void Main(string[] args) {
            double[] values, dataPlot, dataFunc;
            _Mm = 4096;
            _A = 5;
            _Y = _Mm - 5;
            _K = 15; // размер массива частот
            GenerateData(out values);
            MakeData(values, out dataPlot, out dataFunc, 1.0, 4.8);
            for (int i = 0; i < 15; i++) {
                Console.WriteLine($"{(dataPlot[i])} ");
            }
            Console.WriteLine($"Размерность {dataPlot.Length}");
            Console.WriteLine();
            for (int i = 0; i < 15; i++) {
                Console.WriteLine($"{values[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < 15; i++) {
                Console.WriteLine($"{dataFunc[i]} ");
            }
            //... построение гистограммы частот и 
            // статистической функции распределения

            Dislin_my dismy = new Dislin_my(ref dataPlot, ref values, ref dataFunc);
            dismy.Diag_for_datafunc();

            Estimate(values, out double mx, out double dx);
            Console.WriteLine();
            

            // обработка статистических параметров

        }
    }
}




//MakeData(values, out dataPlot, out dataFunc, -2.5, 2.0);
//MakeData(values, out dataPlot, out dataFunc, 1.0, 4.8);