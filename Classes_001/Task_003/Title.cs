using System;

namespace Task_003
{
    public class Title
    {
        public string _title;

        public Title(string title)
        {
            _title = title;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(_title);
            Console.ResetColor();
        }
    }
}