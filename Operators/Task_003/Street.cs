using System;

namespace Task_003
{
    public class Street : ICloneable
    {
        private string _street;

        public Street(string street)
        {
            _street = street;
        }

        public string StreetHouse
        {
            get => _street;
        }

        public object Clone()
        {
            return new Street(_street);
        }
    }
}