using System;

namespace Classes_001
{
    class Program
    {
        static void Main(string[] args)
        {
            var address = new Address(12321, "RUS", "asd", "asd", "qweqwe", "asdasd");

            Console.WriteLine($"Index = {address.Index}\n" +
                              $"Country = {address.Country}\n" +
                              $"City = {address.City}\n" +
                              $"Street = {address.Street}\n" +
                              $"House = {address.House}\n" +
                              $"Apartment = {address.Apartment}\n");

            Console.ReadLine();
        }
    }
}