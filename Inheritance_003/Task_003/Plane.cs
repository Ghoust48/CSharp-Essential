namespace Task_003
{
    public class Plane : Vehicle
    {
        public int Height { get; }
        
        public int PassengerCount { get; }

        public Plane(Point point, float price, float speed, int year, int height, int passengerCount) 
            : base(point, price, speed, year)
        {
            Height = height;
            PassengerCount = passengerCount;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"Высота: {Height}\n" +
                   $"Количество пассажиров: {PassengerCount}\n";
        }
    }
}