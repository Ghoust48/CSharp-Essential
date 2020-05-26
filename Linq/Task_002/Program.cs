using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_002
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Car
                {
                    Color = "красный",
                    Mark = "BMW",
                    Model = "asdjk-12",
                    Year = 1999
                },
                new Car
                {
                    Color = "черный",
                    Mark = "Mersedes",
                    Model = "dsfsuj-002",
                    Year = 2002
                },
                new Car
                {
                    Color = "белый",
                    Mark = "Peugeot",
                    Model = "asd99",
                    Year = 1985
                },
                new Car
                {
                    Color = "красный",
                    Mark = "Audi",
                    Model = "asjiiji-22",
                    Year = 2015
                },
            };

            var customers = new List<Customer>
            {
                new Customer
                {
                    Model = "asjiiji-22",
                    Name = "Вася",
                    Phone = "848888944"
                },
                new Customer
                {
                    Model = "asd99",
                    Name = "Петя",
                    Phone = "165184615"
                },
                new Customer
                {
                    Model = "asdjk-12",
                    Name = "Вова",
                    Phone = "5155186681"
                },
            };

            var query = from customer in customers
                join car in cars on customer.Model equals car.Model
                select new
                {
                    Name = customer.Name,
                    Phone = customer.Phone,
                    Mark = car.Mark,
                    Color = car.Color,
                    Year = car.Year
                };

            foreach (var item in query)
            {
                Console.WriteLine($"Имя: {item.Name}\n" +
                                  $"Телефон: {item.Phone}\n" +
                                  $"Марка: {item.Mark}\n" +
                                  $"Цвет: {item.Color}\n" +
                                  $"Год: {item.Year}\n" +
                                  $"{new string('-', 15)}");
            }
        }
    }
}