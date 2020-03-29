using System;
using System.Collections.Generic;

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

            Console.WriteLine(list[4]);

            Console.WriteLine(new string('-', 5));

            //for (int i = 0; i < list.Length; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 5));

            //IEnumerable<int> enumerable = list as IEnumerable<int>;
            //IEnumerator<int> enumerator = enumerable.GetEnumerator();

            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current);
            //}

            //enumerator.Reset();
        }
    }
}
