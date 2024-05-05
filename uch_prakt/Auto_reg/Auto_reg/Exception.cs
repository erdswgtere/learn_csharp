class RegException : Exception {
    public RegException(string message) : base(message) {
    
    }
}
class Checkings {
    public bool Quantity(int x) {
        bool check = true;
        if (x < 1) check = false;
        return check;
    }
    public bool FIO(string FIO) {
        bool check = true;
        if (FIO == null || FIO.Length < 1) check = false;
        return check;
    }
    public bool ValidityCategory(char VC) {
        bool check = false;
        if (char.IsSymbol(VC)) check = true;
        return check;
    }
    public bool MilitaryBranch(string MB) {
        bool check = true;
        if (MB == null || MB.Length < 1) check = false;
        return check;
    }
    public bool Address(string Addr) {
        bool check = true;
        if (Addr == null || Addr.Length < 1) check = false;
        return check;
    }
    public bool PassportNumber(string PassNum) {
        bool check = true;
        if (PassNum.Length != 4) check = false;
        return check;
    }
    public bool PassportSeries(string PassSer) {
        bool check = true;
        if (PassSer.Length != 6) check = false;
        return check;
    }
}