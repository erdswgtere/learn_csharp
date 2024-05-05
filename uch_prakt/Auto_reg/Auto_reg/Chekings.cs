static class Checkings{
    public static void NumroomCheck(int RoomNum) {
        if (RoomNum < 1 && RoomNum > 658) throw new RegException("Неправильно введен номер комнаты!");
    }
    public static void FIOCheck(string FIO) {
        if (FIO == null || FIO.Length < 1) throw new RegException("Неправильно введена фамилия!");
    }
    public static void AddressCheck(string Addr) {
        if (Addr == null || Addr.Length < 1) throw new RegException("Неправильно введен адрес!");
    }
    public static void PassportNumberCheck(string PassNum) {
        if (PassNum.Length != 6) throw new RegException("Неправильно введен номер паспорта!");
    }
    public static void PassportSeriesCheck(string PassSer) {
        if (PassSer.Length != 4) throw new RegException("Неправильно введена серия паспорта!");
    }
}