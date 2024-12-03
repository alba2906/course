namespace AutoPartsStore
{
    public partial class AddOrderForm : Form
    {
        private StoreManager storeManager;
        public Order Order { get; private set; }

        public AddOrderForm(StoreManager storeManager)
        {
            InitializeComponent();
            this.storeManager = storeManager;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int supplierId = int.Parse(textBoxSupplierId.Text);
                int productCount = int.Parse(textBoxProductCount.Text);
                List<Product> products = new List<Product>();

                for (int i = 0; i < productCount; i++)
                {
                    int productId = int.Parse(textBoxProductIds.Lines[i]);
                    string productName = textBoxProductNames.Lines[i];
                    decimal productPrice = decimal.Parse(textBoxProductPrices.Lines[i]);
                    int productQuantity = int.Parse(textBoxProductQuantities.Lines[i]);

                    Supplier supplier = storeManager.Suppliers.Find(s => s.Id == supplierId);
                    if (supplier == null)
                    {
                        MessageBox.Show("Поставщик не найден.");
                        return;
                    }

                    Product product = new Product(productName, productPrice, productQuantity, supplier, productId);
                    products.Add(product);
                }

                Order order = new Order(products.First().Supplier, products);
                Order = order;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }



    }
}
