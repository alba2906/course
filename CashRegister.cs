using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoPartsStore
{
    public class CashRegister
    {
        public List<Order> Orders { get; set; }

        public CashRegister()
        {
            Orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public decimal GetTotalRevenue(DateTime startDate, DateTime endDate)
        {
            return Orders.Where(o => o.OrderDate >= startDate && o.OrderDate <= endDate)
                         .Sum(o => o.Products.Sum(p => p.Price * p.Quantity));
        }

        public List<Order> GetCashReport(DateTime startDate, DateTime endDate)
        {
            return Orders.Where(o => o.OrderDate >= startDate && o.OrderDate <= endDate).ToList();
        }
    }
}

