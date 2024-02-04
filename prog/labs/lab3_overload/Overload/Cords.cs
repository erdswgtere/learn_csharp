namespace Cords{
    class Point{
        protected internal int X { get; set; }
        protected internal int Y { get; set; }
        public Point(int x, int y){
            X = x;
            Y = y;
        }
        public static Point operator +(Point p1, Point p2){
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

        public static Point operator -(Point p1, Point p2){
            return new Point(p1.X - p2.X, p1.Y - p2.Y);
        }

        public static Point operator *(Point p, int scalar){
            return new Point(p.X * scalar, p.Y * scalar);
        }

        public static bool operator ==(Point p1, Point p2){
            return p1.X == p2.X && p1.Y == p2.Y;
        }

        public static bool operator !=(Point p1, Point p2){
            return !(p1 == p2);
        }
        public override bool Equals(object obj){
        if (obj is Point){
            Point other = (Point)obj;
            return this == other;
        }
        return false;
        }

        public override int GetHashCode(){
            return HashCode.Combine(X, Y);
        }
    }
    class Points{
    protected internal List<Point> PointList { get; }

    public Points(){
        PointList = new List<Point>();
    }

    public Points(List<Point> points){
        PointList = points;
    }


    public static Points operator +(Points points, Point vector){
        List<Point> newPoints = new List<Point>();
        foreach (var point in points.PointList)
        {
            newPoints.Add(point + vector);
        }
        return new Points(newPoints);
    }

    public static Points operator -(Points points, Point vector){
        List<Point> newPoints = new List<Point>();
        foreach (var point in points.PointList)
        {
            newPoints.Add(point - vector);
        }
        return new Points(newPoints);
    }

    public static Points operator *(Points points, int scalar){
        List<Point> newPoints = new List<Point>();
        foreach (var point in points.PointList)
        {
            newPoints.Add(point * scalar);
        }
        return new Points(newPoints);
    }

    public static bool operator ==(Points points1, Points points2){

        if (points1.PointList.Count != points2.PointList.Count)
            return false;

        for (int i = 0; i < points1.PointList.Count; i++){
            if (points1.PointList[i] != points2.PointList[i])
                return false;
        }
        return true;
    }

    public static bool operator !=(Points points1, Points points2){
        return !(points1 == points2);
    }


    public override bool Equals(object obj){
        if (obj is Points){
            Points other = (Points)obj;
            return this == other;
        }
        return false;
    }

    public override int GetHashCode(){
        return PointList.GetHashCode();
    }
 }
 
}