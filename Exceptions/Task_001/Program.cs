using System;

namespace Task_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            var firstNumber = ReadInt("Введите первое число: ");

            Console.Write("Введите второе число: ");
            var secondNumber = ReadInt("Введите второе число: ");

            var isWork = true;

            while (isWork)
            {
                Console.WriteLine("Выберите операцию\n" +
                              "1. Сложение\n" +
                              "2. Вычитание\n" +
                              "3. Умножение\n" +
                              "4. Деление\n" +
                              "0. Выход\n");

                switch (Console.ReadLine())
                {
                    case "1":
                        ShowOperation(firstNumber, secondNumber, '+');                     
                        break;
                    case "2":
                        ShowOperation(firstNumber, secondNumber, '-');
                        break;
                    case "3":
                        ShowOperation(firstNumber, secondNumber, '*');
                        break;
                    case "4":
                        try
                        {
                            ShowOperation(firstNumber, secondNumber, '/');
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("Деление на ноль не возможно!");
                        }
                        break;
                    case "0":
                        isWork = false;
                        break;
                    default:
                        Console.WriteLine("Введено неверное значение!");
                        break;
                }

                Console.WriteLine(new string('-', 20));
            }
            
        }

        private static void ShowOperation(int firstNumber, int secondNumber, char operation)
        {
            var calculator = new Calculator();

            Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {calculator.Add(firstNumber, secondNumber)}");
        }

        private static int ReadInt(string s)
        {
            int value;

            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Неверное значение! Попробуйте ещё раз!");
                Console.WriteLine(new string('-', 20));
                Console.WriteLine(s);
            }

            return value;
        }
    }
}
