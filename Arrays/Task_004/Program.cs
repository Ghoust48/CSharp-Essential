using System;

namespace Task_004
{
    class Program
    {
        static void Main(string[] args)
        {
            var store = new Store(5);
            
            store.Fill(0, "картошка", "Дионис", 2f);
            store.Fill(1, "яблоко", "Евроопт", 3f);
            store.Fill(2, "апельсин", "Ганна", 1f);
            store.Fill(3, "курица", "Ганна", 6f);
            store.Fill(4, "огурцы", "Дионис", 1.5f);
            
            store.Show();

            Console.WriteLine(store[0]);

            Console.WriteLine(store["курица"]);
            
            Console.ReadLine();
        }
    }
}