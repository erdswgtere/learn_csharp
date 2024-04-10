using System.Globalization;

namespace createtextfile {
    internal class Program {
        const string inputfile = "Input";
        const string outputfile = "Output";
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
                Console.Write("Дата(в формате дд.мм.гггг слитно, знак . используется как разделитель): ");
                DateTime dt1 = DateTime.ParseExact(Console.ReadLine()!, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                sw.WriteLine(dt1.ToShortDateString());
            }
            sw.Close();

            StreamReader sr = File.OpenText(inputfile);
            string str_f = sr.ReadLine()!;
            DateTime dt_outf = DateTime.ParseExact(str_f, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            while (true) {
                string str = sr.ReadLine()!;
                if(str!= null) {
                    DateTime dt_out = DateTime.ParseExact(str, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    if (dt_out > dt_outf) {
                        dt_outf = dt_out;
                    }
                }
                if (str == null) break;
                
            }
            sr.Close();
            StreamWriter sw_out = File.CreateText(outputfile);
            Console.WriteLine(dt_outf.ToShortDateString());
            sw_out.WriteLine(dt_outf.ToShortDateString());
            sw_out.Close();
        }
    }
}
