namespace Health_and_Medicine;

internal class Program {
    private static void Main(string[] args) {
        Console.Write("Введите кол-во аптек: ");
        int n = int.Parse(Console.ReadLine()!);
        Dictionary<string, List<Health.Medicine>> Health_Base = new Dictionary<string, List<Health.Medicine>>(n);
        Health hlt = new Health(Health_Base, n);
        hlt.input_in_base();
        hlt.output_from_base();
    }
}