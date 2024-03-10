/*****************************************************
******************************************************
**  п. 7.1 "средний уровень" стр. 109               **
**  21.Введите массив символов из 14 элементов,     **
**  содержащий пробелы. Найдите самое длинное слово,**
**  выведите на экран это слово и его длину.        **
**                                                  **
**                                                  ** 
**  Выполнил: студент 2 курса ЕПК гр. И-22          **
**  Синицын Максим                                  ** 
**  Проверил: преподаватель (прог. мод.) Фомин А. Т.**
**                                                  **
******************************************************
*****************************************************/
namespace var21.p7._1 {
    internal class Program {
        static void Main(string[] args) {
            char[] symb = new char[14];
            for (int i = 0; i < symb.Length; i++) {
                Console.Write($"Введите 14 символов(текущий символ для ввода {i + 1}): ");
                char c = Convert.ToChar(Console.ReadLine());
                symb[i] = c;
                Console.Clear();
            }
            string text = string.Concat(symb);

            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); //чтобы не засчитывать лишние пробелы из ввода в длину слова
            int length = 0;
            for (int i = 0;i < words.Length;i++) {
                if (words[i].Length > length) {
                    length = words[i].Length;
                }
            }
            Console.WriteLine("Все слова: ");
            foreach (string s in words) {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Console.WriteLine("Самое большое слово: ");
            foreach(string best_word in words) {
                if(best_word.Length == length) {
                    Console.WriteLine(best_word);
                }
            }
            Console.WriteLine($"Кол-во символов в самом большом слове: {length}");
        }
    }
}
