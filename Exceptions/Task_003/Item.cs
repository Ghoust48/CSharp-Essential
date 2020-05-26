namespace Task_003
{
    public class Item
    {
        public string Name { get; set; }
        
        public string Provider { get; set; }
        
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Имя: {Name}\n" +
                   $"Имя магазина: {Provider}\n" +
                   $"Цена: {Price}";
        }
    }
}