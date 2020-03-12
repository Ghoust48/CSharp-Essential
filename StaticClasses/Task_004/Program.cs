using System;

namespace Task_004
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[5];

            FillArray(ref arr);
            
            arr.Show();
            
            arr.ExtensionSort();
            
            arr.Show();
            
            Console.ReadLine();
        }

        private static void FillArray(ref int[] arr)
        {
            var rnd = new Random();
            
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10, 10);
            }
        }
    }
}