using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace Task_002
{
    class Program
    {
        static void Main(string[] args)
        {
            var trains = new Train[3];

            for (var i = 0; i < trains.Length; i++)
            {
                Console.Write("Введите номер поезда: ");
                trains[i].Number = int.Parse(Console.ReadLine());
            
                Console.Write("Введите название пункта назначения: ");
                trains[i].Destination = Console.ReadLine();
                
                Console.Write("Введите время отправления: ");
                trains[i].Date = DateTime.ParseExact(Console.ReadLine(), "HH:mm", CultureInfo.InvariantCulture);

                Console.WriteLine(new string('-', 20));
            }

            TrainsSort(trains);
            
            TrainsShow(trains);

            Console.ReadLine();
        }

        private static void TrainsSort(Train[] trains)
        {
            for (var i = 0; i < trains.Length; i++)
            {
                for (var j = i + 1; j < trains.Length; j++)
                {
                    if (trains[i].Number > trains[j].Number)
                    {
                        var tmp = trains[i].Number;
                        trains[i].Number = trains[j].Number;
                        trains[j].Number = tmp;
                    }
                }
            }
        }

        private static void TrainsShow(Train[] trains)
        {
            Console.Write("Введите номер поезда: ");
            var input = int.Parse(Console.ReadLine());

            var isHas = false;
            
            foreach (var train in trains)
            {
                if (input == train.Number)
                {
                    isHas = true;
                    Console.WriteLine(train);
                }
            }

            if (!isHas)
            {
                Console.WriteLine("Такого поезда не существует");
            }
        }
    }
}