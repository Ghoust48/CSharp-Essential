using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary();
            
            Show(dictionary, "книга", "дом", "ручка", "стол", "яблоко", "солнце");
            Show(dictionary, "book", "house", "pen", "table", "apple", "sun");
            Show(dictionary, "книга", "будинок", "ручка", "стола", "яблуко", "сонце");

            for (var i = 0; i < 6; i++)
            {
                Console.WriteLine(dictionary[i]);
            }
            
            Console.ReadLine();
        }

        private static void Show(Dictionary dictionary, params string[] words)
        {
            foreach (var word in words)
            {
                Console.WriteLine(dictionary[word]);
            }

            Console.WriteLine(new string('-', 20));
        }
    }
}