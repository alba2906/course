namespace AutoPartsStore
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Supplier Supplier { get; set; }
        public DateTime OrderDate { get; set; } // Добавлено свойство OrderDate

        public Product(string name = "Неизвестный", decimal price = 0, int quantity = 0, Supplier supplier = null, int id = 0, DateTime orderDate = default)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Supplier = supplier;
            Id = id;
            OrderDate = orderDate; // Инициализация свойства OrderDate
        }
    }
}

