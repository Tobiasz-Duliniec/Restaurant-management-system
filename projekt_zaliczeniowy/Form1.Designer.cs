namespace projekt_zaliczeniowy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            buttonProducts = new Button();
            buttonOrder = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.BorderStyle = BorderStyle.Fixed3D;
            labelTitle.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(12, 134);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(776, 67);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Restaurant management system";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonProducts
            // 
            buttonProducts.Location = new Point(308, 277);
            buttonProducts.Name = "buttonProducts";
            buttonProducts.Size = new Size(74, 49);
            buttonProducts.TabIndex = 1;
            buttonProducts.Text = "Products";
            buttonProducts.UseVisualStyleBackColor = true;
            buttonProducts.Click += buttonProducts_Click;
            // 
            // buttonOrder
            // 
            buttonOrder.Location = new Point(400, 277);
            buttonOrder.Name = "buttonOrder";
            buttonOrder.Size = new Size(74, 49);
            buttonOrder.TabIndex = 2;
            buttonOrder.Text = "Order";
            buttonOrder.UseVisualStyleBackColor = true;
            buttonOrder.Click += buttonOrder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOrder);
            Controls.Add(buttonProducts);
            Controls.Add(labelTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label labelTitle;
        private Button buttonProducts;
        private Button buttonOrder;
    }
}
