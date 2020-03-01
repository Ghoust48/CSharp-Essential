using System;

namespace Task_003
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Три товарища", "Пушкин", "О любви");
            book.Show();
            
            Console.ReadLine();
        }
    }
}