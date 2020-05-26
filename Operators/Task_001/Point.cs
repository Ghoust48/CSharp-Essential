namespace Task_001
{
    public class Point
    {
        private int _x;
        
        private int _y;
        
        private int _z;

        public Point(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1._x + p2._x, p1._y + p2._y, p1._z + p2._z);
        }

        public override string ToString()
        {
            return $"[{_x}, {_y}, {_z}]";
        }
    }
}