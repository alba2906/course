using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace AutoPartsStore
{
    public partial class MainWindow : Form
    {
        private StoreManager storeManager = new StoreManager();
        private Data data = new Data();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "json files (*.json)|*.json"
            };

            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            data.Suppliers = storeManager.Suppliers;
            data.Products = storeManager.Warehouse.Storage.Values.ToList();
            data.Orders = storeManager.Orders;
            data.Customers = storeManager.Customers;
            data.Requests = storeManager.Requests;

            data.Balance = storeManager.CashRegister.Orders.Sum(o => o.Products.Sum(p => p.Price * p.Quantity));
            data.TotalRevenue = storeManager.CashRegister.GetTotalRevenue(DateTime.MinValue, DateTime.MaxValue).ToString();
            data.TotalOverheadCosts = (storeManager.CashRegister.Orders.Sum(o => o.Products.Sum(p => p.Price * 0.1m))).ToString();

            var jsonString = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(saveFileDialog.FileName, jsonString);

            MessageBox.Show("Состояние успешно сохранено.", "Сохранение состояния", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "json files (*.json)|*.json"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                var jsonString = File.ReadAllText(openFileDialog.FileName);
                data = JsonSerializer.Deserialize<Data>(jsonString);

                storeManager.Suppliers = data.Suppliers;
                storeManager.Warehouse.Storage = data.Products.ToDictionary(p => p.Id, p => p);
                storeManager.Orders = data.Orders;
                storeManager.Customers = data.Customers;
                storeManager.Requests = data.Requests;

                storeManager.CashRegister.Orders = data.Orders;
                storeManager.CashRegister.Orders.ForEach(o => o.Products.ForEach(p => p.Price = decimal.Parse(data.TotalRevenue) / p.Quantity));
                storeManager.CashRegister.Orders.ForEach(o => o.Products.ForEach(p => p.Price = decimal.Parse(data.TotalOverheadCosts) / p.Quantity / 10));

                MessageBox.Show("Состояние успешно загружено.", "Загрузка состояния", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddSupplier_Click(object sender, EventArgs e)
        {
            var addSupplierForm = new AddSupplierForm(storeManager);
            if (addSupplierForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    storeManager.AddSupplier(addSupplierForm.Supplier);
                    UpdateSuppliersForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении поставщика: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            var addProductForm = new AddProductForm(storeManager);
            if (addProductForm.ShowDialog() == DialogResult.OK)
            {
                storeManager.AddProduct(addProductForm.Product);
                UpdateProductsForm();
            }
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            var addOrderForm = new AddOrderForm(storeManager);
            if (addOrderForm.ShowDialog() == DialogResult.OK)
            {
                storeManager.AddOrder(addOrderForm.Order);
                UpdateOrdersForm();
            }
        }

        private void buttonAddRequest_Click(object sender, EventArgs e)
        {
            var addRequestForm = new AddRequestForm(storeManager);
            if (addRequestForm.ShowDialog() == DialogResult.OK)
            {
                storeManager.AddRequest(addRequestForm.Request);
                UpdateRequestsForm();
            }
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            var addCustomerForm = new AddCustomerForm(storeManager);
            if (addCustomerForm.ShowDialog() == DialogResult.OK)
            {
                storeManager.AddCustomer(addCustomerForm.Customer);
                UpdateCustomersForm();
            }
        }

        private void buttonShowSuppliers_Click(object sender, EventArgs e)
        {
            var suppliersForm = new SuppliersForm(storeManager);
            suppliersForm.ShowDialog();
        }

        private void buttonShowProducts_Click(object sender, EventArgs e)
        {
            var productsForm = new ProductsForm(storeManager);
            productsForm.ShowDialog();
        }

        private void buttonShowOrders_Click(object sender, EventArgs e)
        {
            var ordersForm = new OrdersForm(storeManager);
            ordersForm.ShowDialog();
        }

        private void buttonShowRequests_Click(object sender, EventArgs e)
        {
            var requestsForm = new RequestsForm(storeManager);
            requestsForm.ShowDialog();
        }

        private void buttonShowCustomers_Click(object sender, EventArgs e)
        {
            var customersForm = new CustomersForm(storeManager);
            customersForm.ShowDialog();
        }

        private void UpdateSuppliersForm()
        {
            var suppliersForm = new SuppliersForm(storeManager);
            suppliersForm.UpdateSuppliersListBox();
        }

        private void UpdateProductsForm()
        {
            var productsForm = new ProductsForm(storeManager);
            productsForm.UpdateProductsListBox();
        }

        private void UpdateOrdersForm()
        {
            var ordersForm = new OrdersForm(storeManager);
            ordersForm.UpdateOrdersListBox();
        }

        private void UpdateRequestsForm()
        {
            var requestsForm = new RequestsForm(storeManager);
            requestsForm.UpdateRequestsListBox();
        }

        private void UpdateCustomersForm()
        {
            var customersForm = new CustomersForm(storeManager);
            customersForm.UpdateCustomersListBox();
        }

        private void buttonGetSuppliersByCategoryAndProduct_Click(object sender, EventArgs e)
        {
            string category = "Фирма"; // Пример категории
            string productName = "Деталь A"; // Пример названия товара
            int minQuantity = 10; // Пример минимального количества
            DateTime startDate = new DateTime(2023, 1, 1); // Пример начальной даты
            DateTime endDate = new DateTime(2023, 12, 31); // Пример конечной даты

            var suppliers = storeManager.GetSuppliersByCategoryAndProduct(category, productName, minQuantity, startDate, endDate);
            MessageBox.Show($"Найдено поставщиков: {suppliers.Count}");
        }

        private void buttonGetProductDetails_Click(object sender, EventArgs e)
        {
            string productName = "Деталь A"; // Пример названия товара
            var products = storeManager.GetProductDetails(productName);
            MessageBox.Show($"Найдено деталей: {products.Count}");
        }

        private void buttonGetCustomersByProduct_Click(object sender, EventArgs e)
        {
            string productName = "Деталь A"; // Пример названия товара
            DateTime startDate = new DateTime(2023, 1, 1); // Пример начальной даты
            DateTime endDate = new DateTime(2023, 12, 31); // Пример конечной даты
            int minQuantity = 10; // Пример минимального количества

            var customers = storeManager.GetCustomersByProduct(productName, startDate, endDate, minQuantity);
            MessageBox.Show($"Найдено покупателей: {customers.Count}");
        }

        private void buttonGetAllStoredProducts_Click(object sender, EventArgs e)
        {
            var products = storeManager.GetAllStoredProducts();
            MessageBox.Show($"Найдено деталей на складе: {products.Count}");
        }

        private void buttonGetTopSellingProducts_Click(object sender, EventArgs e)
        {
            int count = 10; // Пример количества
            var products = storeManager.GetTopSellingProducts(count);
            MessageBox.Show($"Найдено самых продаваемых деталей: {products.Count}");
        }

        private void buttonGetCheapestSuppliers_Click(object sender, EventArgs e)
        {
            int count = 10; // Пример количества
            try
            {
                var suppliers = storeManager.GetCheapestSuppliers(count);
                MessageBox.Show($"Найдено самых дешевых поставщиков: {suppliers.Count}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при получении самых дешевых поставщиков: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGetAverageSalesPerMonth_Click(object sender, EventArgs e)
        {
            string productName = "Деталь A"; // Пример названия товара
            var averageSales = storeManager.GetAverageSalesPerMonth(productName);
            MessageBox.Show($"Среднее число продаж на месяц: {averageSales}");
        }

        private void buttonGetSupplierShare_Click(object sender, EventArgs e)
        {
            int supplierId = 1; // Пример ID поставщика
            var share = storeManager.GetSupplierShare(supplierId);
            MessageBox.Show($"Доля поставщика: {share.Percentage}, Деньги: {share.Money}, Единицы: {share.Units}");
        }

        private void buttonGetOverheadCostsPercentage_Click(object sender, EventArgs e)
        {
            var overheadCostsPercentage = storeManager.GetOverheadCostsPercentage();
            MessageBox.Show($"Накладные расходы в процентах: {overheadCostsPercentage}");
        }

        private void buttonGetUnsoldProducts_Click(object sender, EventArgs e)
        {
            DateTime startDate = new DateTime(2023, 1, 1); // Пример начальной даты
            DateTime endDate = new DateTime(2023, 12, 31); // Пример конечной даты
            var unsoldProducts = storeManager.GetUnsoldProducts(startDate, endDate);
            MessageBox.Show($"Найдено непроданных товаров: {unsoldProducts.Count}");
        }

        private void buttonGetDefectiveProducts_Click(object sender, EventArgs e)
        {
            DateTime startDate = new DateTime(2023, 1, 1); // Пример начальной даты
            DateTime endDate = new DateTime(2023, 12, 31); // Пример конечной даты
            var defectiveProducts = storeManager.GetDefectiveProducts(startDate, endDate);
            MessageBox.Show($"Найдено бракованных товаров: {defectiveProducts.Count}");
        }

        private void buttonGetSoldProducts_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime(2023, 1, 1); // Пример даты
            var soldProducts = storeManager.GetSoldProducts(date);
            MessageBox.Show($"Найдено проданных товаров: {soldProducts.Count}");
        }

        private void buttonGetCashReport_Click(object sender, EventArgs e)
        {
            DateTime startDate = new DateTime(2023, 1, 1); // Пример начальной даты
            DateTime endDate = new DateTime(2023, 12, 31); // Пример конечной даты
            var cashReport = storeManager.GetCashReport(startDate, endDate);
            MessageBox.Show($"Найдено заказов в кассовом отчете: {cashReport.Count}");
        }

        private void buttonGetInventoryReport_Click(object sender, EventArgs e)
        {
            var inventoryReport = storeManager.GetInventoryReport();
            MessageBox.Show($"Найдено деталей в инвентаризационной ведомости: {inventoryReport.Count}");
        }

        private void buttonGetInventoryTurnoverRate_Click(object sender, EventArgs e)
        {
            var turnoverRate = storeManager.GetInventoryTurnoverRate();
            MessageBox.Show($"Скорость оборота денежных средств: {turnoverRate}");
        }

        private void buttonGetEmptyCellsCount_Click(object sender, EventArgs e)
        {
            var emptyCellsCount = storeManager.GetEmptyCellsCount();
            MessageBox.Show($"Количество пустых ячеек на складе: {emptyCellsCount}");
        }

        private void buttonGetTotalCapacity_Click(object sender, EventArgs e)
        {
            var totalCapacity = storeManager.GetTotalCapacity();
            MessageBox.Show($"Общая вместимость склада: {totalCapacity}");
        }

        private void buttonGetRequestsByProduct_Click(object sender, EventArgs e)
        {
            string productName = "Деталь A"; // Пример названия товара
            var requests = storeManager.GetRequestsByProduct(productName);
            MessageBox.Show($"Найдено заявок: {requests.Count}");
        }

        private void buttonGetTotalRequestAmount_Click(object sender, EventArgs e)
        {
            string productName = "Деталь A"; // Пример названия товара
            var totalRequestAmount = storeManager.GetTotalRequestAmount(productName);
            MessageBox.Show($"Общая сумма заявок: {totalRequestAmount}");
        }
    }
}
