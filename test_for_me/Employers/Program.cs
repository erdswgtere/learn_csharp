using System.Globalization;

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
    public void Information() {
        Console.WriteLine($"\nСотрудник: {FIO}\nДолжность: {Post}\nДата приема на работу: {Date.ToString("dd.MM.yyyy")}\nСрок действия контракта (лет): {Contract_Term}");
    }
    public void NeedToExtendContract() {
        Date = Date.AddYears(Contract_Term);
        DateTime Date_now = DateTime.Now;
        TimeSpan ExpirationDate = Date_now.Subtract(Date);
        int expdt = ExpirationDate.Days;
        if (expdt <= 5 && expdt > -1) {
            Console.WriteLine($"\nСотрудники, у которых контракт истекает в течение 5 дней: {FIO} ");
        }
    }
    /* (и зачем оно :) )
    public static DateTime inputDate() {
        DateTime date;
        string input;
        do {
            Console.WriteLine("Дата приема на работу (в формате дд/мм/гггг): ");
            input = Console.ReadLine()!;
        }
        while (!DateTime.TryParseExact(input, "dd.MM.yyyy", null, DateTimeStyles.None, out date));
        return date;
    }
    */
}
class Program {
    static void Main() {
        Console.Write("Введите количество сотрудников: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n < 1) {
            Console.WriteLine("Некорректное количество сотрудников!");
            Environment.Exit(0);
        }
        List<Staff> StaffList = new List<Staff>(n);
        for (int i = 0; i < n; i++) {
            Console.Write($"Введите ФИО сотрудника: ");
            string FIO = Console.ReadLine()!;
            Console.Write("Должность: ");
            string Post = Console.ReadLine()!;
            Console.Write("Дата приема на работу (в формате дд/мм/гггг слитно, знак / используется как разделитель): ");
            DateTime Date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Срок действия контракта (лет): ");
            int Contract_Term = Convert.ToInt32(Console.ReadLine());
            Staff staff1 = new(FIO, Post, Date, Contract_Term);
            StaffList.Add(staff1);
            Console.WriteLine();
        }
        Console.WriteLine("\nСотрудники: ");
        foreach (Staff x in StaffList) {
            x.Information();
        }

        Console.WriteLine();

        foreach (Staff x in StaffList) {
            x.NeedToExtendContract();
        }
    }
}