using System;
using System.Threading.Channels;

namespace Task_002
{
    public delegate float Operation(int a, int b);
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            var firstNumber = int.Parse(Console.ReadLine());
            
            Console.Write("Введите второе число: ");
            var secondNumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Какую операцию хотите выполнить\n" +
                              "1. Сложение\n" +
                              "2. Вычитание\n" +
                              "3. Умножение\n" +
                              "4. Деление\n");

            var input = int.Parse(Console.ReadLine());

            Operation operation = null;
            var result = 0f;
            
            switch (input)
            {
                case 1:
                    operation = (a, b) => a + b;
                    result = operation(firstNumber, secondNumber);
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");
                    break;
                case 2:
                    operation = (a, b) => a - b;
                    result = operation(firstNumber, secondNumber);
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {result}");
                    break;
                case 3:
                    operation = (a, b) => a * b;
                    result = operation(firstNumber, secondNumber);
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {result}");
                    break;
                case 4:
                    operation = (a, b) =>
                    {
                        if ((a == 0 || b == 0))
                        {
                            Console.WriteLine("Аргумент не может равняться 0");
                            return 0;
                        }

                        return a / b;
                    };
                    result = operation(firstNumber, secondNumber);
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {result}");
                    break;
            }
            
            Console.ReadLine();
        }
    }
}