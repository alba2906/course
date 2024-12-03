using System;
using System.Collections.Generic;

namespace AutoPartsStore
{
    public class Data
    {
        public List<Supplier> Suppliers { get; set; }
        public List<Product> Products { get; set; }
        public List<Order> Orders { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Request> Requests { get; set; }
        public decimal Balance { get; set; }
        public string TotalRevenue { get; set; }
        public string TotalOverheadCosts { get; set; }
    }
}
