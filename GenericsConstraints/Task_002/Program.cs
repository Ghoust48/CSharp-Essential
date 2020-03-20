using System;
using System.Collections.Generic;

namespace Task_002
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new CarCollection<Car>();
            
            cars.Add("Mersedes", new DateTime(2002, 12, 2));
            cars.Add("BMW", new DateTime(2005, 1, 12));


            Console.WriteLine(cars[0]);

            Console.ReadLine();
        }
    }
}