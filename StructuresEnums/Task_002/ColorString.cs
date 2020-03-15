using System;

namespace Task_002
{
    public static class ColorString
    {
        public static void Print(string str, int color)
        {
            switch (color)
            {
                case (int)Colors.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case (int)Colors.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case (int)Colors.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case (int)Colors.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
            }
            
            Console.WriteLine(str);
        }
    }
}