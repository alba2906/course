using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoPartsStore
{
    public partial class AddSupplierForm : Form
    {
        private StoreManager storeManager;

        public Supplier Supplier { get; private set; }

        public AddSupplierForm(StoreManager storeManager)
        {
            InitializeComponent();
            this.storeManager = storeManager;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBoxID.Text); // Преобразование строки в целое число
                string name = textBoxName.Text;
                string country = textBoxCountry.Text;
                string type = comboBoxType.SelectedItem.ToString();

                Supplier supplier = null;
                switch (type)
                {
                    case "Фирма":
                        supplier = new Manufacturer(id, name, country);
                        break;
                    case "Дилер":
                        supplier = new Dealer(id, name, country);
                        break;
                    case "Небольшое производство":
                        supplier = new SmallProduction(id, name, country);
                        break;
                    case "Магазин":
                        supplier = new SmallShop(id, name, country);
                        break;
                }

                if (supplier != null)
                {
                    Supplier = supplier;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный тип поставщика.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }


        private void AddSupplierForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
