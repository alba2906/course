using System;
using System.Windows.Forms;

namespace AutoPartsStore
{
    public partial class AddProductForm : Form
    {
        private StoreManager storeManager;

        public Product Product { get; private set; }

        public AddProductForm(StoreManager storeManager)
        {
            InitializeComponent();
            this.storeManager = storeManager;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            decimal price = decimal.Parse(textBoxPrice.Text);
            int quantity = int.Parse(textBoxQuantity.Text);
            int supplierId = int.Parse(textBoxSupplierId.Text);

            Supplier supplier = storeManager.Suppliers.Find(s => s.Id == supplierId);
            if (supplier == null)
            {
                MessageBox.Show("Поставщик не найден.");
                return;
            }

            Product product = new Product(name, price, quantity, supplier);
            Product = product;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}




