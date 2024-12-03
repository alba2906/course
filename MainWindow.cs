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

            MessageBox.Show("��������� ������� ���������.", "���������� ���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                MessageBox.Show("��������� ������� ���������.", "�������� ���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� �������� ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show($"������ ��� ���������� ����������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string category = "�����"; // ������ ���������
            string productName = "������ A"; // ������ �������� ������
            int minQuantity = 10; // ������ ������������ ����������
            DateTime startDate = new DateTime(2023, 1, 1); // ������ ��������� ����
            DateTime endDate = new DateTime(2023, 12, 31); // ������ �������� ����

            var suppliers = storeManager.GetSuppliersByCategoryAndProduct(category, productName, minQuantity, startDate, endDate);
            MessageBox.Show($"������� �����������: {suppliers.Count}");
        }

        private void buttonGetProductDetails_Click(object sender, EventArgs e)
        {
            string productName = "������ A"; // ������ �������� ������
            var products = storeManager.GetProductDetails(productName);
            MessageBox.Show($"������� �������: {products.Count}");
        }

        private void buttonGetCustomersByProduct_Click(object sender, EventArgs e)
        {
            string productName = "������ A"; // ������ �������� ������
            DateTime startDate = new DateTime(2023, 1, 1); // ������ ��������� ����
            DateTime endDate = new DateTime(2023, 12, 31); // ������ �������� ����
            int minQuantity = 10; // ������ ������������ ����������

            var customers = storeManager.GetCustomersByProduct(productName, startDate, endDate, minQuantity);
            MessageBox.Show($"������� �����������: {customers.Count}");
        }

        private void buttonGetAllStoredProducts_Click(object sender, EventArgs e)
        {
            var products = storeManager.GetAllStoredProducts();
            MessageBox.Show($"������� ������� �� ������: {products.Count}");
        }

        private void buttonGetTopSellingProducts_Click(object sender, EventArgs e)
        {
            int count = 10; // ������ ����������
            var products = storeManager.GetTopSellingProducts(count);
            MessageBox.Show($"������� ����� ����������� �������: {products.Count}");
        }

        private void buttonGetCheapestSuppliers_Click(object sender, EventArgs e)
        {
            int count = 10; // ������ ����������
            try
            {
                var suppliers = storeManager.GetCheapestSuppliers(count);
                MessageBox.Show($"������� ����� ������� �����������: {suppliers.Count}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� ��������� ����� ������� �����������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGetAverageSalesPerMonth_Click(object sender, EventArgs e)
        {
            string productName = "������ A"; // ������ �������� ������
            var averageSales = storeManager.GetAverageSalesPerMonth(productName);
            MessageBox.Show($"������� ����� ������ �� �����: {averageSales}");
        }

        private void buttonGetSupplierShare_Click(object sender, EventArgs e)
        {
            int supplierId = 1; // ������ ID ����������
            var share = storeManager.GetSupplierShare(supplierId);
            MessageBox.Show($"���� ����������: {share.Percentage}, ������: {share.Money}, �������: {share.Units}");
        }

        private void buttonGetOverheadCostsPercentage_Click(object sender, EventArgs e)
        {
            var overheadCostsPercentage = storeManager.GetOverheadCostsPercentage();
            MessageBox.Show($"��������� ������� � ���������: {overheadCostsPercentage}");
        }

        private void buttonGetUnsoldProducts_Click(object sender, EventArgs e)
        {
            DateTime startDate = new DateTime(2023, 1, 1); // ������ ��������� ����
            DateTime endDate = new DateTime(2023, 12, 31); // ������ �������� ����
            var unsoldProducts = storeManager.GetUnsoldProducts(startDate, endDate);
            MessageBox.Show($"������� ����������� �������: {unsoldProducts.Count}");
        }

        private void buttonGetDefectiveProducts_Click(object sender, EventArgs e)
        {
            DateTime startDate = new DateTime(2023, 1, 1); // ������ ��������� ����
            DateTime endDate = new DateTime(2023, 12, 31); // ������ �������� ����
            var defectiveProducts = storeManager.GetDefectiveProducts(startDate, endDate);
            MessageBox.Show($"������� ����������� �������: {defectiveProducts.Count}");
        }

        private void buttonGetSoldProducts_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime(2023, 1, 1); // ������ ����
            var soldProducts = storeManager.GetSoldProducts(date);
            MessageBox.Show($"������� ��������� �������: {soldProducts.Count}");
        }

        private void buttonGetCashReport_Click(object sender, EventArgs e)
        {
            DateTime startDate = new DateTime(2023, 1, 1); // ������ ��������� ����
            DateTime endDate = new DateTime(2023, 12, 31); // ������ �������� ����
            var cashReport = storeManager.GetCashReport(startDate, endDate);
            MessageBox.Show($"������� ������� � �������� ������: {cashReport.Count}");
        }

        private void buttonGetInventoryReport_Click(object sender, EventArgs e)
        {
            var inventoryReport = storeManager.GetInventoryReport();
            MessageBox.Show($"������� ������� � ������������������ ���������: {inventoryReport.Count}");
        }

        private void buttonGetInventoryTurnoverRate_Click(object sender, EventArgs e)
        {
            var turnoverRate = storeManager.GetInventoryTurnoverRate();
            MessageBox.Show($"�������� ������� �������� �������: {turnoverRate}");
        }

        private void buttonGetEmptyCellsCount_Click(object sender, EventArgs e)
        {
            var emptyCellsCount = storeManager.GetEmptyCellsCount();
            MessageBox.Show($"���������� ������ ����� �� ������: {emptyCellsCount}");
        }

        private void buttonGetTotalCapacity_Click(object sender, EventArgs e)
        {
            var totalCapacity = storeManager.GetTotalCapacity();
            MessageBox.Show($"����� ����������� ������: {totalCapacity}");
        }

        private void buttonGetRequestsByProduct_Click(object sender, EventArgs e)
        {
            string productName = "������ A"; // ������ �������� ������
            var requests = storeManager.GetRequestsByProduct(productName);
            MessageBox.Show($"������� ������: {requests.Count}");
        }

        private void buttonGetTotalRequestAmount_Click(object sender, EventArgs e)
        {
            string productName = "������ A"; // ������ �������� ������
            var totalRequestAmount = storeManager.GetTotalRequestAmount(productName);
            MessageBox.Show($"����� ����� ������: {totalRequestAmount}");
        }
    }
}
