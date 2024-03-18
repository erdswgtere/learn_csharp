namespace Health_and_Medicine {
    class Health {
        string addres;
        public Health(string addres) {
            this.addres = addres;
        }
        struct Medicine {
            string full_name;
            bool nalichye;
            DateTime srok; //когда истекает срок годности
            int kolichestvo;
            public Medicine(string full_name, bool nalichye, DateTime srok, int kolichestvo) {
                this.full_name = full_name;
                this.nalichye = nalichye;
                this.srok = srok;
                this.kolichestvo = kolichestvo;
            }
            public void Output_ALL() {
                Console.WriteLine($"Полное имя = {full_name}");
                Console.WriteLine($"Должность = {post}");
                Console.WriteLine($"Дата  = {date.ToShortDateString()}");
                Console.WriteLine($"Стаж  = {staz}");
            }
        }

    }
}