using System;

namespace Task_004
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new MyList<int>(2);
            
            list.Add(1);
            list.Add(2);

            var arr = list.GetArray();

            for (var i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadLine();
        }
    }
}