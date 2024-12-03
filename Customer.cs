using System.Collections.Generic;

namespace AutoPartsStore
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }

        public Customer(string name = "Неизвестный", int id = 0)
        {
            Name = name;
            Id = id;
            Orders = new List<Order>();
        }
    }
}
