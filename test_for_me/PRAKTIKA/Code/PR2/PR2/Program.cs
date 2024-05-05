using System.Text;

class Program {
    static void Main() {
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        var enc1251 = Encoding.GetEncoding(1251);
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = enc1251;

        Information.Info();
    } 
}

/*
 *  1. Вывести результат в файл
 * 
 *  2. Оформить отчет
 *  
 */
