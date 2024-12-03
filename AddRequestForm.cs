using System;
using System.Linq;
using System.Windows.Forms;

namespace AutoPartsStore
{
    public partial class AddRequestForm : Form
    {
        private StoreManager storeManager;

        public Request Request { get; private set; }

        public AddRequestForm(StoreManager storeManager)
        {
            InitializeComponent();
            this.storeManager = storeManager;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int customerId = int.Parse(textBoxCustomerId.Text);
            string customerName = textBoxCustomerName.Text;
            int productId = int.Parse(textBoxProductId.Text);
            string productName = textBoxProductName.Text;
            decimal productPrice = decimal.Parse(textBoxProductPrice.Text);
            int productQuantity = int.Parse(textBoxProductQuantity.Text);
            int requestQuantity = int.Parse(textBoxRequestQuantity.Text);
            decimal totalAmount = decimal.Parse(textBoxTotalAmount.Text);

            Customer customer = storeManager.Customers.FirstOrDefault(c => c.Id == customerId);
            Product product = storeManager.Warehouse.Storage.Values.FirstOrDefault(p => p.Id == productId);

            if (customer != null && product != null)
            {
                Request request = new Request(customer, product, requestQuantity, totalAmount);
                Request = request;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Клиент или товар не найдены.");
            }
        }
    }
}
