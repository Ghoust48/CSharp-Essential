using System;

namespace Task_002
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = new Block(4, 5, 5,4);
            var b2 = new Block(2, 3, 3, 2);
            var b3 = new Block(4, 5, 5,4);

            Console.WriteLine(b1.Equals(b2));
            Console.WriteLine(b1.Equals(b3));
        }
    }
}