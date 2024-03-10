/*****************************************************
******************************************************
**                                                  **
** Array74. Дан массив размера N.                   **
** Обнулить элементы массива, расположенные         **
** между его минимальным                            **
** и максимальным элементами                        **
** (не включая минимальный и максимальный элементы) **
**                                                  ** 
**  Выполнил: студент 2 курса ЕПК гр. И-22          **
**  Синицын Максим                                  ** 
**  Проверил: преподаватель (прог. мод.) Фомин А. Т.**
**                                                  **
******************************************************
*****************************************************/
using MyColletions;
namespace array74_21_ {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Введит кол-во элементов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите границы отрезка для генерации чисел");
            Console.Write("Введит левую границу: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введит правую границу: ");
            int y = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>(n);
            MyColletionList.InputMas(ref list, ref x, ref y);
            MyColletionList.PrintMasL(ref list);
            Console.WriteLine();
            MyColletionList.array74(ref list);
        }
    }
}
