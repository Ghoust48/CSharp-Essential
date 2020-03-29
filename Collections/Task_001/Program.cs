using System;
using System.Collections.Generic;

namespace Task_001
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenArr = EvenNumbers(arr);

            foreach (var item in evenArr)
            {
                Console.WriteLine(item);
            }
        }

        private static IEnumerable<int> EvenNumbers(int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    yield return arr[i];
                }
            }
        }
    }
}
