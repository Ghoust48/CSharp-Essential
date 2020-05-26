using System;
using System.Threading.Channels;

namespace Task_003
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new Shop();
            items.Add();

            Console.Write("Введите название магазина: ");
            var provider = Console.ReadLine();

            items.ShowItems(provider);
        }
    }
}