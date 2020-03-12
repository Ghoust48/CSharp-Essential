using System;

namespace StaticClasses
{
    public static class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("На нуль делить нельзя!");
                return 0;
            }
            
            return a / b;
        }
    }
}