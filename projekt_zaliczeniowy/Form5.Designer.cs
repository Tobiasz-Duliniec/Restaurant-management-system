namespace projekt_zaliczeniowy
{
    partial class Form5
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
            listViewOrderableFood = new ListView();
            columnHeaderOrderableDishName = new ColumnHeader();
            columnHeaderOrderableDishDescription = new ColumnHeader();
            columnHeaderOrderableDishPrice = new ColumnHeader();
            listViewOrderedFood = new ListView();
            columnHeaderOrderDishName = new ColumnHeader();
            columnHeaderCount = new ColumnHeader();
            buttonSaveOrder = new Button();
            buttonAddToCart = new Button();
            groupBoxAddressInfo = new GroupBox();
            checkBoxPickup = new CheckBox();
            labelAddress = new Label();
            comboBoxAddressSelect = new ComboBox();
            comboBoxStatusSelector = new ComboBox();
            labelOrderStatus = new Label();
            groupBoxAddressInfo.SuspendLayout();
            SuspendLayout();
            // 
            // listViewOrderableFood
            // 
            listViewOrderableFood.Columns.AddRange(new ColumnHeader[] { columnHeaderOrderableDishName, columnHeaderOrderableDishDescription, columnHeaderOrderableDishPrice });
            listViewOrderableFood.FullRowSelect = true;
            listViewOrderableFood.GridLines = true;
            listViewOrderableFood.Location = new Point(47, 131);
            listViewOrderableFood.Name = "listViewOrderableFood";
            listViewOrderableFood.Size = new Size(300, 207);
            listViewOrderableFood.TabIndex = 0;
            listViewOrderableFood.UseCompatibleStateImageBehavior = false;
            listViewOrderableFood.View = View.Details;
            // 
            // columnHeaderOrderableDishName
            // 
            columnHeaderOrderableDishName.Text = "Name";
            columnHeaderOrderableDishName.Width = 100;
            // 
            // columnHeaderOrderableDishDescription
            // 
            columnHeaderOrderableDishDescription.Text = "Description";
            columnHeaderOrderableDishDescription.Width = 100;
            // 
            // columnHeaderOrderableDishPrice
            // 
            columnHeaderOrderableDishPrice.Text = "Price";
            columnHeaderOrderableDishPrice.Width = 100;
            // 
            // listViewOrderedFood
            // 
            listViewOrderedFood.Columns.AddRange(new ColumnHeader[] { columnHeaderOrderDishName, columnHeaderCount });
            listViewOrderedFood.GridLines = true;
            listViewOrderedFood.Location = new Point(441, 131);
            listViewOrderedFood.Name = "listViewOrderedFood";
            listViewOrderedFood.Size = new Size(300, 207);
            listViewOrderedFood.TabIndex = 1;
            listViewOrderedFood.UseCompatibleStateImageBehavior = false;
            listViewOrderedFood.View = View.Details;
            // 
            // columnHeaderOrderDishName
            // 
            columnHeaderOrderDishName.Text = "Dish";
            columnHeaderOrderDishName.Width = 150;
            // 
            // columnHeaderCount
            // 
            columnHeaderCount.Text = "Amount";
            columnHeaderCount.Width = 150;
            // 
            // buttonSaveOrder
            // 
            buttonSaveOrder.Location = new Point(548, 354);
            buttonSaveOrder.Name = "buttonSaveOrder";
            buttonSaveOrder.Size = new Size(95, 61);
            buttonSaveOrder.TabIndex = 2;
            buttonSaveOrder.Text = "Save order";
            buttonSaveOrder.UseVisualStyleBackColor = true;
            buttonSaveOrder.Click += buttonSaveOrder_Click;
            // 
            // buttonAddToCart
            // 
            buttonAddToCart.Location = new Point(145, 354);
            buttonAddToCart.Name = "buttonAddToCart";
            buttonAddToCart.Size = new Size(95, 61);
            buttonAddToCart.TabIndex = 5;
            buttonAddToCart.Text = "Add to cart";
            buttonAddToCart.UseVisualStyleBackColor = true;
            buttonAddToCart.Click += buttonAddToCart_Click;
            // 
            // groupBoxAddressInfo
            // 
            groupBoxAddressInfo.Controls.Add(checkBoxPickup);
            groupBoxAddressInfo.Controls.Add(labelAddress);
            groupBoxAddressInfo.Controls.Add(comboBoxAddressSelect);
            groupBoxAddressInfo.Location = new Point(47, 12);
            groupBoxAddressInfo.Name = "groupBoxAddressInfo";
            groupBoxAddressInfo.Size = new Size(477, 100);
            groupBoxAddressInfo.TabIndex = 7;
            groupBoxAddressInfo.TabStop = false;
            groupBoxAddressInfo.Text = "Delivery information";
            // 
            // checkBoxPickup
            // 
            checkBoxPickup.AutoSize = true;
            checkBoxPickup.Location = new Point(315, 52);
            checkBoxPickup.Name = "checkBoxPickup";
            checkBoxPickup.Size = new Size(62, 19);
            checkBoxPickup.TabIndex = 13;
            checkBoxPickup.Text = "Pickup";
            checkBoxPickup.UseVisualStyleBackColor = true;
            checkBoxPickup.CheckedChanged += checkBoxPickup_CheckedChanged;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(41, 56);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(49, 15);
            labelAddress.TabIndex = 12;
            labelAddress.Text = "Address";
            // 
            // comboBoxAddressSelect
            // 
            comboBoxAddressSelect.FormattingEnabled = true;
            comboBoxAddressSelect.Location = new Point(110, 51);
            comboBoxAddressSelect.Name = "comboBoxAddressSelect";
            comboBoxAddressSelect.Size = new Size(121, 23);
            comboBoxAddressSelect.TabIndex = 10;
            // 
            // comboBoxStatusSelector
            // 
            comboBoxStatusSelector.FormattingEnabled = true;
            comboBoxStatusSelector.Items.AddRange(new object[] { "New", "Cooking in progress", "In delivery", "Delivered", "Cancelled" });
            comboBoxStatusSelector.Location = new Point(575, 32);
            comboBoxStatusSelector.Name = "comboBoxStatusSelector";
            comboBoxStatusSelector.Size = new Size(121, 23);
            comboBoxStatusSelector.TabIndex = 8;
            // 
            // labelOrderStatus
            // 
            labelOrderStatus.AutoSize = true;
            labelOrderStatus.Location = new Point(530, 35);
            labelOrderStatus.Name = "labelOrderStatus";
            labelOrderStatus.Size = new Size(39, 15);
            labelOrderStatus.TabIndex = 9;
            labelOrderStatus.Text = "Status";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelOrderStatus);
            Controls.Add(comboBoxStatusSelector);
            Controls.Add(groupBoxAddressInfo);
            Controls.Add(buttonAddToCart);
            Controls.Add(buttonSaveOrder);
            Controls.Add(listViewOrderedFood);
            Controls.Add(listViewOrderableFood);
            Name = "Form5";
            Text = "Form5";
            groupBoxAddressInfo.ResumeLayout(false);
            groupBoxAddressInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewOrderableFood;
        private ListView listViewOrderedFood;
        private Button buttonSaveOrder;
        private Button buttonAddToCart;
        private ColumnHeader columnHeaderOrderableDishName;
        private ColumnHeader columnHeaderOrderableDishDescription;
        private ColumnHeader columnHeaderOrderableDishPrice;
        private ColumnHeader columnHeaderOrderDishName;
        private ColumnHeader columnHeaderCount;
        private GroupBox groupBoxAddressInfo;
        private ComboBox comboBoxStatusSelector;
        private Label labelOrderStatus;
        private ComboBox comboBoxAddressSelect;
        private Label labelAddress;
        private CheckBox checkBoxPickup;
    }
}