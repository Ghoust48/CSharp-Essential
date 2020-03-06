namespace Task_003
{
    public class Vehicle
    {
        private Point _point;
        
        public float Price { get; }
        
        public float Speed { get; }
        
        public int Year { get; }

        public Vehicle(Point point)
        {
            _point = point;
        }

        public Vehicle(Point point, float price) : this(point)
        {
            Price = price;
        }
        
        public Vehicle(Point point, float price, float speed) : this(point, price)
        {
            Speed = speed;
        }
        
        public Vehicle(Point point, float price, float speed, int year) : this(point, price, speed)
        {
            Year = year;
        }

        public override string ToString()
        {
            return $"Координаты: {_point.X}\t{_point.Y}\n" +
                   $"Стоимость: {Price}\n" +
                   $"Скорость: {Speed}\n" +
                   $"Год выпуска: {Year}\n";
        }
    }
}