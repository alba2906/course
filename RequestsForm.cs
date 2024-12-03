namespace AutoPartsStore
{
    public partial class RequestsForm : Form
    {
        private StoreManager storeManager;

        public RequestsForm(StoreManager storeManager)
        {
            InitializeComponent();
            this.storeManager = storeManager;
            UpdateRequestsListBox();
        }

        public void UpdateRequestsListBox()
        {
            listBoxRequests.Items.Clear();
            foreach (var request in storeManager.Requests)
            {
                listBoxRequests.Items.Add($"ID: {request.Id}, Customer: {request.Customer.Name}, Product: {request.Product.Name}, Quantity: {request.Quantity}, Total Amount: {request.TotalAmount}");
            }
        }
    }
}