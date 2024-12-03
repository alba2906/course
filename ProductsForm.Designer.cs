namespace AutoPartsStore
{
    partial class ProductsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxProducts;

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
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            //
            // listBoxProducts
            //
            this.listBoxProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.Location = new System.Drawing.Point(0, 0);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(768, 400);
            this.listBoxProducts.TabIndex = 0;

            //
            // ProductsForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 400);
            this.Controls.Add(this.listBoxProducts);
            this.Name = "ProductsForm";
            this.Text = "Товары";
            this.ResumeLayout(false);
        }
    }
}
