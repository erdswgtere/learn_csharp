class Client : Person {
    public int Number_of_room { get; set; }
    bool room_has_given;
    public bool Room_has_given {
        get => room_has_given;
        set => room_has_given = value;
    }
    public Client(string FIO, string Address, string PassportNumber,string PassportSeries, int number_of_room) : base(FIO,
        Address, PassportNumber, PassportSeries) {

        this.FIO = FIO;
        this.Address = Address;
        this.PassportNumber = PassportNumber;
        this.PassportSeries = PassportSeries;
        Number_of_room = number_of_room;
    }
}

