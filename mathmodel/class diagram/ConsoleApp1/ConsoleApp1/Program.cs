namespace variant21
{
    class Vehicle
    {
        double cost;
        int speed; 
        int year_of_construction;
        public Vehicle(double cost, int speed, int year_of_construction)
        {
            this.cost = cost;
            this.speed = speed;
            this.year_of_construction = year_of_construction;
        }
        public void Display()
        {
            Console.WriteLine("\tстоимость (млн. руб.): " + cost.ToString());
            Console.WriteLine("\tТекущая скорость (км/ч): " + speed.ToString());
            Console.WriteLine("\tгод выпуска: " + year_of_construction.ToString());
        }
        public void Increase_speed()
        {
            const int INC = 10;
            speed += INC;
        }
}
    sealed class Truck: Vehicle
    {
        int capacity;
        string mark;
        public Truck(double cost, int speed, int year_of_construction, int capacity, string mark): base(cost, speed, year_of_construction)
        {
            this.capacity = capacity;
            this.mark = mark;
        }
        public new void Display()
        {
            Console.WriteLine("\tВместимость в тоннах: " + capacity.ToString());
            Console.WriteLine("\tМарка грузовика: " + mark);
            base.Display();
        }
    }
    class Automobile : Vehicle
    {
        string Kuzov_type;
        string mark_auto;
        public Automobile(double cost, int speed, int year_of_construction, string mark, string Kuzov_type): base(cost, speed, year_of_construction)
        {
            this.Kuzov_type = Kuzov_type;
            mark_auto = mark;
        }
        public new void Display()
        {
            Console.WriteLine("\tТип кузова: " + Kuzov_type);
            Console.WriteLine("\tМарка авто: " + mark_auto);
            base.Display();
        }
    }
    sealed class light_auto : Automobile
    {
        int power;
        public light_auto(double cost, int speed, int year_of_construction, string mark, string Kuzov_type, int power): base(cost, speed, year_of_construction, mark, Kuzov_type)
        {
            this.power = power;
        }
        public new void Display()
        {
            Console.WriteLine("\tМощность: " + power.ToString());
            base.Display();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Иерархия классов: Грузовик, автомобиль, легковое авто, транспорт";

            Truck tr = new(20000, 20, 2005, 500, "Kamaz");
            Console.WriteLine("Вывод информации о грузовике");
            tr.Display();

            Automobile au = new(40000, 60, 2005, "BMW", "Седан");
            Console.WriteLine("Вывод информации о автомобиле");
            au.Display();

            light_auto lgt = new(20000, 20, 2005, "Matiz", "-", 55);
            Console.WriteLine("Вывод информации о лёгком авто");
            lgt.Display();
        }
    }
}