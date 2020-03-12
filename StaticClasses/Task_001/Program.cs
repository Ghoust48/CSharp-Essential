using System;

namespace StaticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            var firstNumber = int.Parse(Console.ReadLine());
            
            Console.Write("Введите второе число: ");
            var secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Выберите операцию:\n" +
                              "1. Сложение\n" +
                              "2. Вычитание\n" +
                              "3. Умножение\n" +
                              "4. Деление\n");

            var input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    var sum = Calculator.Add(firstNumber, secondNumber);
                    Console.WriteLine(sum);
                    break;
                case 2:
                    var minus = Calculator.Minus(firstNumber, secondNumber);
                    Console.WriteLine(minus);
                    break;
                case 3:
                    var multiply = Calculator.Multiply(firstNumber, secondNumber);
                    Console.WriteLine(multiply);
                    break;
                case 4:
                    var divide = Calculator.Divide(firstNumber, secondNumber);
                    Console.WriteLine(divide);
                    break;
                default:
                    Console.WriteLine("Такого варианта нет");
                    break;
            }
            
            Console.ReadLine();
        }
    }
}