/*****************************************************
******************************************************
**  c.117 Структуры, базовый уровень, №21           **
**                                                  **
**  Определить товар, количество                    **
**  которого больше всего на складе, и              **
**  напечатать все сведения о нем.                  **
**                                                  **
**  ПОЛЯ СТРУКТУРЫ:                                 **
**  Количествo                                      **
**  Цена                                            **
**  Год изготовления                                **
**  Производитель                                   **
**                                                  ** 
**  Выполнил: студент 2 курса ЕПК гр. И-22          **
**  Синицын Максим                                  ** 
**  Проверил: преподаватель (прог. мод.) Фомин А. Т.**
**                                                  **
******************************************************
*****************************************************/
using My_solution21;
namespace ConsoleApp2 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("ПРОГРАММА ПРОВЕРКИ ТОВАРА НА СКЛАДЕ");
            Console.Write("Введите кол-во разнообразных товаров: ");
            int n = int.Parse(Console.ReadLine()!);
            Dictionary<int, Structure_and_methods.Good> Good_Base = new Dictionary<int, Structure_and_methods.Good>(n);
            Structure_and_methods sol = new Structure_and_methods(Good_Base);
            sol.input_in_base(ref n);
            sol.output_needvalues();
        }
    }
}
