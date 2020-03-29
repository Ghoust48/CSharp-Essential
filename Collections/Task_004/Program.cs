using System;

namespace Task_004
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new MyList<int>
            {
                1,
                2,
                3,
                4,
                5
            };

            Console.WriteLine(list[4]);

            Console.WriteLine(new string('-', 5));

            //for (var i = 0; i < list.Length; i++)
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

            var array = list.GetArray<int>();

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            for (var i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine(new string('-', 5));
        }
    }
}
