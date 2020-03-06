using System;

namespace Task_002
{
    public class Player : IPlayable, IRecodable
    {
        void IPlayable.Play()
        {
            Console.WriteLine("Play melody");
        }
        
        void IPlayable.Pause()
        {
            Console.WriteLine("Pause melody");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Stop melody");
        }

        void IRecodable.Record()
        {
            Console.WriteLine("Start recording");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Pause recording");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Stop recording");
        }
    }
}