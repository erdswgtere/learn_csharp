
internal class Program
{

    private static void Main(string[] args)
    {
        
        Console.WriteLine("Твоё имя?");
        var name = Console.ReadLine;
        var CurrentDate = DateTime.Now;
        Console.WriteLine($"{Environment.NewLine} Hello, {Console.ReadLine()}, today is {CurrentDate}");
        Console.WriteLine($"{Environment.NewLine}Press any key...");
        Console.ReadKey(true);

    }
}
