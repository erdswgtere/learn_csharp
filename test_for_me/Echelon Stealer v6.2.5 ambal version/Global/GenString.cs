

using System;

namespace Echelon
{
    internal class GenString
    {
        public static string Generate()
        {
            var abc = "acegikmoqsuwyBDFHJLNPRTVXZ";
            var result = "";
            var rnd = new Random();
            var iter = rnd.Next(0, abc.Length);
            for (var i = 0; i < iter; i++)
                result += abc[rnd.Next(10, abc.Length)];

            return result;
        }

        public static int GeneNumbersTo()
        {
            //Создание объекта для генерации чисел
            var rnd = new Random();

            //Получить случайное число (в диапазоне от 11 до 99)
            var value = rnd.Next(11, 99);

            return value;
        }
    }
}
