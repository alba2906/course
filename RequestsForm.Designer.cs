namespace AutoPartsStore
{
    partial class RequestsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxRequests;

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
            this.listBoxRequests = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            //
            // listBoxRequests
            //
            this.listBoxRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxRequests.FormattingEnabled = true;
            this.listBoxRequests.Location = new System.Drawing.Point(0, 0);
            this.listBoxRequests.Name = "listBoxRequests";
            this.listBoxRequests.Size = new System.Drawing.Size(768, 400);
            this.listBoxRequests.TabIndex = 0;

            //
            // RequestsForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 400);
            this.Controls.Add(this.listBoxRequests);
            this.Name = "RequestsForm";
            this.Text = "Заявки";
            this.ResumeLayout(false);
        }
    }
}
