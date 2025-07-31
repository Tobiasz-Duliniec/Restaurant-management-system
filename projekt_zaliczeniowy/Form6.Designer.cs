namespace projekt_zaliczeniowy
{
    partial class Form6
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
            labelOrderDetails = new Label();
            labelOrderAddress = new Label();
            labelOrderStatus = new Label();
            listViewDishInformation = new ListView();
            columnHeaderDishName = new ColumnHeader();
            columnHeaderDishQuantity = new ColumnHeader();
            labelDestinationAddress = new Label();
            labelStatus = new Label();
            SuspendLayout();
            // 
            // labelOrderDetails
            // 
            labelOrderDetails.AutoSize = true;
            labelOrderDetails.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOrderDetails.Location = new Point(318, 60);
            labelOrderDetails.Name = "labelOrderDetails";
            labelOrderDetails.Size = new Size(132, 30);
            labelOrderDetails.TabIndex = 0;
            labelOrderDetails.Text = "Order details";
            // 
            // labelOrderAddress
            // 
            labelOrderAddress.AutoSize = true;
            labelOrderAddress.Location = new Point(214, 112);
            labelOrderAddress.Name = "labelOrderAddress";
            labelOrderAddress.Size = new Size(110, 15);
            labelOrderAddress.TabIndex = 1;
            labelOrderAddress.Text = "Destination address";
            // 
            // labelOrderStatus
            // 
            labelOrderStatus.AutoSize = true;
            labelOrderStatus.Location = new Point(214, 154);
            labelOrderStatus.Name = "labelOrderStatus";
            labelOrderStatus.Size = new Size(39, 15);
            labelOrderStatus.TabIndex = 2;
            labelOrderStatus.Text = "Status";
            // 
            // listViewDishInformation
            // 
            listViewDishInformation.Columns.AddRange(new ColumnHeader[] { columnHeaderDishName, columnHeaderDishQuantity });
            listViewDishInformation.GridLines = true;
            listViewDishInformation.Location = new Point(214, 196);
            listViewDishInformation.Name = "listViewDishInformation";
            listViewDishInformation.Size = new Size(350, 210);
            listViewDishInformation.TabIndex = 3;
            listViewDishInformation.UseCompatibleStateImageBehavior = false;
            listViewDishInformation.View = View.Details;
            // 
            // columnHeaderDishName
            // 
            columnHeaderDishName.Text = "Dish";
            columnHeaderDishName.Width = 175;
            // 
            // columnHeaderDishQuantity
            // 
            columnHeaderDishQuantity.Text = "Quantity";
            columnHeaderDishQuantity.Width = 175;
            // 
            // labelDestinationAddress
            // 
            labelDestinationAddress.AutoSize = true;
            labelDestinationAddress.Location = new Point(371, 112);
            labelDestinationAddress.Name = "labelDestinationAddress";
            labelDestinationAddress.Size = new Size(22, 15);
            labelDestinationAddress.TabIndex = 4;
            labelDestinationAddress.Text = "---";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(371, 154);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(22, 15);
            labelStatus.TabIndex = 5;
            labelStatus.Text = "---";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelStatus);
            Controls.Add(labelDestinationAddress);
            Controls.Add(listViewDishInformation);
            Controls.Add(labelOrderStatus);
            Controls.Add(labelOrderAddress);
            Controls.Add(labelOrderDetails);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelOrderDetails;
        private Label labelOrderAddress;
        private Label labelOrderStatus;
        private ListView listViewDishInformation;
        private ColumnHeader columnHeaderDishName;
        private ColumnHeader columnHeaderDishQuantity;
        private Label labelDestinationAddress;
        private Label labelStatus;
    }
}