using System;
using System.Collections.Generic;

namespace Task_003
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new MyDictionary<int, string>();

            dictionary.Add(0, "a");
            dictionary.Add(1, "b");
            dictionary.Add(2, "c");

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 10));
        }
    }
}
