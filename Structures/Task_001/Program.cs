using System;

namespace Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            var notebook = new Notebook("256asd0", "Asus", 2004);

            Console.WriteLine(notebook);
            
            Console.ReadLine();
        }
    }
}