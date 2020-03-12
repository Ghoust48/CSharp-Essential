using System;

namespace Task_003
{
    public class Book
    {
        public class Notes
        {
            public string Note { get; set; }
        }
        
        private string Text { get; set; } = "Hello world! This is book the best";

        public void FindNext(string s)
        {
            Console.WriteLine("Поиск строки : " + s);
            
            if (Text.Contains(s))
                Console.WriteLine($"Строка: {Text} содержит слово: {s}");
            else
                Console.WriteLine("Совпадений нет!");
        }
    }
}