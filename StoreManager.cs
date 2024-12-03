namespace AutoPartsStore
{
    public class StoreManager
    {
        public List<Order> Orders { get; set; }
        public List<Customer> Customers { get; set; }
        public Warehouse Warehouse { get; set; }
        public List<Request> Requests { get; set; }
        public CashRegister CashRegister { get; set; }
        public List<Supplier> Suppliers { get; set; }

        public StoreManager()
        {
            Orders = new List<Order>();
            Customers = new List<Customer>();
            Warehouse = new Warehouse();
            Requests = new List<Request>();
            CashRegister = new CashRegister();
            Suppliers = new List<Supplier>();
        }

        public void AddSupplier(Supplier supplier)
        {
            try
            {
                Suppliers.Add(supplier);
                Console.WriteLine("Поставщик добавлен успешно.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при добавлении поставщика: {ex.Message}");
            }
        }

        public void AddProduct(Product product)
        {
            Warehouse.AddProduct(Warehouse.Storage.Count + 1, product);
            Console.WriteLine("Товар добавлен успешно.");
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
            foreach (var product in order.Products)
            {
                Warehouse.AddProduct(Warehouse.Storage.Count + 1, product);
            }
            CashRegister.AddOrder(order);
        }


        public void AddRequest(Request request)
        {
            Requests.Add(request);
            Console.WriteLine("Заявка добавлена успешно.");
        }

        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
            Console.WriteLine("Клиент добавлен успешно.");
        }

        public void CancelOrder(int orderId)
        {
            var order = Orders.FirstOrDefault(o => o.Id == orderId);
            if (order != null)
            {
                Orders.Remove(order);
                Console.WriteLine("Заказ отменен успешно.");
            }
            else
            {
                Console.WriteLine("Заказ не найден.");
            }
        }

        public void EditSupplier(int supplierId, string newName, string newCountry)
        {
            var supplier = Suppliers.FirstOrDefault(s => s.Id == supplierId);
            if (supplier != null)
            {
                supplier.Name = newName;
                supplier.Country = newCountry;
                Console.WriteLine("Информация о поставщике обновлена успешно.");
            }
            else
            {
                Console.WriteLine("Поставщик не найден.");
            }
        }


        public void ReturnDefectiveProduct(int productId, int quantity)
        {
            var product = Warehouse.Storage.Values.FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                product.Quantity -= quantity;
                Console.WriteLine("Бракованный товар возвращен успешно.");
            }
            else
            {
                Console.WriteLine("Товар не найден.");
            }
        }

        public List<Supplier> GetSuppliersByCategoryAndProduct(string category, string productName, int minQuantity, DateTime startDate, DateTime endDate)
        {
            return Suppliers.Where(s => s.GetSupplierType() == category &&
                                         s.Products.Any(p => p.Name == productName &&
                                                            p.Quantity >= minQuantity &&
                                                            p.OrderDate >= startDate &&
                                                            p.OrderDate <= endDate))
                             .ToList();
        }

        public List<Product> GetProductDetails(string productName)
        {
            return Orders.SelectMany(o => o.Products)
                         .Where(p => p.Name == productName)
                         .ToList();
        }

        public List<Customer> GetCustomersByProduct(string productName, DateTime startDate, DateTime endDate, int minQuantity)
        {
            return Customers.Where(c => c.Orders.Any(o => o.Products.Any(p => p.Name == productName &&
                                                                            p.Quantity >= minQuantity &&
                                                                            p.OrderDate >= startDate &&
                                                                            p.OrderDate <= endDate)))
                            .ToList();
        }

        public Dictionary<int, Product> GetAllStoredProducts()
        {
            return Warehouse.Storage;
        }

        public List<Product> GetTopSellingProducts(int count)
        {
            return Orders.SelectMany(o => o.Products)
                         .GroupBy(p => p.Name)
                         .OrderByDescending(g => g.Sum(p => p.Quantity))
                         .Take(count)
                         .Select(g => g.First())
                         .ToList();
        }

        public decimal GetAverageSalesPerMonth(string productName)
        {
            var totalSales = Orders.SelectMany(o => o.Products)
                                   .Where(p => p.Name == productName)
                                   .Sum(p => p.Quantity);
            var totalMonths = (DateTime.Now - Orders.Min(o => o.OrderDate)).TotalDays / 30;
            return (decimal)(totalSales / totalMonths);
        }

        public (decimal Percentage, decimal Money, int Units) GetSupplierShare(int supplierId)
        {
            try
            {
                var supplier = Suppliers.FirstOrDefault(s => s.Id == supplierId);
                if (supplier == null)
                {
                    return (0, 0, 0);
                }

                var supplierSales = Orders.SelectMany(o => o.Products)
                                          .Where(p => p.Supplier == supplier)
                                          .Sum(p => p.Quantity);
                var totalSales = Orders.SelectMany(o => o.Products).Sum(p => p.Quantity);
                var percentage = supplierSales / (decimal)totalSales;
                var money = supplierSales * supplier.Products.Average(p => p.Price);
                return (percentage, money, supplierSales);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении доли поставщика: {ex.Message}");
                return (0, 0, 0);
            }
        }

        public decimal GetOverheadCostsPercentage()
        {
            var totalSales = Orders.SelectMany(o => o.Products).Sum(p => p.Price * p.Quantity);
            var overheadCosts = Orders.Sum(o => o.Products.Sum(p => p.Price * 0.1m));
            return overheadCosts / totalSales;
        }

        public List<Product> GetUnsoldProducts(DateTime startDate, DateTime endDate)
        {
            return Warehouse.Storage.Values
                             .Where(p => p.Quantity > 0 && p.Supplier.GetSupplierType() != nameof(Manufacturer) && p.Supplier.GetSupplierType() != nameof(Dealer))
                             .ToList();
        }

        public List<Product> GetDefectiveProducts(DateTime startDate, DateTime endDate)
        {
            return Warehouse.Storage.Values
                             .Where(p => p.Quantity > 0 && p.Supplier.GetSupplierType() != nameof(Manufacturer) && p.Supplier.GetSupplierType() != nameof(Dealer))
                             .ToList();
        }

        public List<Product> GetSoldProducts(DateTime date)
        {
            return Orders.Where(o => o.OrderDate.Date == date.Date)
                         .SelectMany(o => o.Products)
                         .ToList();
        }

        public List<Order> GetCashReport(DateTime startDate, DateTime endDate)
        {
            return CashRegister.GetCashReport(startDate, endDate);
        }

        public List<Product> GetInventoryReport()
        {
            return Warehouse.Storage.Values.ToList();
        }

        public decimal GetInventoryTurnoverRate()
        {
            var totalSales = Orders.SelectMany(o => o.Products).Sum(p => p.Quantity);
            var totalInventory = Warehouse.Storage.Values.Sum(p => p.Quantity);
            return totalSales / totalInventory;
        }

        public int GetEmptyCellsCount()
        {
            return Warehouse.Storage.Count(kvp => kvp.Value.Quantity == 0);
        }

        public int GetTotalCapacity()
        {
            return Warehouse.Storage.Count;
        }

        public List<Request> GetRequestsByProduct(string productName)
        {
            return Requests.Where(r => r.Product.Name == productName).ToList();
        }

        public decimal GetTotalRequestAmount(string productName)
        {
            return Requests.Where(r => r.Product.Name == productName).Sum(r => r.TotalAmount);
        }
        public List<Supplier> GetCheapestSuppliers(int count)
        {
            try
            {
                return Suppliers.OrderBy(s => s.Products.Min(p => p.Price)).Take(count).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении самых дешевых поставщиков: {ex.Message}");
                return new List<Supplier>();
            }
        }

    }
}


