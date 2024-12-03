namespace AutoPartsStore
{
    partial class CustomersForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxCustomers;

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
            this.listBoxCustomers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            //
            // listBoxCustomers
            //
            this.listBoxCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCustomers.FormattingEnabled = true;
            this.listBoxCustomers.Location = new System.Drawing.Point(0, 0);
            this.listBoxCustomers.Name = "listBoxCustomers";
            this.listBoxCustomers.Size = new System.Drawing.Size(768, 400);
            this.listBoxCustomers.TabIndex = 0;

            //
            // CustomersForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 400);
            this.Controls.Add(this.listBoxCustomers);
            this.Name = "CustomersForm";
            this.Text = "Клиенты";
            this.ResumeLayout(false);
        }
    }
}
