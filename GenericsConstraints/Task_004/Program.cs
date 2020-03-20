using System;
using System.Collections;

namespace Task_004
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayList = new ArrayList();
            
            arrayList.Add(1);
            arrayList.Add("Hello");

            Console.WriteLine(arrayList);
        }
    }
}