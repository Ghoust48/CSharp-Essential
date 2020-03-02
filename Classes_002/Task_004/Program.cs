using System;

namespace Task_004
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoice = new Invoice(12345, "Вася", "Петя") {Article = "PC", Quantity = 2};

            invoice.CostCalculation(Product.PC, true);
            invoice.CostCalculation(Product.PC, false);

            Console.ReadLine();
        }
    }
}