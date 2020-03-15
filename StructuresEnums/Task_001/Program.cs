using System;
using System.Globalization;

namespace StructuresEnums
{
    class Program
    {
        // Реализовано с использованием TimeSpan
        
        static void Main(string[] args)
        {
            Console.Write("Введите дату рождения: ");
            var date = DateTime.ParseExact(Console.ReadLine(), "dd.MM", CultureInfo.InvariantCulture);
            
            var now = DateTime.Now;
            TimeSpan wait;

            var thisYear = new DateTime(now.Year, date.Month, date.Day);

            if (thisYear < now)
            {
                thisYear = new DateTime(now.Year + 1, date.Month, date.Day);
                wait = thisYear - now;
            }
            else
            {
                wait = thisYear - now;
            }   

            Console.WriteLine("До дня рождения осталось {0} дней", wait.Days);
            
            Console.ReadLine();
        }
    }
}