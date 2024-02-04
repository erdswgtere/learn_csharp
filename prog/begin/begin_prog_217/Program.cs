/*****************************************************
******************************************************
**                                                  **
**  Программа нахождения перемитра равнобедренной   **
**  трапеции по двум основаниям и высоте            **
**                                                  **
**                                                  ** 
**  Выполнил: студент 2 курса ЕПК гр. И-22          **
**  Синицын Максим                                  ** 
**  Проверил: преподаватель (прог. мод.) Фомин А. Т.**
**                                                  **
******************************************************/
System.Globalization.CultureInfo.CurrentCulture = new System.Globalization.CultureInfo("en-US");
double a1;
double b1;
double h1;
Console.Write("a = ");
string a = Console.ReadLine();
if(double.TryParse(a, out a1)){
    Console.WriteLine($"Converted '{a}' to {a1}.");
    Console.Write("b = ");
    string b = Console.ReadLine();
    if(double.TryParse(b, out b1)){
        Console.WriteLine($"Converted '{b}' to {b1}.");
        Console.Write("h = ");
        string h = Console.ReadLine();
         if(double.TryParse(h, out h1)){
            Console.WriteLine($"Converted '{h}' to {h1}.");
            double k = (a1 - b1) / 2;
            double c = Math.Sqrt(Math.Pow(k, 2) + Math.Pow(h1, 2));
            double res = a1 + b1 + (2 * c);
            Console.WriteLine($"Периметр = {res, 3:f}");
            Console.WriteLine("CurrentCulture is {0}.", System.Globalization.CultureInfo.CurrentCulture.Name);

        }

    }

}
