namespace AutoPartsStore
{
    partial class OrdersForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxOrders;

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
            this.listBoxOrders = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            //
            // listBoxOrders
            //
            this.listBoxOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxOrders.FormattingEnabled = true;
            this.listBoxOrders.Location = new System.Drawing.Point(0, 0);
            this.listBoxOrders.Name = "listBoxOrders";
            this.listBoxOrders.Size = new System.Drawing.Size(768, 400);
            this.listBoxOrders.TabIndex = 0;

            //
            // OrdersForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 400);
            this.Controls.Add(this.listBoxOrders);
            this.Name = "OrdersForm";
            this.Text = "Заказы";
            this.ResumeLayout(false);
        }
    }
}
