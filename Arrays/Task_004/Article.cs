using System;
using System.Collections.Generic;

namespace Task_004
{
    public class Article
    {
        private float _price;
        
        public string Name { get; private set; }
        
        public string NameStore { get; private set; }

        public float Price
        {
            get => _price;
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("Стоимость товара не может быть меньше 0");
                    return;
                }

                _price = value;
            }
        }

        public Article() { }

        public Article(string name, string nameStore, float price)
        {
            Add(name, nameStore, price);
        }

        public override string ToString()
        {
            return $"{Name} из магазина {NameStore} стоит {Price}р";
        }

        public void Add(string name, string nameStore, float price)
        {
            Name = name;
            NameStore = nameStore;
            Price = price;
        }
    }
}