using System;

namespace Task_003
{
    public class Content
    {
        private string _content;
        
        public Content(string content)
        {
            _content = content;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(_content);
            Console.ResetColor();
        }
    }
}