using static System.Console;
class Soldier : Person
{
    char validityCategory;
    string? militaryBranch;
    public char ValidityCategory { get => validityCategory; set => validityCategory = value; }
    public string? MilitaryBranch { get => militaryBranch; set => militaryBranch = value; }
    public Soldier(string FIO, char ValidityCategory, string MilitaryBranch, 
         string Address, string PassportNumber, 
        string PassportSeries) : base(FIO, 
        Address, PassportNumber, PassportSeries)
    {
        this.FIO = FIO;
        this.ValidityCategory = ValidityCategory;
        this.MilitaryBranch = MilitaryBranch;
        this.Address = Address;
        this.PassportNumber = PassportNumber;
        this.PassportSeries = PassportSeries;
    }
}