using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = MyClass<int>.FactoryMethod();

            Console.WriteLine(obj.GetType());
            
            Console.ReadLine();
        }
    }
}