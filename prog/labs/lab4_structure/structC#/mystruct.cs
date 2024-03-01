namespace mystruct{
    struct Labor{
        string full_name;
        string post;
        string date;
        int staz;
        Labor(string full_name, string post, string date, int staz){
            this.full_name = full_name;
            this.post = post;
            this.date = date;
            this.staz = staz;
        }
        void Output() {
            Console.WriteLine($"полное имя = {full_name}");
            Console.WriteLine($"Должность = {post}");
            Console.WriteLine($"Дата  = {date}");
            Console.WriteLine($"Стаж  = {staz}");
        }
    }
}