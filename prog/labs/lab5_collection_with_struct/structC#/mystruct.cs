using System;
using System.Globalization;


namespace Health_and_Medicine {
    class Health {
        Dictionary<string, List<Medicine>> HealthBase;
        
        public struct Medicine {
            string full_name;
            DateTime srok; //когда истекает срок годности
            int kolichestvo;
            public Medicine(string full_name, DateTime srok, int kolichestvo) {
                this.full_name = full_name;
                this.srok = srok;
                this.kolichestvo = kolichestvo;
            }
            void Nalichye_nagladno() {
                if (kolichestvo > 0)
                    Console.WriteLine($"лекарство есть в наличии, его количество равно {kolichestvo}");
                else
                    Console.WriteLine("Данного лекарства нет в наличии!");
            }
            public void Output_ALL() {
                Console.WriteLine($"Полное имя = {full_name}");
                Nalichye_nagladno();
                Console.WriteLine($"Дата = {srok.ToShortDateString()}");
            }
        }
        public Health(Dictionary<string, List<Medicine>> HealthBase) {
            this.HealthBase = HealthBase;
        }
        public void input_in_base(ref int n) {
            for (int i = 0; i < n; i++) {
                Console.Write($"Введите адрес аптеки №{i + 1}: ");
                string apt_adr = Console.ReadLine()!;
                Console.Write($"Введите кол-во лекарств в аптеке №{i + 1}: ");
                int kol = int.Parse(Console.ReadLine()!);
                List<Medicine> medicines = new List<Medicine>();
                for (int j = 0; j < kol; j++) {
                    Console.Write($"Введите название лекарства: ");
                    string name = Console.ReadLine()!;
                    Console.Write("Дата окончания срока годности лекарства (в формате дд/мм/гггг слитно, знак / используется как разделитель): ");
                    DateTime dt1 = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    Console.Write("Кол-во лекарства: ");
                    int kol_onelek = int.Parse(Console.ReadLine()!);
                    Medicine leks = new Medicine(name, dt1, kol_onelek);
                    medicines.Add(leks);
                    Console.WriteLine("#########");
                }
                HealthBase.Add(apt_adr, medicines);
                Console.WriteLine();
                Console.WriteLine();
            }
            
        }

        public void RemoveAptek() {
            Console.WriteLine($"============");
            Console.WriteLine("Введите номер(цифру) аптеки, для удаления аптеки");
            List<string> myKeys = HealthBase.Keys.ToList();
            for (int i = 0; i < HealthBase.Count; i++) {
                Console.WriteLine($"Аптека №{i + 1}, расположенная по адрессу {myKeys[i]} ");
            }
            Console.WriteLine();
            Console.Write("Введите номер: ");
            int num = int.Parse(Console.ReadLine()!);
            bool removedApt = HealthBase.Remove(myKeys[num - 1]);
            if (removedApt) {
                Console.WriteLine("Запись удалена успешно");
                Console.WriteLine("Вывод текущих записей:");
                for (int i = 0; i < HealthBase.Count; i++) {
                    Console.WriteLine($"Аптека №{i + 1}, расположенная по адрессу {myKeys[i]} ");
                }
            }
            else {
                Console.WriteLine("Запись не найдена");
            }
            Console.WriteLine($"============");
        
        }
        public void EditAptek() {
            Console.WriteLine($"============");
            Console.WriteLine("Редактирование записи");
            Console.WriteLine("Введите номер аптеки для редактирования:");
            List<string> myKeys = HealthBase.Keys.ToList();
            for (int i = 0; i < HealthBase.Count; i++) {
                Console.WriteLine($"Аптека №{i + 1}, расположенная по адрессу {myKeys[i]} ");
            }
            Console.WriteLine();
            Console.Write("Введите номер: ");
            int num = int.Parse(Console.ReadLine()!);
            Console.Write($"Введите кол-во лекарств: ");
            int kol = int.Parse(Console.ReadLine()!);
            List<Medicine> medicines = new List<Medicine>();
            for (int j = 0; j < kol; j++) {
                Console.Write($"Введите название лекарства: ");
                string name = Console.ReadLine()!;
                Console.Write("Дата окончания срока годности лекарства (в формате дд/мм/гггг слитно, знак / используется как разделитель): ");
                DateTime dt1 = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Кол-во лекарства: ");
                int kol_onelek = int.Parse(Console.ReadLine()!);
                Medicine leks = new Medicine(name, dt1, kol_onelek);
                medicines.Add(leks);
                Console.WriteLine("#########");
            }
            HealthBase[myKeys[num - 1]] = medicines;
            Console.WriteLine("#########");
            Console.WriteLine($"============");
           
        }
        public void output_from_base() {
            Console.WriteLine($"============");
            Console.WriteLine("Введите номер(цифру) аптеки, для получения информации по ней");
            List<string> myKeys = HealthBase.Keys.ToList();
            Console.WriteLine("СПИСОК ДОСТУПНЫХ АПТЕК:");
            for (int i = 0; i < HealthBase.Count; i++) {
                Console.WriteLine($"Аптека №{i + 1}, расположенная по адрессу {myKeys[i]} ");
            }
            Console.WriteLine();
            Console.Write("Введите номер: ");
            int num = int.Parse(Console.ReadLine()!);
            if (HealthBase.TryGetValue(myKeys[num - 1], out List<Medicine> hlth)) {
                for (int i = 0; i < hlth.Count; i++) {
                    hlth[i].Output_ALL();
                }
            }
            else {
                Console.WriteLine("Информация о лекарствах аптеки не найдена");
            }
            Console.WriteLine($"============");
        }
        public void PrintAll() {
            Console.WriteLine($"============");
            foreach (string key in HealthBase.Keys) {
                Console.WriteLine("##########");
                Console.WriteLine(key);
                foreach (Medicine hlth in HealthBase[key]) { 
                    hlth.Output_ALL();
                }
                Console.WriteLine("##########");
            }
            Console.WriteLine($"============");
        }
    }
}