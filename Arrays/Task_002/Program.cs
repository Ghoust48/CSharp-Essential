using System;
using System.Collections.Generic;

namespace Task_002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            var length = int.Parse(Console.ReadLine());

            var arr = new MyArray(length);

            arr.Fill();
            arr.Show();
            arr.Max();
            arr.Min();
            arr.Sum();
            arr.Average();
            arr.Odd();

            Console.ReadLine();
        }

        
    }
}