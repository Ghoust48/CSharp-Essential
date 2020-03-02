using System;

namespace Inheritance
{
    public class Printer
    {
        protected ConsoleColor Color;

        public Printer(ConsoleColor color)
        {
            Color = color;
        }
        
        public void Print(string value)
        {
            Console.ForegroundColor = Color;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}