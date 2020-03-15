using System;

namespace Task_003
{
    public delegate float MyDelegate(RandomNumber[] randomNumbers);

    public delegate int RandomNumber(); 
    
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate = numbers =>
            {
                var sum = 0;
            
                for (var i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = () =>
                    {
                        var rand = new Random();
                        return rand.Next(-10, 10);
                    };
                    
                    sum += numbers[i].Invoke();
                }
                
                return sum / numbers.Length;
            };

            Console.WriteLine(myDelegate.Invoke(new RandomNumber[5]));
            
            Console.ReadLine();
        }
    }
}