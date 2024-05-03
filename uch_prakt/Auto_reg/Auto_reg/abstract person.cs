abstract class Person {
    public string FIO { get; set; }
    public string Address { get; set; }
    public string PassportNumber { get; set; }
    public string PassportSeries { get; set; }
    public Person(string FIO, string Address, string PassportNumber, string PassportSeries) {
        this.FIO = FIO;
        this.Address = Address;
        this.PassportNumber = PassportNumber;
        this.PassportSeries = PassportSeries;
    }
}
