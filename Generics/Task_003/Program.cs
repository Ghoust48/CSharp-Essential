using System;

namespace Task_003
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new MyDictionary<int, string>(2);
            
            dictionary.Add(1, "Petya");
            dictionary.Add(2, "Vasya");

            Console.WriteLine(dictionary[1]);
            Console.WriteLine(dictionary["Vasya"]);
            
            Console.ReadLine();
        }
    }
}