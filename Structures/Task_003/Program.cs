using System;

namespace Task_003
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
            myClass.change = "не изменено";
            Console.WriteLine(myClass.change);
            
            var myStruct = new MyStruct();
            myStruct.change = "не изменено";
            Console.WriteLine(myStruct.change);
            
            ClassTaker(myClass);
            
            StructTaker(myStruct);
            
            Console.ReadLine();
        }

        private static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
            Console.WriteLine(myClass.change);
        }

        private static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
            Console.WriteLine(myStruct.change);
        }
    }
}