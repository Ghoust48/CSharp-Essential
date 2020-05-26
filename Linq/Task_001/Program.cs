using System;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            Console.WriteLine(calculator.Add(1,4));
            Console.WriteLine(calculator.Sub(123,4));
            Console.WriteLine(calculator.Multiply(1f,4f));
            Console.WriteLine(calculator.Div(1,4));
        }
    }
}