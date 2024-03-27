namespace prr2 {
    class Firma {
       public string name_firm {
            get => name_firm;
            set => name_firm = value;
        }
       
    }
    class Otedl_1 : Firma {
        public string name_otedl {
            get => name_otedl;

            set => name_otedl = value;
        }
        public int kol_sotr {
            get => kol_sotr;
            set {
                if (value < 0) {
                    throw new LaborException("Кол-во сотрудников не может быть отрицательным!");
                }
                else {
                    kol_sotr = value;
                }
            }
        }
    }
    class Sotr : Otedl_1 {
        public string fullname {
            get => fullname;
        }
        public string place_in_ierachy {
            get => place_in_ierachy;
        }
        public int kazna {
            get => kazna;
            set {
                if (value < 0) {
                    throw new PremiyaException("Зарплата не может быть отрицательной!");
                }
                else {
                    kazna = value;
                }
            }
        }
        public int Raschet() {
            return kazna / kol_sotr;
        }
    }
    class Stat_sotr : Sotr {
        int prem {
            get => prem;
        }
        public int Raschet() {
            return kazna / kol_sotr + prem;
        }
    }
    class PremiyaException : Exception {
        string message;
        public PremiyaException(string message) : base(message) {
            this.message = message;
        }
    }
    class LaborException : Exception {
        string message;
        public LaborException(string message) : base(message) {
            this.message = message;
        }
    }
}
