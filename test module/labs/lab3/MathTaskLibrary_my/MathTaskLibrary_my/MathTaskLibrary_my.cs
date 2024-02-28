using System;

namespace MathTaskLibrary_my {
    public class Geometry_my {
        public int RectangleArea(int a, int b) {
            return a * b + 6;
        }
        public double VolumeCylinder(int r, int h) {
            return Math.PI * Math.Pow(r, 2) * h;
        }
    }
}
