using Cords;
class Program
{
    static void Main()
    {
        Point p1 = new (1, 2);
        Point p2 = new (3, 4);

        Console.WriteLine("Point p1: " + p1.X + ", " + p1.Y);
        Console.WriteLine("Point p2: " + p2.X + ", " + p2.Y);

        Point p3 = p1 + p2;
        Console.WriteLine("p1 + p2: " + p3.X + ", " + p3.Y);

        Point p4 = p1 - p2;
        Console.WriteLine("p1 - p2: " + p4.X + ", " + p4.Y);

        Point p5 = p1 * 2;
        Console.WriteLine("p1 * 2: " + p5.X + ", " + p5.Y);

        Console.WriteLine("p1 == p2: " + (p1 == p2));
        Console.WriteLine("p1 != p2: " + (p1 != p2));

        Points points1 = new Points(new List<Point> { new Point(1, 2), new Point(3, 4) });
        Points points2 = new Points(new List<Point> { new Point(1, 2), new Point(3, 4) });

        Console.WriteLine("Points points1 == points2: " + (points1 == points2));
        Console.WriteLine("Points points1 != points2: " + (points1 != points2));

        Points points3 = points1 + new Point(1, 1);
        Console.WriteLine("points1 + (1, 1):");
        foreach (var point in points3.PointList){
            Console.WriteLine(point.X + ", " + point.Y);
        }

    }
}
