namespace Task_003
{
    public class Ship : Vehicle
    {
        public int PassengerCount { get; }
        
        public string HomePort { get; }


        public Ship(Point point, float price, float speed, int year, int passengerCount, string homePort) 
            : base(point, price, speed, year)
        {
            PassengerCount = passengerCount;
            HomePort = homePort;
        }
        
        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"Порт приписки: {HomePort}\n" +
                   $"Количество пассажиров: {PassengerCount}\n";
        }
    }
}