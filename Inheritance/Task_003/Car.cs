namespace Task_003
{
    public class Car : Vehicle
    {
        public Car(Point point) : base(point)
        {
        }

        public Car(Point point, float price) : base(point, price)
        {
        }

        public Car(Point point, float price, float speed) : base(point, price, speed)
        {
        }

        public Car(Point point, float price, float speed, int year) : base(point, price, speed, year)
        {
        }
    }
}