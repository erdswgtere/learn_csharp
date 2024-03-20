namespace Health_and_Medicine {
    class Health {
        string addres;
        public Health(string addres) {
            this.addres = addres;
        }
        public struct Medicine {
            string full_name;
            DateTime srok; //когда истекает срок годности
            int kolichestvo;
            public Medicine(string full_name, bool nalichye, DateTime srok, int kolichestvo) {
                this.full_name = full_name;
                this.srok = srok;
                this.kolichestvo = kolichestvo;
            }
            void Nalichye_nagladno(){
                if (kolichestvo > 0)
                    Console.WriteLine($"лекарство есть в наличии, его количество равно {kolichestvo}");
                else
                    Console.WriteLine("Данного лекарства нет в наличии"); 
            }
            public void Output_ALL() {
                Console.WriteLine($"Полное имя = {full_name}");
                Console.WriteLine($"Наличие данного лекарства = {Nalichye_nagladno}");
                Console.WriteLine($"Дата  = {srok.ToShortDateString()}");
                Console.WriteLine($"Кол-во препаратов  = {kolichestvo}");
            }
        }

    }
}