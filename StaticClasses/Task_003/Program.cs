using System;

namespace Task_003
{
    class Program
    {
        static void Main(string[] args)
        {
            FindAndReplaceManager.FindNext("Hello");

            var book = new Book.Notes {Note = "Nice book"};

            Console.WriteLine(book.Note);
            
            Console.ReadLine();
        }
    }
}