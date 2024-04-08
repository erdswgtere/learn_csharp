using System.Globalization;

namespace My_solution21 {
    class Structure_and_methods {
        Dictionary<int, Good> GoodBase;
        public struct Good {
            string proizvoditel;
            DateTime year_of_make;
            int kolichestvo;
            int price;
            public Good(string proizvoditel, DateTime year_of_make, int kolichestvo, int price) {
                this.proizvoditel = proizvoditel;
                this.year_of_make = year_of_make;
                this.kolichestvo = kolichestvo;
                this.price = price;
            }
            public int Kolichestvo {
                get => kolichestvo;
            }
            public void Output_All() {
                Console.WriteLine($"Производитель: {proizvoditel}");
                Console.WriteLine($"Дата изготовление: {year_of_make.ToShortDateString()}");
                Console.WriteLine($"Количество: {kolichestvo}");
                Console.WriteLine($"Цена: {price}");
            }
        }
        public Structure_and_methods(Dictionary<int, Good> GoodBase) {
            this.GoodBase = GoodBase;
        }
        public void input_in_base(ref int n) {
            for (int i = 0; i < n; i++) {
                Console.Write("Введите id товара: ");
                int ID = int.Parse(Console.ReadLine()!);
                Console.WriteLine($"Введите данные для товара {ID}: ");
                Console.Write($"Введите производителя товара: ");
                string proizvod = Console.ReadLine()!;
                Console.Write("Дата изготовления товара (в формате дд/мм/гггг слитно, знак / используется как разделитель): ");
                DateTime dt1 = DateTime.ParseExact(Console.ReadLine()!, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Кол-во товара: ");
                int kolic = int.Parse(Console.ReadLine()!);
                Console.Write("Кол-во цену товара: ");
                int price = int.Parse(Console.ReadLine()!);
                Good tovar = new Good(proizvod, dt1, kolic, price);
                GoodBase.Add(ID, tovar);
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        public void output_keys() {
            List<int> myKeys = GoodBase.Keys.ToList();
            foreach (int key in myKeys) {
                Console.WriteLine(key);
            }
        }
        public void output_needvalues() {
            List<int> myKeys = GoodBase.Keys.ToList();
            for(int i = 0; i < myKeys.Count; i++) {
                if (GoodBase[myKeys[i]].Kolichestvo < GoodBase[myKeys[i++]].Kolichestvo) {
                    continue;
                }
                else {
                    GoodBase.TryGetValue(myKeys[i], out Good gd);
                    gd.Output_All();
                }
            }
        }
    }
}
