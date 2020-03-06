using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterColor printer = new PrinterColor(ConsoleColor.Red);
            printer.Print("Hello");
            
            Printer printer1 = printer as Printer;
            printer1.Print("World");
            
            Console.ReadKey();
        }
    }
}