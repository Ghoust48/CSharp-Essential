using System;

namespace Task_004
{
    class Program
    {
        static void Main(string[] args)
        {
            var date1 = new Date(new DateTime(2020, 5, 21));
            Console.WriteLine(date1);

            var date2 = new Date(new DateTime(2020, 5, 10));
            Console.WriteLine(date2);

            Console.WriteLine(new string('-', 15));

            var result = date1 - date2;
            Console.WriteLine(result);
            
            Console.WriteLine(new string('-', 15));

            result = date1 + date2;
            Console.WriteLine(result);
        }
    }
}