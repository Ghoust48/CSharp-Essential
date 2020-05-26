using System;

namespace Task_003
{
    public class Shop
    {
        private Item[] _items = new Item[2];
        
        public int Length { private set; get; }

        public Shop()
        {
            for (var i = 0; i < _items.Length; i++)
            {
                _items[i] = new Item();
            }
            
            Length = _items.Length;
        }

        public void Add()
        {
            foreach (var item in _items)
            {
                Console.WriteLine("Введите товар");
                
                Console.Write("Имя: ");
                item.Name = Console.ReadLine();
                
                Console.Write("Имя магазина: ");
                item.Provider = Console.ReadLine();
                
                Console.Write("Цена: ");
                item.Price = decimal.Parse(Console.ReadLine());
                
                Console.WriteLine(new string('-', 15));
            }
        }

        public void Sort()
        {
            for (var i = 0; i < _items.Length; i++)
            {
                for (var j = i + 1; j < _items.Length; j++)
                {
                    if (string.Compare(_items[i].Provider, _items[j].Provider, StringComparison.Ordinal) > 0 )
                    {
                        var tmp = _items[i];
                        _items[i] = _items[j];
                        _items[j] = tmp;
                    }
                }
            }
        }

        public void ShowItems(string provider)
        {
            Sort();
            
            try
            {
                var hasProvider = false;
                
                foreach (var item in _items)
                {
                    if (item.Provider == provider)
                    {
                        Console.WriteLine(item);
                        hasProvider = true;
                    }
                }

                if (hasProvider == false)
                {
                    throw new ArgumentException("Не существует товара, в таком магазине!");
                }
                
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            
        }
    }
}