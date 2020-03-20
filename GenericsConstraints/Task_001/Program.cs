using System;
using System.Collections;

namespace GenericsConstraints
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add("Hello");

            // Требуется упаковка и распаковка!
            var num = (int)arrayList[0];
            var str = (string)arrayList[1];

            for (var i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
            
            Console.ReadLine();
        }
    }
}