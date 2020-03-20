using System;

namespace Task_002
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new MyList<int>();
            
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            for (var i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
            
            Console.ReadLine();
        }
    }
}