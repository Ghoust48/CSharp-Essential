using System;
using System.Globalization;

namespace Task_002
{
    class Program
    {
        static void Main(string[] args)
        {
            var workers = new Workers();
            workers.Read();
            workers.Sort();
            workers.ShowFIO();
        }
    }
}