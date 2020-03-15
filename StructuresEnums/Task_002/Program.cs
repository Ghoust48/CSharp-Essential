using System;

namespace Task_002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            var str = Console.ReadLine();

            Console.WriteLine("Выберите цвет: \n" +
                              "1. Красный\n" +
                              "2. Сининй\n" +
                              "3. Зелёный\n" +
                              "4. Желтый\n");

            var input = int.Parse(Console.ReadLine());
            ColorString.Print(str, input);
            
            Console.ReadLine();
        }
    }
}