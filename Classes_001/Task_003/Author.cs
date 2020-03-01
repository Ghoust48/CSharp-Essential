using System;

namespace Task_003
{
    public class Author
    {
        private string _author;
        
        public Author(string author)
        {
            _author = author;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(_author);
            Console.ResetColor();
        }
    }
}