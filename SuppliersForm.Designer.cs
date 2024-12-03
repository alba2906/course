namespace AutoPartsStore
{
    partial class SuppliersForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxSuppliers;

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
            this.listBoxSuppliers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            //
            // listBoxSuppliers
            //
            this.listBoxSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSuppliers.FormattingEnabled = true;
            this.listBoxSuppliers.Location = new System.Drawing.Point(0, 0);
            this.listBoxSuppliers.Name = "listBoxSuppliers";
            this.listBoxSuppliers.Size = new System.Drawing.Size(768, 400);
            this.listBoxSuppliers.TabIndex = 0;

            //
            // SuppliersForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 400);
            this.Controls.Add(this.listBoxSuppliers);
            this.Name = "SuppliersForm";
            this.Text = "Поставщики";
            this.ResumeLayout(false);
        }
    }
}
