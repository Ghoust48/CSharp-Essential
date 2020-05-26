using System;

namespace Task_003
{
    class Program
    {
        static void Main(string[] args)
        {
            var original = new House("Кирпичный", new Street("ул. Домов"), "Пупкин", "Белый");
            
            Console.WriteLine(original);
            
            var clone = original.Clone() as House;
            clone.Color = "Серый";
            clone.Street = new Street("asd");
            
            Console.WriteLine(original);
            Console.WriteLine(clone);
            
            clone = original.DeepClone() as House;
            clone.Owner = "Петрович";
            clone.Street = new Street("Basdbasd");
            
            Console.WriteLine(original);
            Console.WriteLine(clone);
        }
    }
}