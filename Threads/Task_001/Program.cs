using System;
using System.Threading;

namespace Task_001
{
    class Program
    {

        static void Main(string[] args)
        {
            var thread = new Thread(Method);
            thread.Start();
        }

        private static void Method()
        {
            var rnd = new Random();

            Console.WriteLine($"ID = {Thread.CurrentThread.GetHashCode()}, value = {rnd.Next(1, 20)}");

            Thread.Sleep(200);

            new Thread(Method).Start();
        }
    }
}
