namespace projekt_zaliczeniowy
{
    partial class Form2
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
            buttonAddProduct = new Button();
            buttonRemoveProduct = new Button();
            buttonEditProduct = new Button();
            listViewDishList = new ListView();
            columnHeaderDishName = new ColumnHeader();
            columnHeaderDishDescription = new ColumnHeader();
            columnHeaderDishPrice = new ColumnHeader();
            textBoxSeachDish = new TextBox();
            buttonSearchProduct = new Button();
            pictureBoxDishImage = new PictureBox();
            buttonSaveProducts = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDishImage).BeginInit();
            SuspendLayout();
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Location = new Point(257, 242);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(87, 61);
            buttonAddProduct.TabIndex = 1;
            buttonAddProduct.Text = "Add product";
            buttonAddProduct.UseVisualStyleBackColor = true;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // buttonRemoveProduct
            // 
            buttonRemoveProduct.Location = new Point(470, 242);
            buttonRemoveProduct.Name = "buttonRemoveProduct";
            buttonRemoveProduct.Size = new Size(87, 61);
            buttonRemoveProduct.TabIndex = 2;
            buttonRemoveProduct.Text = "Remove product";
            buttonRemoveProduct.UseVisualStyleBackColor = true;
            buttonRemoveProduct.Click += buttonRemoveProduct_Click;
            // 
            // buttonEditProduct
            // 
            buttonEditProduct.Location = new Point(364, 242);
            buttonEditProduct.Name = "buttonEditProduct";
            buttonEditProduct.Size = new Size(87, 61);
            buttonEditProduct.TabIndex = 3;
            buttonEditProduct.Text = "Edit product";
            buttonEditProduct.UseVisualStyleBackColor = true;
            buttonEditProduct.Click += buttonEditProduct_Click;
            // 
            // listViewDishList
            // 
            listViewDishList.AutoArrange = false;
            listViewDishList.Columns.AddRange(new ColumnHeader[] { columnHeaderDishName, columnHeaderDishDescription, columnHeaderDishPrice });
            listViewDishList.FullRowSelect = true;
            listViewDishList.GridLines = true;
            listViewDishList.Location = new Point(257, 33);
            listViewDishList.Name = "listViewDishList";
            listViewDishList.Size = new Size(300, 187);
            listViewDishList.TabIndex = 4;
            listViewDishList.UseCompatibleStateImageBehavior = false;
            listViewDishList.View = View.Details;
            listViewDishList.SelectedIndexChanged += listViewDishList_SelectedIndexChanged;
            // 
            // columnHeaderDishName
            // 
            columnHeaderDishName.Text = "Dish";
            columnHeaderDishName.Width = 100;
            // 
            // columnHeaderDishDescription
            // 
            columnHeaderDishDescription.Text = "Description";
            columnHeaderDishDescription.TextAlign = HorizontalAlignment.Center;
            columnHeaderDishDescription.Width = 100;
            // 
            // columnHeaderDishPrice
            // 
            columnHeaderDishPrice.Text = "Price";
            columnHeaderDishPrice.TextAlign = HorizontalAlignment.Center;
            columnHeaderDishPrice.Width = 100;
            // 
            // textBoxSeachDish
            // 
            textBoxSeachDish.Location = new Point(632, 107);
            textBoxSeachDish.Name = "textBoxSeachDish";
            textBoxSeachDish.Size = new Size(125, 23);
            textBoxSeachDish.TabIndex = 5;
            // 
            // buttonSearchProduct
            // 
            buttonSearchProduct.Location = new Point(652, 136);
            buttonSearchProduct.Name = "buttonSearchProduct";
            buttonSearchProduct.Size = new Size(87, 61);
            buttonSearchProduct.TabIndex = 6;
            buttonSearchProduct.Text = "Search product";
            buttonSearchProduct.UseVisualStyleBackColor = true;
            buttonSearchProduct.Click += buttonSearchProduct_Click;
            // 
            // pictureBoxDishImage
            // 
            pictureBoxDishImage.BackColor = SystemColors.ButtonShadow;
            pictureBoxDishImage.Location = new Point(12, 33);
            pictureBoxDishImage.Name = "pictureBoxDishImage";
            pictureBoxDishImage.Size = new Size(220, 220);
            pictureBoxDishImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDishImage.TabIndex = 7;
            pictureBoxDishImage.TabStop = false;
            // 
            // buttonSaveProducts
            // 
            buttonSaveProducts.Location = new Point(652, 242);
            buttonSaveProducts.Name = "buttonSaveProducts";
            buttonSaveProducts.Size = new Size(87, 61);
            buttonSaveProducts.TabIndex = 8;
            buttonSaveProducts.Text = "Save products";
            buttonSaveProducts.UseVisualStyleBackColor = true;
            buttonSaveProducts.Click += buttonSaveProducts_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSaveProducts);
            Controls.Add(pictureBoxDishImage);
            Controls.Add(buttonSearchProduct);
            Controls.Add(textBoxSeachDish);
            Controls.Add(listViewDishList);
            Controls.Add(buttonEditProduct);
            Controls.Add(buttonRemoveProduct);
            Controls.Add(buttonAddProduct);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBoxDishImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonAddProduct;
        private Button buttonRemoveProduct;
        private Button buttonEditProduct;
        private ListView listViewDishList;
        private ColumnHeader columnHeaderDishName;
        private ColumnHeader columnHeaderDishDescription;
        private ColumnHeader columnHeaderDishPrice;
        private TextBox textBoxSeachDish;
        private Button buttonSearchProduct;
        private PictureBox pictureBoxDishImage;
        private Button buttonSaveProducts;
    }
}