using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Task_002
{
    class Matrix
    {
        private readonly string _symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        private static readonly object _locker = new object();

        private readonly Random _random;

        private readonly int _endConsole = 40;

        public Matrix(int column)
        {
            Column = column;
            _random = new Random((int)DateTime.Now.Ticks);
        }

        public int Column { get; set; }

        public int LengthChain { get; set; }

        public char Symbol => _symbols.ToCharArray()[_random.Next(0, 35)];

        public void Move()
        {
            int maxLengthChain;

            while (true)
            {
                maxLengthChain = _random.Next(3, 6);

                Thread.Sleep(_random.Next(20, 5000));

                for (var i = 0; i < _endConsole; i++)
                {
                    lock (_locker)
                    {
                        Console.CursorTop = 0;
                        Console.ForegroundColor = ConsoleColor.Black;

                        WriteAt(' ', i);

                        if (LengthChain < maxLengthChain)
                        {
                            LengthChain++;
                        }
                        else if (LengthChain == maxLengthChain)
                        {
                            maxLengthChain = 0;
                        }

                        if ((_endConsole - 1) - i < LengthChain)
                        {
                            LengthChain--;
                        }
                            
                        Console.CursorTop = i - LengthChain + 1;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;

                        WriteAt(Symbol, LengthChain - 2); // Выводим все символы кроме первых 2-х  

                        ChangeColor(2, ConsoleColor.Green);
                        ChangeColor(1, ConsoleColor.White);

                        Thread.Sleep(20);
                    }
                }
            }
        }

        private void WriteAt(char ch, int length)
        {
            for (var j = 0; j < length; j++)
            {
                Console.CursorLeft = Column;
                Console.WriteLine(ch);
            }
        }

        private void ChangeColor(int value, ConsoleColor color)
        {
            if (LengthChain >= value)
            {
                Console.ForegroundColor = color;
                Console.CursorLeft = Column;
                Console.WriteLine(Symbol);
            }
        }
    }
}
