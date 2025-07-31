namespace projekt_zaliczeniowy
{
    partial class Form7
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
            labelOrderReceipt = new Label();
            listViewOrderDetails = new ListView();
            columnHeaderDish = new ColumnHeader();
            columnHeaderDishQuantity = new ColumnHeader();
            columnHeaderDishPrice = new ColumnHeader();
            labelTotalCost = new Label();
            labelTotalCostValue = new Label();
            SuspendLayout();
            // 
            // labelOrderReceipt
            // 
            labelOrderReceipt.AutoSize = true;
            labelOrderReceipt.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOrderReceipt.Location = new Point(392, 74);
            labelOrderReceipt.Name = "labelOrderReceipt";
            labelOrderReceipt.Size = new Size(81, 30);
            labelOrderReceipt.TabIndex = 0;
            labelOrderReceipt.Text = "Receipt";
            // 
            // listViewOrderDetails
            // 
            listViewOrderDetails.Columns.AddRange(new ColumnHeader[] { columnHeaderDish, columnHeaderDishQuantity, columnHeaderDishPrice });
            listViewOrderDetails.Location = new Point(283, 134);
            listViewOrderDetails.Name = "listViewOrderDetails";
            listViewOrderDetails.Size = new Size(300, 178);
            listViewOrderDetails.TabIndex = 1;
            listViewOrderDetails.UseCompatibleStateImageBehavior = false;
            listViewOrderDetails.View = View.Details;
            // 
            // columnHeaderDish
            // 
            columnHeaderDish.Text = "Dish";
            columnHeaderDish.Width = 100;
            // 
            // columnHeaderDishQuantity
            // 
            columnHeaderDishQuantity.Text = "Quantity";
            columnHeaderDishQuantity.Width = 100;
            // 
            // columnHeaderDishPrice
            // 
            columnHeaderDishPrice.Text = "Price";
            columnHeaderDishPrice.Width = 100;
            // 
            // labelTotalCost
            // 
            labelTotalCost.AutoSize = true;
            labelTotalCost.Location = new Point(392, 315);
            labelTotalCost.Name = "labelTotalCost";
            labelTotalCost.Size = new Size(60, 15);
            labelTotalCost.TabIndex = 2;
            labelTotalCost.Text = "Total cost:";
            // 
            // labelTotalCostValue
            // 
            labelTotalCostValue.AutoSize = true;
            labelTotalCostValue.Location = new Point(467, 315);
            labelTotalCostValue.Name = "labelTotalCostValue";
            labelTotalCostValue.Size = new Size(22, 15);
            labelTotalCostValue.TabIndex = 3;
            labelTotalCostValue.Text = "---";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelTotalCostValue);
            Controls.Add(labelTotalCost);
            Controls.Add(listViewOrderDetails);
            Controls.Add(labelOrderReceipt);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelOrderReceipt;
        private ListView listViewOrderDetails;
        private ColumnHeader columnHeaderDish;
        private ColumnHeader columnHeaderDishQuantity;
        private Label labelTotalCost;
        private Label labelTotalCostValue;
        private ColumnHeader columnHeaderDishPrice;
    }
}