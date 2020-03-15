using System;

namespace Delegates
{
    class Program
    {
        public delegate int MyDelegate(int a, int b, int c);
        
        static void Main(string[] args)
        {
            MyDelegate operation = (a, b, c) => (a + b + c) / 3;

            Console.WriteLine(operation(1, 2, 3));
            
            
            Console.ReadLine();
        }
    }
}