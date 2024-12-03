namespace AutoPartsStore
{
    partial class AddOrderForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelSupplierId;
        private System.Windows.Forms.Label labelProductCount;
        private System.Windows.Forms.Label labelProductIds;
        private System.Windows.Forms.Label labelProductNames;
        private System.Windows.Forms.Label labelProductPrices;
        private System.Windows.Forms.Label labelProductQuantities;
        private System.Windows.Forms.TextBox textBoxSupplierId;
        private System.Windows.Forms.TextBox textBoxProductCount;
        private System.Windows.Forms.TextBox textBoxProductIds;
        private System.Windows.Forms.TextBox textBoxProductNames;
        private System.Windows.Forms.TextBox textBoxProductPrices;
        private System.Windows.Forms.TextBox textBoxProductQuantities;
        private System.Windows.Forms.Button buttonAdd;

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
            this.labelSupplierId = new System.Windows.Forms.Label();
            this.labelProductCount = new System.Windows.Forms.Label();
            this.labelProductIds = new System.Windows.Forms.Label();
            this.labelProductNames = new System.Windows.Forms.Label();
            this.labelProductPrices = new System.Windows.Forms.Label();
            this.labelProductQuantities = new System.Windows.Forms.Label();
            this.textBoxSupplierId = new System.Windows.Forms.TextBox();
            this.textBoxProductCount = new System.Windows.Forms.TextBox();
            this.textBoxProductIds = new System.Windows.Forms.TextBox();
            this.textBoxProductNames = new System.Windows.Forms.TextBox();
            this.textBoxProductPrices = new System.Windows.Forms.TextBox();
            this.textBoxProductQuantities = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();

            //
            // labelSupplierId
            //
            this.labelSupplierId.AutoSize = true;
            this.labelSupplierId.Location = new System.Drawing.Point(12, 15);
            this.labelSupplierId.Name = "labelSupplierId";
            this.labelSupplierId.Size = new System.Drawing.Size(63, 13);
            this.labelSupplierId.TabIndex = 0;
            this.labelSupplierId.Text = "ID поставщика:";

            //
            // labelProductCount
            //
            this.labelProductCount.AutoSize = true;
            this.labelProductCount.Location = new System.Drawing.Point(12, 41);
            this.labelProductCount.Name = "labelProductCount";
            this.labelProductCount.Size = new System.Drawing.Size(78, 13);
            this.labelProductCount.TabIndex = 1;
            this.labelProductCount.Text = "Количество деталей:";

            //
            // labelProductIds
            //
            this.labelProductIds.AutoSize = true;
            this.labelProductIds.Location = new System.Drawing.Point(12, 67);
            this.labelProductIds.Name = "labelProductIds";
            this.labelProductIds.Size = new System.Drawing.Size(58, 13);
            this.labelProductIds.TabIndex = 2;
            this.labelProductIds.Text = "ID деталей:";

            //
            // labelProductNames
            //
            this.labelProductNames.AutoSize = true;
            this.labelProductNames.Location = new System.Drawing.Point(12, 93);
            this.labelProductNames.Name = "labelProductNames";
            this.labelProductNames.Size = new System.Drawing.Size(82, 13);
            this.labelProductNames.TabIndex = 3;
            this.labelProductNames.Text = "Название детали:";

            //
            // labelProductPrices
            //
            this.labelProductPrices.AutoSize = true;
            this.labelProductPrices.Location = new System.Drawing.Point(12, 119);
            this.labelProductPrices.Name = "labelProductPrices";
            this.labelProductPrices.Size = new System.Drawing.Size(77, 13);
            this.labelProductPrices.TabIndex = 4;
            this.labelProductPrices.Text = "Цена детали:";

            //
            // labelProductQuantities
            //
            this.labelProductQuantities.AutoSize = true;
            this.labelProductQuantities.Location = new System.Drawing.Point(12, 145);
            this.labelProductQuantities.Name = "labelProductQuantities";
            this.labelProductQuantities.Size = new System.Drawing.Size(89, 13);
            this.labelProductQuantities.TabIndex = 5;
            this.labelProductQuantities.Text = "Product Quantities:";

            //
            // textBoxSupplierId
            //
            this.textBoxSupplierId.Location = new System.Drawing.Point(105, 12);
            this.textBoxSupplierId.Name = "textBoxSupplierId";
            this.textBoxSupplierId.Size = new System.Drawing.Size(167, 20);
            this.textBoxSupplierId.TabIndex = 6;

            //
            // textBoxProductCount
            //
            this.textBoxProductCount.Location = new System.Drawing.Point(105, 38);
            this.textBoxProductCount.Name = "textBoxProductCount";
            this.textBoxProductCount.Size = new System.Drawing.Size(167, 20);
            this.textBoxProductCount.TabIndex = 7;

            //
            // textBoxProductIds
            //
            this.textBoxProductIds.Location = new System.Drawing.Point(105, 64);
            this.textBoxProductIds.Name = "textBoxProductIds";
            this.textBoxProductIds.Size = new System.Drawing.Size(167, 20);
            this.textBoxProductIds.TabIndex = 8;

            //
            // textBoxProductNames
            //
            this.textBoxProductNames.Location = new System.Drawing.Point(105, 90);
            this.textBoxProductNames.Name = "textBoxProductNames";
            this.textBoxProductNames.Size = new System.Drawing.Size(167, 20);
            this.textBoxProductNames.TabIndex = 9;

            //
            // textBoxProductPrices
            //
            this.textBoxProductPrices.Location = new System.Drawing.Point(105, 116);
            this.textBoxProductPrices.Name = "textBoxProductPrices";
            this.textBoxProductPrices.Size = new System.Drawing.Size(167, 20);
            this.textBoxProductPrices.TabIndex = 10;

            //
            // textBoxProductQuantities
            //
            this.textBoxProductQuantities.Location = new System.Drawing.Point(105, 142);
            this.textBoxProductQuantities.Name = "textBoxProductQuantities";
            this.textBoxProductQuantities.Size = new System.Drawing.Size(167, 20);
            this.textBoxProductQuantities.TabIndex = 11;

            //
            // buttonAdd
            //
            this.buttonAdd.Location = new System.Drawing.Point(180, 172);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(92, 23);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);

            //
            // AddOrderForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 207);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxProductQuantities);
            this.Controls.Add(this.textBoxProductPrices);
            this.Controls.Add(this.textBoxProductNames);
            this.Controls.Add(this.textBoxProductIds);
            this.Controls.Add(this.textBoxProductCount);
            this.Controls.Add(this.textBoxSupplierId);
            this.Controls.Add(this.labelProductQuantities);
            this.Controls.Add(this.labelProductPrices);
            this.Controls.Add(this.labelProductNames);
            this.Controls.Add(this.labelProductIds);
            this.Controls.Add(this.labelProductCount);
            this.Controls.Add(this.labelSupplierId);
            this.Name = "AddOrderForm";
            this.Text = "Добавить заказ";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
