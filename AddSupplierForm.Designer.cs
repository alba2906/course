namespace AutoPartsStore
{
    partial class AddSupplierForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelName = new Label();
            labelCountry = new Label();
            labelType = new Label();
            textBoxName = new TextBox();
            textBoxCountry = new TextBox();
            comboBoxType = new ComboBox();
            buttonAdd = new Button();
            textBoxID = new TextBox();
            labelID = new Label();
            SuspendLayout();
            //
            // labelName
            //
            labelName.AutoSize = true;
            labelName.Location = new Point(28, 35);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(34, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Имя:";
            //
            // labelCountry
            //
            labelCountry.AutoSize = true;
            labelCountry.Location = new Point(14, 69);
            labelCountry.Margin = new Padding(4, 0, 4, 0);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(49, 15);
            labelCountry.TabIndex = 1;
            labelCountry.Text = "Страна:";
            //
            // labelType
            //
            labelType.AutoSize = true;
            labelType.Location = new Point(32, 111);
            labelType.Margin = new Padding(4, 0, 4, 0);
            labelType.Name = "labelType";
            labelType.Size = new Size(30, 15);
            labelType.TabIndex = 2;
            labelType.Text = "Тип:";
            //
            // textBoxName
            //
            textBoxName.Location = new Point(89, 32);
            textBoxName.Margin = new Padding(4, 3, 4, 3);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(233, 23);
            textBoxName.TabIndex = 3;
            //
            // textBoxCountry
            //
            textBoxCountry.Location = new Point(89, 69);
            textBoxCountry.Margin = new Padding(4, 3, 4, 3);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(233, 23);
            textBoxCountry.TabIndex = 4;
            //
            // comboBoxType
            //
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Фирма", "Дилер", "Небольшое производство", "Магазин" });
            comboBoxType.Location = new Point(89, 108);
            comboBoxType.Margin = new Padding(4, 3, 4, 3);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(233, 23);
            comboBoxType.TabIndex = 5;
            //
            // buttonAdd
            //
            buttonAdd.Location = new Point(201, 137);
            buttonAdd.Margin = new Padding(4, 3, 4, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(121, 27);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            //
            // textBoxID
            //
            textBoxID.Location = new Point(89, 3);
            textBoxID.Margin = new Padding(4, 3, 4, 3);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(233, 23);
            textBoxID.TabIndex = 7;
            //
            // labelID
            //
            labelID.AutoSize = true;
            labelID.Location = new Point(32, 11);
            labelID.Margin = new Padding(4, 0, 4, 0);
            labelID.Name = "labelID";
            labelID.Size = new Size(34, 15);
            labelID.TabIndex = 8;
            labelID.Text = "ID:";
            //
            // AddSupplierForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 167);
            Controls.Add(labelID);
            Controls.Add(textBoxID);
            Controls.Add(buttonAdd);
            Controls.Add(comboBoxType);
            Controls.Add(textBoxCountry);
            Controls.Add(textBoxName);
            Controls.Add(labelType);
            Controls.Add(labelCountry);
            Controls.Add(labelName);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddSupplierForm";
            Text = "Добавить поставщика";
            Load += AddSupplierForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
