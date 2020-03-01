using System;

namespace Task_004
{
    public class Figure
    {
        private Point[] _points;
        
        public string Type { get; private set; }
        
        public Figure(Point a, Point b, Point c)
        {
            _points = new Point[3];
            _points[0] = a;
            _points[1] = b;
            _points[2] = c;
            Type = "Triangle";
        }
        
        public Figure(Point a, Point b, Point c, Point d)
        {
            _points = new Point[4];
            _points[0] = a;
            _points[1] = b;
            _points[2] = c;
            _points[3] = d;
            Type = "Tetragon";
        }
        
        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            _points = new Point[5];
            _points[0] = a;
            _points[1] = b;
            _points[2] = c;
            _points[3] = d;
            _points[4] = e;
            Type = "Pentagon";
        }

        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow((b.Y - a.Y), 2) + Math.Pow((b.X - a.X), 2));
        }

        public double PerimeterCalculator()
        {
            double sum = 0;
            
            for (var i = 0; i < _points.Length - 1; i++)
            {
                sum += LengthSide(_points[i], _points[i + 1]);
            }
            
            sum += LengthSide(_points[_points.Length - 1], _points[0]);

            return sum;
        }
    }
}