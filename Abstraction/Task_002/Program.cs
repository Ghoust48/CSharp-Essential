using System;

namespace Task_002
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();
            ((IPlayable) player).Play();
            ((IPlayable) player).Pause();
            ((IPlayable) player).Stop();

            Console.WriteLine(new string('-', 20));
            
            ((IRecodable) player).Record();
            ((IRecodable) player).Pause();
            ((IRecodable) player).Stop();
            

            Console.ReadLine();
        }
    }
}