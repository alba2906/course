namespace AutoPartsStore
{
    public partial class CustomersForm : Form
    {
        private StoreManager storeManager;

        public CustomersForm(StoreManager storeManager)
        {
            InitializeComponent();
            this.storeManager = storeManager;
            UpdateCustomersListBox();
        }

        public void UpdateCustomersListBox()
        {
            listBoxCustomers.Items.Clear();
            foreach (var customer in storeManager.Customers)
            {
                listBoxCustomers.Items.Add($"ID: {customer.Id}, Name: {customer.Name}, Orders: {string.Join(", ", customer.Orders.Select(o => o.Id))}");
            }
        }
    }
}
