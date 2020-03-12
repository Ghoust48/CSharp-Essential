using System;

namespace Task_002
{
    public class Book
    {
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