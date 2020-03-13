using System;

namespace Task_002
{
    public struct Train
    {
        public string Destination { get; set; }
        
        public int Number { get; set; }

        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"{Number} {Destination} {Date}";
        }
    }
}