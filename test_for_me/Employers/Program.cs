using System.Globalization;
using static System.Console;
using static System.Convert;
using static System.DateTime;
using static System.Globalization.CultureInfo;
using static System.Environment;
struct Staff {
    private string FIO; // ФИО
    private string Post; // должность
    private int Contract_Term; // срок действия контракта (лет)
    private DateTime Date;
    public Staff(string FIO, string Post, DateTime Date, int Contract_Term){
        this.FIO = FIO;
        this.Post = Post;
        this.Contract_Term = Contract_Term;
        this.Date = Date;
        }
    public void Information() {
        DateTime Date = new();
        Write($"\nСотрудник: {FIO}\nДолжность: {Post}\nДата приема на работу: {Date.ToString("dd.MM.yyyy")}\nСрок действия контракта (лет): {Contract_Term}");
    }
    public void NeedToExtendContract() {
        int ExpirationDate = (Now - Date).Days;
        if (ExpirationDate <= 5) {
            WriteLine($"\nСотрудники, у которых контракт истекает в течение 5 дней: {FIO} ");
        }
    }
    public static DateTime inputDate() {
        DateTime date;
        string input;
        do {
            WriteLine("Дата приема на работу (в формате дд/мм/гггг): ");
            input = ReadLine()!;
        }
        while (!TryParseExact(input, "dd.MM.yyyy", null, DateTimeStyles.None, out date));
        return date;
    }
}
class Program {
    static void Main() {
        List<Staff> StaffList = [];
        Write("Введите количество сотрудников: ");
        int n = ToInt32(ReadLine());
        if (n <= 1) {
            WriteLine("Некорректное количество сотрудников!");
            Exit(0);
        }
        for (int i = 1; i < n; ++i) {
            DateTime Date = new();
            Write($"Введите ФИО сотрудника: ");
            string FIO = ReadLine()!;
            Write("Должность: ");
            string Post = ReadLine()!;
            DateTime Date = Staff.inputDate();
            Write("Срок действия контракта (лет): ");
            int Contract_Term = ToInt32(ReadLine());
            WriteLine();
            DateTime Now = DateTime.Now;
            int ExpirationDate = (Now - Date).Days;
            Staff staff1 = new(FIO, Post, Date, Contract_Term);
            StaffList.Add(staff1);
        }
        WriteLine("\nСотрудники: ");
        foreach (Staff x in StaffList) {
            x.Information();
        }

        WriteLine();

        foreach (Staff x in StaffList) {
            x.NeedToExtendContract();
            }
        }
    }