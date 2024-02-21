class Triangle {
    protected double A;
    protected double B;
    protected double C;
    protected double S;
    protected Triangle(double a, double b, double c) {
        A = a;
        B = b;
        C = c;
    }
    public void Square() {
        double p = (A + B + C) / 2;
        S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        Console.WriteLine($"Площадь равна {S:f3}");
    }
    public void Display() {
        Console.WriteLine($"Поля треугольника равны: {A:f3}, {B:f3}, {C:f3}");
    }
}

sealed class Triangle_EqualTwoparts : Triangle {

    public Triangle_EqualTwoparts(double a, double b, double c) : base(a, b, c) {

    }
    public void AngleType() {
        if ((A * A == B * B + C * C) || (B * B == A * A + C * C) || (C * C == B * B + A * A)) {
            Console.WriteLine("Треугольник прямоугольный");
        }
        if ((A * A > B * B + C * C) || (B * B > A * A + C * C) || (C * C > B * B + A * A)) {
            Console.WriteLine("Треугольник тупоугольный");
        }
    }
    public new void Display() {
        Console.WriteLine("Треугольник равнобедренный");
        base.Display();
    }
}
sealed class Triangle_EqualAllParts : Triangle {
    public Triangle_EqualAllParts(double a, double b, double c) : base(a, b, c) {

    }
    public new void Display() {
        Console.WriteLine("Треугольник Равносторонний");
        Console.WriteLine("Треугольник Остроугольный");
        base.Display();
    }
}
sealed class Triange_NotEqualParts : Triangle {
    public Triange_NotEqualParts(double a, double b, double c) : base(a, b, c) {

    }
    public void AngleType() {
        if ((A * A == B * B + C * C) || (B * B == A * A + C * C) || (C * C == B * B + A * A)) {
            Console.WriteLine("Треугольник прямоугольный");
        }
        if ((A * A > B * B + C * C) || (B * B > A * A + C * C) || (C * C > B * B + A * A)) {
            Console.WriteLine("Треугольник тупоугольный");
        }
    }
    public new void Display() {
        Console.WriteLine("Треугольник Разносторонний");
        base.Display();
    }
}
