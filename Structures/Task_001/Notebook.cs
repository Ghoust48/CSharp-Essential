namespace Structures
{
    public struct Notebook
    {
        public string Model { get; set; }
        
        public string Manufacturer { get; set; }
        
        public float Price { get; set; }

        public Notebook(string model, string manufacturer, float price)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
        }

        public override string ToString()
        {
            return $"Модель: {Model} \nПроизводитель: {Manufacturer} \nЦена: {Price}";
        }
    }
}