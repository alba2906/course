namespace AutoPartsStore
{
    public partial class OrdersForm : Form
    {
        private StoreManager storeManager;

        public OrdersForm(StoreManager storeManager)
        {
            InitializeComponent();
            this.storeManager = storeManager;
            UpdateOrdersListBox();
        }

        public void UpdateOrdersListBox()
        {
            listBoxOrders.Items.Clear();
            foreach (var order in storeManager.Orders)
            {
                listBoxOrders.Items.Add($"ID: {order.Id}, Date: {order.OrderDate}, Supplier: {order.Supplier.Name}, Products: {string.Join(", ", order.Products.Select(p => p.Name))}");
            }
        }
    }
}