using System;

namespace Task_002
{
    public class Car
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public Car(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }

        public override string ToString()
        {
            return $"Название машины: {Name}\nГод выпуска: {Date:d}\n";
        }
    }
}