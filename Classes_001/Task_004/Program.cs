using System;

namespace Task_004
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = new Figure(new Point(1, 1, "A"), 
                new Point(0, 1, "B"), 
                new Point(0, 0, "C"));

            Console.WriteLine($"{figure.Type}, P = {figure.PerimeterCalculator()}");
            
            Console.ReadLine();
        }
    }
}