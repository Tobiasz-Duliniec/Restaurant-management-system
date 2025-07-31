namespace projekt_zaliczeniowy
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelOrder = new Label();
            buttonOrderFood = new Button();
            buttonShowReceipt = new Button();
            listViewOrderList = new ListView();
            columnHeaderOrderId = new ColumnHeader();
            columnHeaderDestinationAddress = new ColumnHeader();
            columnHeaderStatus = new ColumnHeader();
            buttonOrderDetails = new Button();
            buttonEditOrder = new Button();
            buttonSaveOrdersToFile = new Button();
            SuspendLayout();
            // 
            // labelOrder
            // 
            labelOrder.AutoSize = true;
            labelOrder.BorderStyle = BorderStyle.Fixed3D;
            labelOrder.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOrder.Location = new Point(309, 24);
            labelOrder.Name = "labelOrder";
            labelOrder.Size = new Size(153, 67);
            labelOrder.TabIndex = 0;
            labelOrder.Text = "Order";
            labelOrder.Click += labelOrder_Click;
            // 
            // buttonOrderFood
            // 
            buttonOrderFood.Location = new Point(122, 310);
            buttonOrderFood.Name = "buttonOrderFood";
            buttonOrderFood.Size = new Size(149, 52);
            buttonOrderFood.TabIndex = 1;
            buttonOrderFood.Text = "New order";
            buttonOrderFood.UseVisualStyleBackColor = true;
            buttonOrderFood.Click += buttonOrderFood_Click;
            // 
            // buttonShowReceipt
            // 
            buttonShowReceipt.Location = new Point(473, 310);
            buttonShowReceipt.Name = "buttonShowReceipt";
            buttonShowReceipt.Size = new Size(149, 52);
            buttonShowReceipt.TabIndex = 2;
            buttonShowReceipt.Text = "Show receipt";
            buttonShowReceipt.UseVisualStyleBackColor = true;
            buttonShowReceipt.Click += buttonShowReceipt_Click;
            // 
            // listViewOrderList
            // 
            listViewOrderList.Columns.AddRange(new ColumnHeader[] { columnHeaderOrderId, columnHeaderDestinationAddress, columnHeaderStatus });
            listViewOrderList.FullRowSelect = true;
            listViewOrderList.GridLines = true;
            listViewOrderList.Location = new Point(122, 115);
            listViewOrderList.Name = "listViewOrderList";
            listViewOrderList.Size = new Size(500, 177);
            listViewOrderList.TabIndex = 5;
            listViewOrderList.UseCompatibleStateImageBehavior = false;
            listViewOrderList.View = View.Details;
            // 
            // columnHeaderOrderId
            // 
            columnHeaderOrderId.Text = "Id";
            // 
            // columnHeaderDestinationAddress
            // 
            columnHeaderDestinationAddress.Text = "Destination address";
            columnHeaderDestinationAddress.Width = 220;
            // 
            // columnHeaderStatus
            // 
            columnHeaderStatus.Text = "Status";
            columnHeaderStatus.Width = 220;
            // 
            // buttonOrderDetails
            // 
            buttonOrderDetails.Location = new Point(299, 310);
            buttonOrderDetails.Name = "buttonOrderDetails";
            buttonOrderDetails.Size = new Size(149, 52);
            buttonOrderDetails.TabIndex = 6;
            buttonOrderDetails.Text = "View order details";
            buttonOrderDetails.UseVisualStyleBackColor = true;
            buttonOrderDetails.Click += buttonOrderDetails_Click;
            // 
            // buttonEditOrder
            // 
            buttonEditOrder.Location = new Point(122, 368);
            buttonEditOrder.Name = "buttonEditOrder";
            buttonEditOrder.Size = new Size(149, 52);
            buttonEditOrder.TabIndex = 7;
            buttonEditOrder.Text = "Edit order";
            buttonEditOrder.UseVisualStyleBackColor = true;
            buttonEditOrder.Click += buttonEditOrder_Click;
            // 
            // buttonSaveOrdersToFile
            // 
            buttonSaveOrdersToFile.Location = new Point(473, 368);
            buttonSaveOrdersToFile.Name = "buttonSaveOrdersToFile";
            buttonSaveOrdersToFile.Size = new Size(149, 52);
            buttonSaveOrdersToFile.TabIndex = 8;
            buttonSaveOrdersToFile.Text = "Save orders to file";
            buttonSaveOrdersToFile.UseVisualStyleBackColor = true;
            buttonSaveOrdersToFile.Click += buttonSaveOrdersToFile_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSaveOrdersToFile);
            Controls.Add(buttonEditOrder);
            Controls.Add(buttonOrderDetails);
            Controls.Add(listViewOrderList);
            Controls.Add(buttonShowReceipt);
            Controls.Add(buttonOrderFood);
            Controls.Add(labelOrder);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelOrder;
        private Button buttonOrderFood;
        private Button buttonShowReceipt;
        private ListView listViewOrderList;
        private Button buttonOrderDetails;
        private ColumnHeader columnHeaderDestinationAddress;
        private ColumnHeader columnHeaderOrderId;
        private ColumnHeader columnHeaderStatus;
        private Button buttonEditOrder;
        private Button buttonSaveOrdersToFile;
    }
}