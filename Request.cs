
using System;

namespace AutoPartsStore
{
    public class Request
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }

        public Request(Customer customer = null, Product product = null, int quantity = 0, decimal totalAmount = 0, int id = 0)
        {
            Customer = customer;
            Product = product;
            Quantity = quantity;
            TotalAmount = totalAmount;
            Id = id;
        }
    }
}
