using System;
using System.Threading.Channels;

namespace Task_003
{
    class Program
    {
        static void Main(string[] args)
        {
            var plane = new Plane(new Point(1, 2), 10000f, 320, 
                2001, 300, 20);
            
            var car = new Car(new Point(1, 4), 55000f, 220, 2010);
            
            var ship = new Ship(new Point(4, 100), 150000000f, 180f, 
                2005, 500, "asdasd");

            Console.WriteLine(plane);
            Console.WriteLine(new string('-', 20));

            Console.WriteLine(car);
            Console.WriteLine(new string('-', 20));

            Console.WriteLine(ship);
            Console.WriteLine(new string('-', 20));
            
            Console.ReadKey();
        }
    }
}