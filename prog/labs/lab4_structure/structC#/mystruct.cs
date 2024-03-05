namespace mystruct {
    struct Labor {
        string full_name;
        string post;
        DateTime date;
        int staz;
        public Labor(string full_name, string post, DateTime date, int staz) {
            this.full_name = full_name;
            this.post = post;
            this.date = date;
            this.staz = staz;
        }
        public void Output_ALL() {
            Console.WriteLine($"Полное имя = {full_name}");
            Console.WriteLine($"Должность = {post}");
            Console.WriteLine($"Дата  = {date.ToShortDateString()}");
            Console.WriteLine($"Стаж  = {staz}");
        }
        public void Output() {
            if (staz > 10) {
                Console.WriteLine($"Полное имя = {full_name}");
                Console.WriteLine($"Должность = {post}");
                Console.WriteLine($"Дата  = {date.ToShortDateString()}");
                Console.WriteLine($"Стаж  = {staz}");
            }
        }
    }
}