abstract class Person {
    public string FIO;
    public string Address;
    public string PassportNumber;
    public string PassportSeries;
    public Person(string FIO, string Address, string PassportNumber, string PassportSeries) {
        this.FIO = FIO;
        this.Address = Address;
        this.PassportNumber = PassportNumber;
        this.PassportSeries = PassportSeries;
    }
}
