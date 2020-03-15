using System;

namespace StructuresEnums
{
    // Реализовано без использования TimeSpan
    
    public class Birthday
    {
        public void DaysForHappyBirthday(DateTime date)
        {
            var sumDays = 0;
            
            if (date.Date > DateTime.Now.Date)
            {
                DaysInMonths(ref sumDays, DateTime.Now.Month + 1, date.Month - 1, DateTime.Now.Year);
            
                if (date.Month == DateTime.Now.Month)
                {
                    var day = Math.Abs(date.Day - DateTime.Now.Day);
            
                    ShowDays(date, sumDays, day);
                }
                else
                {
                    ShowDays(date, sumDays + DaysLeft(), date.Day);
                }
            }
            else if (date.Date < DateTime.Now.Date)
            {
                DaysInMonths(ref sumDays, DateTime.Now.Month + 1, 12, DateTime.Now.Year);
                    
                if (date.Month > 1)
                {
                    DaysInMonths(ref sumDays, 1, date.Month - 1, DateTime.Now.Year + 1);
                }
                
                ShowDays(date, sumDays + DaysLeft(), date.Day);
            }
            else if (date.Date == DateTime.Now.Date)
            {
                Console.WriteLine("С днем рождения!");
            }
        }
        
        private void DaysInMonths(ref int sum, int firstMonth, int secondMonth, int year)
        {
            for (var i = firstMonth; i <= secondMonth; i++)
            {
                sum += DateTime.DaysInMonth(year, i);
            }
        }

        private void ShowDays(DateTime date, int sum, int day)
        {
            Console.WriteLine($"До дня рождения с {DateTime.Now.Day}.{DateTime.Now.Month} по {date.Day}.{date.Month} " +
                              $"равно {sum + day} дней");
        }

        private int DaysLeft()
        {
            var daysInConcreteMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            var daysLeft = daysInConcreteMonth - DateTime.Now.Day;

            return daysLeft;
        }
    }
}