using System;

namespace Task_003
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<int, string>();
            
            dictionary.Add(1, "One");
            dictionary.Add(2, "Two");
            dictionary.Add(3, "Three");

            Console.WriteLine(dictionary[1]);
            Console.WriteLine(dictionary["Two"]);
        }
    }
}