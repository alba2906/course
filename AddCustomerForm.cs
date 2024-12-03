using System;
using System.Windows.Forms;

namespace AutoPartsStore
{
    public partial class AddCustomerForm : Form
    {
        private StoreManager storeManager;

        public Customer Customer { get; private set; }

        public AddCustomerForm(StoreManager storeManager)
        {
            InitializeComponent();
            this.storeManager = storeManager;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            Customer customer = new Customer(name);
            Customer = customer;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
