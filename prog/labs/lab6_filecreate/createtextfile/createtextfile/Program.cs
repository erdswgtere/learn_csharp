using System.Globalization;

namespace createtextfile {
    internal class Program {
        const string inputfile = "Input.txt";
        const string outputfile = "Output.txt";
        static void Main(string[] args) {

            if (File.Exists(inputfile)) {
                Console.WriteLine("Файл {0} уже существует", inputfile);
                Console.ReadLine();
                return;
            }
            StreamWriter sw = File.CreateText(inputfile);
            Console.Write("Введите сколько дат вы хотите ввести: ");
            int n = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < n; i++) {
                Console.Write("Дата(в формате дд/мм/гггг слитно, знак / используется как разделитель): ");
                DateTime dt1 = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                sw.WriteLine(dt1.ToShortDateString());
            }
            sw.Close();

            StreamReader sr = File.OpenText(inputfile);
            StreamWriter sw_out = File.CreateText(outputfile);
            string str_f = sr;
            while (true) {
                string str = sr.ReadLine()!;
                DateTime dt_out = DateTime.ParseExact(str!, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime dt_outf = DateTime.ParseExact(str_f!, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                sw_out.WriteLine(str);
                if (str == null) break;
                Console.WriteLine(str);
            }
            sr.Close();
            sw_out.Close();
        }
    }
}
