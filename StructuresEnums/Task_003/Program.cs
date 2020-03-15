using System;

namespace Task_003
{
    class Program
    {
        static void Main(string[] args)
        {
            var accountant = new Accountant();

            var isGive = accountant.AskForBonus(Positions.Junior, 150);

            Console.WriteLine(isGive ? "Дать премию" : "Премию не выдавать");

            Console.ReadLine();
        }
    }
}