namespace AutoPartsStore
{
    public partial class ProductsForm : Form
    {
        private StoreManager storeManager;

        public ProductsForm(StoreManager storeManager)
        {
            InitializeComponent();
            this.storeManager = storeManager;
            UpdateProductsListBox();
        }

        public void UpdateProductsListBox()
        {
            listBoxProducts.Items.Clear();
            foreach (var product in storeManager.Warehouse.Storage.Values)
            {
                listBoxProducts.Items.Add($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}, Supplier: {product.Supplier.Name}");
            }
        }
    }
}
