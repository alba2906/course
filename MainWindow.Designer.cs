namespace AutoPartsStore
{
    partial class MainWindow
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonAddSupplier;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.Button buttonAddRequest;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Button buttonShowSuppliers;
        private System.Windows.Forms.Button buttonShowProducts;
        private System.Windows.Forms.Button buttonShowOrders;
        private System.Windows.Forms.Button buttonShowRequests;
        private System.Windows.Forms.Button buttonShowCustomers;
        private System.Windows.Forms.Button buttonGetSuppliersByCategoryAndProduct;
        private System.Windows.Forms.Button buttonGetProductDetails;
        private System.Windows.Forms.Button buttonGetCustomersByProduct;
        private System.Windows.Forms.Button buttonGetAllStoredProducts;
        private System.Windows.Forms.Button buttonGetTopSellingProducts;
        private System.Windows.Forms.Button buttonGetCheapestSuppliers;
        private System.Windows.Forms.Button buttonGetAverageSalesPerMonth;
        private System.Windows.Forms.Button buttonGetSupplierShare;
        private System.Windows.Forms.Button buttonGetOverheadCostsPercentage;
        private System.Windows.Forms.Button buttonGetUnsoldProducts;
        private System.Windows.Forms.Button buttonGetDefectiveProducts;
        private System.Windows.Forms.Button buttonGetSoldProducts;
        private System.Windows.Forms.Button buttonGetCashReport;
        private System.Windows.Forms.Button buttonGetInventoryReport;
        private System.Windows.Forms.Button buttonGetInventoryTurnoverRate;
        private System.Windows.Forms.Button buttonGetEmptyCellsCount;
        private System.Windows.Forms.Button buttonGetTotalCapacity;
        private System.Windows.Forms.Button buttonGetRequestsByProduct;
        private System.Windows.Forms.Button buttonGetTotalRequestAmount;

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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonAddSupplier = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.buttonAddRequest = new System.Windows.Forms.Button();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.buttonShowSuppliers = new System.Windows.Forms.Button();
            this.buttonShowProducts = new System.Windows.Forms.Button();
            this.buttonShowOrders = new System.Windows.Forms.Button();
            this.buttonShowRequests = new System.Windows.Forms.Button();
            this.buttonShowCustomers = new System.Windows.Forms.Button();
            this.buttonGetSuppliersByCategoryAndProduct = new System.Windows.Forms.Button();
            this.buttonGetProductDetails = new System.Windows.Forms.Button();
            this.buttonGetCustomersByProduct = new System.Windows.Forms.Button();
            this.buttonGetAllStoredProducts = new System.Windows.Forms.Button();
            this.buttonGetTopSellingProducts = new System.Windows.Forms.Button();
            this.buttonGetCheapestSuppliers = new System.Windows.Forms.Button();
            this.buttonGetAverageSalesPerMonth = new System.Windows.Forms.Button();
            this.buttonGetSupplierShare = new System.Windows.Forms.Button();
            this.buttonGetOverheadCostsPercentage = new System.Windows.Forms.Button();
            this.buttonGetUnsoldProducts = new System.Windows.Forms.Button();
            this.buttonGetDefectiveProducts = new System.Windows.Forms.Button();
            this.buttonGetSoldProducts = new System.Windows.Forms.Button();
            this.buttonGetCashReport = new System.Windows.Forms.Button();
            this.buttonGetInventoryReport = new System.Windows.Forms.Button();
            this.buttonGetInventoryTurnoverRate = new System.Windows.Forms.Button();
            this.buttonGetEmptyCellsCount = new System.Windows.Forms.Button();
            this.buttonGetTotalCapacity = new System.Windows.Forms.Button();
            this.buttonGetRequestsByProduct = new System.Windows.Forms.Button();
            this.buttonGetTotalRequestAmount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // buttonSave
            //
            this.buttonSave.Location = new System.Drawing.Point(12, 313);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            //
            // buttonLoad
            //
            this.buttonLoad.Location = new System.Drawing.Point(114, 313);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Загрузить";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            //
            // buttonAddSupplier
            //
            this.buttonAddSupplier.Location = new System.Drawing.Point(30, 32);
            this.buttonAddSupplier.Name = "buttonAddSupplier";
            this.buttonAddSupplier.Size = new System.Drawing.Size(150, 23);
            this.buttonAddSupplier.TabIndex = 3;
            this.buttonAddSupplier.Text = "Добавить поставщика";
            this.buttonAddSupplier.UseVisualStyleBackColor = true;
            this.buttonAddSupplier.Click += new System.EventHandler(this.buttonAddSupplier_Click);
            //
            // buttonAddProduct
            //
            this.buttonAddProduct.Location = new System.Drawing.Point(30, 70);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(150, 23);
            this.buttonAddProduct.TabIndex = 4;
            this.buttonAddProduct.Text = "Добавить товар";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            //
            // buttonAddOrder
            //
            this.buttonAddOrder.Location = new System.Drawing.Point(30, 108);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(150, 23);
            this.buttonAddOrder.TabIndex = 5;
            this.buttonAddOrder.Text = "Добавить заказ";
            this.buttonAddOrder.UseVisualStyleBackColor = true;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            //
            // buttonAddRequest
            //
            this.buttonAddRequest.Location = new System.Drawing.Point(30, 147);
            this.buttonAddRequest.Name = "buttonAddRequest";
            this.buttonAddRequest.Size = new System.Drawing.Size(150, 23);
            this.buttonAddRequest.TabIndex = 6;
            this.buttonAddRequest.Text = "Добавить заявку";
            this.buttonAddRequest.UseVisualStyleBackColor = true;
            this.buttonAddRequest.Click += new System.EventHandler(this.buttonAddRequest_Click);
            //
            // buttonAddCustomer
            //
            this.buttonAddCustomer.Location = new System.Drawing.Point(30, 186);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(150, 23);
            this.buttonAddCustomer.TabIndex = 7;
            this.buttonAddCustomer.Text = "Добавить клиента";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            //
            // buttonShowSuppliers
            //
            this.buttonShowSuppliers.Location = new System.Drawing.Point(242, 32);
            this.buttonShowSuppliers.Name = "buttonShowSuppliers";
            this.buttonShowSuppliers.Size = new System.Drawing.Size(150, 23);
            this.buttonShowSuppliers.TabIndex = 8;
            this.buttonShowSuppliers.Text = "Показать поставщиков";
            this.buttonShowSuppliers.UseVisualStyleBackColor = true;
            this.buttonShowSuppliers.Click += new System.EventHandler(this.buttonShowSuppliers_Click);
            //
            // buttonShowProducts
            //
            this.buttonShowProducts.Location = new System.Drawing.Point(242, 70);
            this.buttonShowProducts.Name = "buttonShowProducts";
            this.buttonShowProducts.Size = new System.Drawing.Size(150, 23);
            this.buttonShowProducts.TabIndex = 9;
            this.buttonShowProducts.Text = "Показать товары";
            this.buttonShowProducts.UseVisualStyleBackColor = true;
            this.buttonShowProducts.Click += new System.EventHandler(this.buttonShowProducts_Click);
            //
            // buttonShowOrders
            //
            this.buttonShowOrders.Location = new System.Drawing.Point(242, 108);
            this.buttonShowOrders.Name = "buttonShowOrders";
            this.buttonShowOrders.Size = new System.Drawing.Size(150, 23);
            this.buttonShowOrders.TabIndex = 10;
            this.buttonShowOrders.Text = "Показать заказы";
            this.buttonShowOrders.UseVisualStyleBackColor = true;
            this.buttonShowOrders.Click += new System.EventHandler(this.buttonShowOrders_Click);
            //
            // buttonShowRequests
            //
            this.buttonShowRequests.Location = new System.Drawing.Point(242, 147);
            this.buttonShowRequests.Name = "buttonShowRequests";
            this.buttonShowRequests.Size = new System.Drawing.Size(150, 23);
            this.buttonShowRequests.TabIndex = 11;
            this.buttonShowRequests.Text = "Показать заявки";
            this.buttonShowRequests.UseVisualStyleBackColor = true;
            this.buttonShowRequests.Click += new System.EventHandler(this.buttonShowRequests_Click);
            //
            // buttonShowCustomers
            //
            this.buttonShowCustomers.Location = new System.Drawing.Point(242, 186);
            this.buttonShowCustomers.Name = "buttonShowCustomers";
            this.buttonShowCustomers.Size = new System.Drawing.Size(150, 23);
            this.buttonShowCustomers.TabIndex = 12;
            this.buttonShowCustomers.Text = "Показать клиентов";
            this.buttonShowCustomers.UseVisualStyleBackColor = true;
            this.buttonShowCustomers.Click += new System.EventHandler(this.buttonShowCustomers_Click);
            //
            // buttonGetSuppliersByCategoryAndProduct
            //
            this.buttonGetSuppliersByCategoryAndProduct.Location = new System.Drawing.Point(452, 32);
            this.buttonGetSuppliersByCategoryAndProduct.Name = "buttonGetSuppliersByCategoryAndProduct";
            this.buttonGetSuppliersByCategoryAndProduct.Size = new System.Drawing.Size(200, 23);
            this.buttonGetSuppliersByCategoryAndProduct.TabIndex = 13;
            this.buttonGetSuppliersByCategoryAndProduct.Text = "Получить поставщиков по категории и товару";
            this.buttonGetSuppliersByCategoryAndProduct.UseVisualStyleBackColor = true;
            this.buttonGetSuppliersByCategoryAndProduct.Click += new System.EventHandler(this.buttonGetSuppliersByCategoryAndProduct_Click);
            //
            // buttonGetProductDetails
            //
            this.buttonGetProductDetails.Location = new System.Drawing.Point(452, 70);
            this.buttonGetProductDetails.Name = "buttonGetProductDetails";
            this.buttonGetProductDetails.Size = new System.Drawing.Size(200, 23);
            this.buttonGetProductDetails.TabIndex = 14;
            this.buttonGetProductDetails.Text = "Получить детали товара";
            this.buttonGetProductDetails.UseVisualStyleBackColor = true;
            this.buttonGetProductDetails.Click += new System.EventHandler(this.buttonGetProductDetails_Click);
            //
            // buttonGetCustomersByProduct
            //
            this.buttonGetCustomersByProduct.Location = new System.Drawing.Point(452, 108);
            this.buttonGetCustomersByProduct.Name = "buttonGetCustomersByProduct";
            this.buttonGetCustomersByProduct.Size = new System.Drawing.Size(200, 23);
            this.buttonGetCustomersByProduct.TabIndex = 15;
            this.buttonGetCustomersByProduct.Text = "Получить покупателей по товару";
            this.buttonGetCustomersByProduct.UseVisualStyleBackColor = true;
            this.buttonGetCustomersByProduct.Click += new System.EventHandler(this.buttonGetCustomersByProduct_Click);
            //
            // buttonGetAllStoredProducts
            //
            this.buttonGetAllStoredProducts.Location = new System.Drawing.Point(452, 147);
            this.buttonGetAllStoredProducts.Name = "buttonGetAllStoredProducts";
            this.buttonGetAllStoredProducts.Size = new System.Drawing.Size(200, 23);
            this.buttonGetAllStoredProducts.TabIndex = 16;
            this.buttonGetAllStoredProducts.Text = "Получить все товары на складе";
            this.buttonGetAllStoredProducts.UseVisualStyleBackColor = true;
            this.buttonGetAllStoredProducts.Click += new System.EventHandler(this.buttonGetAllStoredProducts_Click);
            //
            // buttonGetTopSellingProducts
            //
            this.buttonGetTopSellingProducts.Location = new System.Drawing.Point(452, 186);
            this.buttonGetTopSellingProducts.Name = "buttonGetTopSellingProducts";
            this.buttonGetTopSellingProducts.Size = new System.Drawing.Size(200, 23);
            this.buttonGetTopSellingProducts.TabIndex = 17;
            this.buttonGetTopSellingProducts.Text = "Получить самые продаваемые товары";
            this.buttonGetTopSellingProducts.UseVisualStyleBackColor = true;
            this.buttonGetTopSellingProducts.Click += new System.EventHandler(this.buttonGetTopSellingProducts_Click);
            //
            // buttonGetCheapestSuppliers
            //
            this.buttonGetCheapestSuppliers.Location = new System.Drawing.Point(452, 225);
            this.buttonGetCheapestSuppliers.Name = "buttonGetCheapestSuppliers";
            this.buttonGetCheapestSuppliers.Size = new System.Drawing.Size(200, 23);
            this.buttonGetCheapestSuppliers.TabIndex = 18;
            this.buttonGetCheapestSuppliers.Text = "Получить самых дешевых поставщиков";
            this.buttonGetCheapestSuppliers.UseVisualStyleBackColor = true;
            this.buttonGetCheapestSuppliers.Click += new System.EventHandler(this.buttonGetCheapestSuppliers_Click);
            //
            // buttonGetAverageSalesPerMonth
            //
            this.buttonGetAverageSalesPerMonth.Location = new System.Drawing.Point(452, 264);
            this.buttonGetAverageSalesPerMonth.Name = "buttonGetAverageSalesPerMonth";
            this.buttonGetAverageSalesPerMonth.Size = new System.Drawing.Size(200, 23);
            this.buttonGetAverageSalesPerMonth.TabIndex = 19;
            this.buttonGetAverageSalesPerMonth.Text = "Получить среднее число продаж на месяц";
            this.buttonGetAverageSalesPerMonth.UseVisualStyleBackColor = true;
            this.buttonGetAverageSalesPerMonth.Click += new System.EventHandler(this.buttonGetAverageSalesPerMonth_Click);
            //
            // buttonGetSupplierShare
            //
            this.buttonGetSupplierShare.Location = new System.Drawing.Point(452, 303);
            this.buttonGetSupplierShare.Name = "buttonGetSupplierShare";
            this.buttonGetSupplierShare.Size = new System.Drawing.Size(200, 23);
            this.buttonGetSupplierShare.TabIndex = 20;
            this.buttonGetSupplierShare.Text = "Получить долю поставщика";
            this.buttonGetSupplierShare.UseVisualStyleBackColor = true;
            this.buttonGetSupplierShare.Click += new System.EventHandler(this.buttonGetSupplierShare_Click);
            //
            // buttonGetOverheadCostsPercentage
            //
            this.buttonGetOverheadCostsPercentage.Location = new System.Drawing.Point(452, 342);
            this.buttonGetOverheadCostsPercentage.Name = "buttonGetOverheadCostsPercentage";
            this.buttonGetOverheadCostsPercentage.Size = new System.Drawing.Size(200, 23);
            this.buttonGetOverheadCostsPercentage.TabIndex = 21;
            this.buttonGetOverheadCostsPercentage.Text = "Получить накладные расходы в процентах";
            this.buttonGetOverheadCostsPercentage.UseVisualStyleBackColor = true;
            this.buttonGetOverheadCostsPercentage.Click += new System.EventHandler(this.buttonGetOverheadCostsPercentage_Click);
            //
            // buttonGetUnsoldProducts
            //
            this.buttonGetUnsoldProducts.Location = new System.Drawing.Point(452, 381);
            this.buttonGetUnsoldProducts.Name = "buttonGetUnsoldProducts";
            this.buttonGetUnsoldProducts.Size = new System.Drawing.Size(200, 23);
            this.buttonGetUnsoldProducts.TabIndex = 22;
            this.buttonGetUnsoldProducts.Text = "Получить непроданные товары";
            this.buttonGetUnsoldProducts.UseVisualStyleBackColor = true;
            this.buttonGetUnsoldProducts.Click += new System.EventHandler(this.buttonGetUnsoldProducts_Click);
            //
            // buttonGetDefectiveProducts
            //
            this.buttonGetDefectiveProducts.Location = new System.Drawing.Point(452, 420);
            this.buttonGetDefectiveProducts.Name = "buttonGetDefectiveProducts";
            this.buttonGetDefectiveProducts.Size = new System.Drawing.Size(200, 23);
            this.buttonGetDefectiveProducts.TabIndex = 23;
            this.buttonGetDefectiveProducts.Text = "Получить бракованные товары";
            this.buttonGetDefectiveProducts.UseVisualStyleBackColor = true;
            this.buttonGetDefectiveProducts.Click += new System.EventHandler(this.buttonGetDefectiveProducts_Click);
            //
            // buttonGetSoldProducts
            //
            this.buttonGetSoldProducts.Location = new System.Drawing.Point(452, 459);
            this.buttonGetSoldProducts.Name = "buttonGetSoldProducts";
            this.buttonGetSoldProducts.Size = new System.Drawing.Size(200, 23);
            this.buttonGetSoldProducts.TabIndex = 24;
            this.buttonGetSoldProducts.Text = "Получить проданные товары";
            this.buttonGetSoldProducts.UseVisualStyleBackColor = true;
            this.buttonGetSoldProducts.Click += new System.EventHandler(this.buttonGetSoldProducts_Click);
            //
            // buttonGetCashReport
            //
            this.buttonGetCashReport.Location = new System.Drawing.Point(452, 498);
            this.buttonGetCashReport.Name = "buttonGetCashReport";
            this.buttonGetCashReport.Size = new System.Drawing.Size(200, 23);
            this.buttonGetCashReport.TabIndex = 25;
            this.buttonGetCashReport.Text = "Получить кассовый отчет";
            this.buttonGetCashReport.UseVisualStyleBackColor = true;
            this.buttonGetCashReport.Click += new System.EventHandler(this.buttonGetCashReport_Click);
            //
            // buttonGetInventoryReport
            //
            this.buttonGetInventoryReport.Location = new System.Drawing.Point(452, 537);
            this.buttonGetInventoryReport.Name = "buttonGetInventoryReport";
            this.buttonGetInventoryReport.Size = new System.Drawing.Size(200, 23);
            this.buttonGetInventoryReport.TabIndex = 26;
            this.buttonGetInventoryReport.Text = "Получить инвентаризационную ведомость";
            this.buttonGetInventoryReport.UseVisualStyleBackColor = true;
            this.buttonGetInventoryReport.Click += new System.EventHandler(this.buttonGetInventoryReport_Click);
            //
            // buttonGetInventoryTurnoverRate
            //
            this.buttonGetInventoryTurnoverRate.Location = new System.Drawing.Point(452, 576);
            this.buttonGetInventoryTurnoverRate.Name = "buttonGetInventoryTurnoverRate";
            this.buttonGetInventoryTurnoverRate.Size = new System.Drawing.Size(200, 23);
            this.buttonGetInventoryTurnoverRate.TabIndex = 27;
            this.buttonGetInventoryTurnoverRate.Text = "Получить скорость оборота средств";
            this.buttonGetInventoryTurnoverRate.UseVisualStyleBackColor = true;
            this.buttonGetInventoryTurnoverRate.Click += new System.EventHandler(this.buttonGetInventoryTurnoverRate_Click);
            //
            // buttonGetEmptyCellsCount
            //
            this.buttonGetEmptyCellsCount.Location = new System.Drawing.Point(452, 615);
            this.buttonGetEmptyCellsCount.Name = "buttonGetEmptyCellsCount";
            this.buttonGetEmptyCellsCount.Size = new System.Drawing.Size(200, 23);
            this.buttonGetEmptyCellsCount.TabIndex = 28;
            this.buttonGetEmptyCellsCount.Text = "Получить количество пустых ячеек";
            this.buttonGetEmptyCellsCount.UseVisualStyleBackColor = true;
            this.buttonGetEmptyCellsCount.Click += new System.EventHandler(this.buttonGetEmptyCellsCount_Click);
            //
            // buttonGetTotalCapacity
            //
            this.buttonGetTotalCapacity.Location = new System.Drawing.Point(452, 654);
            this.buttonGetTotalCapacity.Name = "buttonGetTotalCapacity";
            this.buttonGetTotalCapacity.Size = new System.Drawing.Size(200, 23);
            this.buttonGetTotalCapacity.TabIndex = 29;
            this.buttonGetTotalCapacity.Text = "Получить общую вместимость склада";
            this.buttonGetTotalCapacity.UseVisualStyleBackColor = true;
            this.buttonGetTotalCapacity.Click += new System.EventHandler(this.buttonGetTotalCapacity_Click);
            //
            // buttonGetRequestsByProduct
            //
            this.buttonGetRequestsByProduct.Location = new System.Drawing.Point(452, 693);
            this.buttonGetRequestsByProduct.Name = "buttonGetRequestsByProduct";
            this.buttonGetRequestsByProduct.Size = new System.Drawing.Size(200, 23);
            this.buttonGetRequestsByProduct.TabIndex = 30;
            this.buttonGetRequestsByProduct.Text = "Получить заявки по товару";
            this.buttonGetRequestsByProduct.UseVisualStyleBackColor = true;
            this.buttonGetRequestsByProduct.Click += new System.EventHandler(this.buttonGetRequestsByProduct_Click);
            //
            // buttonGetTotalRequestAmount
            //
            this.buttonGetTotalRequestAmount.Location = new System.Drawing.Point(452, 732);
            this.buttonGetTotalRequestAmount.Name = "buttonGetTotalRequestAmount";
            this.buttonGetTotalRequestAmount.Size = new System.Drawing.Size(200, 23);
            this.buttonGetTotalRequestAmount.TabIndex = 31;
            this.buttonGetTotalRequestAmount.Text = "Получить общую сумму заявок";
            this.buttonGetTotalRequestAmount.UseVisualStyleBackColor = true;
            this.buttonGetTotalRequestAmount.Click += new System.EventHandler(this.buttonGetTotalRequestAmount_Click);
            //
            // MainWindow
            //
            this.ClientSize = new System.Drawing.Size(818, 775);
            this.Controls.Add(this.buttonGetTotalRequestAmount);
            this.Controls.Add(this.buttonGetRequestsByProduct);
            this.Controls.Add(this.buttonGetTotalCapacity);
            this.Controls.Add(this.buttonGetEmptyCellsCount);
            this.Controls.Add(this.buttonGetInventoryTurnoverRate);
            this.Controls.Add(this.buttonGetInventoryReport);
            this.Controls.Add(this.buttonGetCashReport);
            this.Controls.Add(this.buttonGetSoldProducts);
            this.Controls.Add(this.buttonGetDefectiveProducts);
            this.Controls.Add(this.buttonGetUnsoldProducts);
            this.Controls.Add(this.buttonGetOverheadCostsPercentage);
            this.Controls.Add(this.buttonGetSupplierShare);
            this.Controls.Add(this.buttonGetAverageSalesPerMonth);
            this.Controls.Add(this.buttonGetCheapestSuppliers);
            this.Controls.Add(this.buttonGetTopSellingProducts);
            this.Controls.Add(this.buttonGetAllStoredProducts);
            this.Controls.Add(this.buttonGetCustomersByProduct);
            this.Controls.Add(this.buttonGetProductDetails);
            this.Controls.Add(this.buttonGetSuppliersByCategoryAndProduct);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonAddSupplier);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.buttonAddOrder);
            this.Controls.Add(this.buttonAddRequest);
            this.Controls.Add(this.buttonAddCustomer);
            this.Controls.Add(this.buttonShowSuppliers);
            this.Controls.Add(this.buttonShowProducts);
            this.Controls.Add(this.buttonShowOrders);
            this.Controls.Add(this.buttonShowRequests);
            this.Controls.Add(this.buttonShowCustomers);
            this.Name = "MainWindow";
            this.Text = "Магазин автозапчастей";
            this.ResumeLayout(false);
        }
    }
}
