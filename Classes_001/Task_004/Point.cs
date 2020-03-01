namespace Task_004
{
    public class Point
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public string Name { get; private set; }

        public Point(int x, int y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }
    }
}