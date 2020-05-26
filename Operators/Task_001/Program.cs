using System;

namespace Task_001
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(1, 2, 3);
            var p2 = new Point(2, 3, 4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            var res = p1 + p2;

            Console.WriteLine(res);
        }
    }
}