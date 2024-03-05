using System.Globalization;
using static System.Console;
using static System.Convert;
using static System.DateTime;

struct Staff {
    private string FIO; // ФИО
    private string Post; // должность
    private int Contract_Term; // срок действия контракта (лет)
    private DateTime Date;
    public Staff(string FIO, string Post, DateTime Date, int Contract_Term) {
        this.FIO = FIO;
        this.Post = Post;
        this.Contract_Term = Contract_Term;
        this.Date = Date;
    }
    public void Contract_Expiration() {
        DateTime dtn = DateTime.Now;
        DateTime Expiration = Date;
    }
    public void Information() {
        DateTime Date = new DateTime();
        Write($"Сотрудник: {FIO}\nДолжность: {Post}\nДата приема на работу: {Date.ToString("dd/MM/yyyy")}\nСрок действия контракта (лет): {Contract_Term}");
    }
}
class Program {
    static void Main() {
        List<Staff> StaffList = new List<Staff>();
        Write("Введите количество сотрудников: ");
        int n = ToInt32(ReadLine());
        DateTime Date = new DateTime();

        for (int i = 1; i < n; ++i) {
            WriteLine($"Введите ФИО сотрудника: ");
            string FIO = ReadLine()!;
            Write("Должность: ");
            string Post = ReadLine()!;
            Write("Дата приема на работу (в формате дд/мм/гггг слитно): ");
            Date = ParseExact(ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Write("Срок действия контракта (лет): ");
            int Contract_Term = ToInt32(ReadLine());
            Staff staff1 = new Staff(FIO, Post, Date, Contract_Term);
            StaffList.Add(staff1);
        }
        WriteLine("\nСотрудники: ");
        foreach (Staff x in StaffList) {
            x.Information();
        }

    }
}