namespace AutoPartsStore
{
    public partial class SuppliersForm : Form
    {
        private StoreManager storeManager;

        public SuppliersForm(StoreManager storeManager)
        {
            InitializeComponent();
            this.storeManager = storeManager;
            UpdateSuppliersListBox();
        }

        public void UpdateSuppliersListBox()
        {
            listBoxSuppliers.Items.Clear();
            foreach (var supplier in storeManager.Suppliers)
            {
                listBoxSuppliers.Items.Add($"ID: {supplier.Id}, Name: {supplier.Name}, Country: {supplier.Country}, Type: {supplier.GetSupplierType()}");
            }
        }
    }
}