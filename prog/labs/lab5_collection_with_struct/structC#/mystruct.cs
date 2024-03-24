using System.Globalization;

namespace Health_and_Medicine {
    class Health {
        Dictionary<string, List<Medicine>> HealthBase;
        int n;
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
        public Health(Dictionary<string, List<Medicine>> HealthBase, int n) {
            this.HealthBase = HealthBase;
            this.n = n;
        }
        public void input_in_base() {
            for (int i = 0; i < n; i++) {
                Console.Write($"Введите адрес аптеки №{i + 1}: ");
                string apt = Console.ReadLine()!;
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
                HealthBase.Add(apt, medicines);
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        public void output_from_base() {
            Console.WriteLine($"============");
            Console.WriteLine("Введите номер(цифру) аптеки, для получения информации по ней");
            Console.WriteLine("СПИСОК ДОСТУПНЫХ АПТЕК:");
            for (int i = 0; i < HealthBase.Count; i++) {
                Console.WriteLine($"Аптека №{i + 1} ");
            }
            Console.WriteLine();
            Console.Write("Введите номер: ");
            int num = int.Parse(Console.ReadLine()!);
            List<string> myKeys = HealthBase.Keys.ToList();
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

    }
}