using System;

namespace Task_002
{
    class Program
    {
        static void Main(string[] args)
        {
            var converter = new Converter(2.24, 2.47, 0.033);
            
            converter.ToUsd(1);
            converter.FromUsd(1);
            
            Console.ReadLine();
        }
    }
}