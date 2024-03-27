namespace prr2 {
    class Firma {
        string Name_firm;
        public string name_firm {
            get => Name_firm;
            set => Name_firm = value;
        }

    }
    class Otedl_1 : Firma {
        string Name_otedl;
        int Kol_sotr;
        public string name_otedl {
            get => Name_otedl;

            set => Name_otedl = value;
        }
        public int kol_sotr {
            get => Kol_sotr;
            set {
                if (value < 0) {
                    throw new LaborException("Кол-во сотрудников не может быть отрицательным!");
                }
                else {
                    Kol_sotr = value;
                }
            }
        }
    }
    class Sotr : Otedl_1 {
        string Fullname;
        string Place_in_ierachy;
        int Oklad;
        public string fullname {
            get => Fullname;
            set {
                Fullname = value;
            }
        }
        public string place_in_ierachy {
            get => Place_in_ierachy;
            set => Place_in_ierachy = value;
        }
        public int oklad {
            get => Oklad;
            set {
                if (value < 0) {
                    throw new OkladException("Невозможно создать сотрудника – указан отрицательный оклад ", value);
                }
                else {
                    Oklad = value;
                }
            }
        }
        public double Raschet() {
            return Oklad * 21;
        }
    }
    class Stat_sotr : Sotr {
        int Prem;
       public int prem {
            get => Prem;
            set => Prem = value;
        }
        public double Raschet() {
            double a = oklad * 21 + prem;
            if (prem < 0) {
                throw new PremiyaException("Премия не может быть отрицательна!");
            }
            else {
                return a;
            }
        }
    }

    class PremiyaException : Exception {

        public PremiyaException(string message) : base(message) {

        }
    }
    class OkladException : Exception {

        public OkladException(string message, int oklad) : base(message) {

            Console.WriteLine($"Оклад равен {oklad}");

        }
    }
    class LaborException : Exception {

        public LaborException(string message) : base(message) {
        }
    }
}
