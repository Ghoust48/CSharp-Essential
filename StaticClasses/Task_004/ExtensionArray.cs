using System;

namespace Task_004
{
    public static class ExtensionArray
    {
        public static int[] ExtensionSort(this int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                for (var j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        var tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }

            return arr;
        }

        public static void Show(this int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            
            Console.WriteLine();
            Console.WriteLine(new string('-', 20));
        }
    }
}