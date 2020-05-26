using System;

namespace Task_003
{
    public class House : ICloneable
    {
        private string _type;

        private Street _street;

        public House(string type, Street street)
        {
            _type = type;
            _street = street;
        }

        public House(string type, Street street, string owner, string color) : this(type, street)
        {
            Owner = owner;
            Color = color;
        }
        
        public string Owner { get; set; }
        
        public string Color { get; set; }

        public Street Street
        {
            get => _street;
            set => _street = value;
        }

        public object Clone()
        {
            return this;
        }

        public object DeepClone()
        {
            return new House(_type, _street.Clone() as Street, Owner, Color);
        }

        public override string ToString()
        {
            return $"Хозяин {Owner}, Тип {_type}, Цвет {Color}, Улица {_street.StreetHouse}";
        }
    }
}