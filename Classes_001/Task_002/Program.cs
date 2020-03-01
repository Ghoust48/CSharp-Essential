using System;

namespace Task_002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину первой стороны: ");
            var firstSide = int.Parse(Console.ReadLine());
            
            Console.Write("Введите длину второй стороны: ");
            var secondSide = int.Parse(Console.ReadLine());
            
            var rectangle = new Rectangle(firstSide, secondSide);

            Console.WriteLine($"Периметр = {rectangle.Perimeter}\n" +
                              $"Площадь = {rectangle.Area}");
            
            Console.ReadLine();
        }
    }
}