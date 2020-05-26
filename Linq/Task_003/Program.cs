using System;
using System.Collections.Generic;

namespace Task_003
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<dynamic, dynamic>
            {
                {new {Key = "table"}, new {Value = "стол"}},
                {new {Key = "apple"}, new {Value = "яблоко"}},
                {new {Key = "pen"}, new {Value = "ручка"}},
                {new {Key = "pencil"}, new {Value = "карандаш"}},
                {new {Key = "task"}, new {Value = "задание"}},
                {new {Key = "deadline"}, new {Value = "срок"}},
                {new {Key = "work"}, new {Value = "работа"}},
                {new {Key = "car"}, new {Value = "машина"}},
                {new {Key = "child"}, new {Value = "ребенок"}},
                {new {Key = "notebook"}, new {Value = "ноутбук"}},
                {new {Key = "mouse"}, new {Value = "мышь"}}
            };

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}