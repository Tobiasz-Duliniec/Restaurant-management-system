namespace projekt_zaliczeniowy
{
    partial class Form4
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
            components = new System.ComponentModel.Container();
            labelAddDish = new Label();
            textBoxDishNameInput = new TextBox();
            textBoxDishDescriptionInput = new TextBox();
            textBoxDishPriceInput = new TextBox();
            buttonAddDish = new Button();
            labelDishNameInput = new Label();
            labelDishDescriptionInput = new Label();
            labelDishPriceInput = new Label();
            pictureBoxDishPictureInput = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxDishPictureInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // labelAddDish
            // 
            labelAddDish.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAddDish.Location = new Point(305, 9);
            labelAddDish.Name = "labelAddDish";
            labelAddDish.Size = new Size(191, 64);
            labelAddDish.TabIndex = 0;
            labelAddDish.Text = "Add/save dish";
            labelAddDish.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxDishNameInput
            // 
            textBoxDishNameInput.Location = new Point(398, 128);
            textBoxDishNameInput.Name = "textBoxDishNameInput";
            textBoxDishNameInput.Size = new Size(264, 23);
            textBoxDishNameInput.TabIndex = 1;
            textBoxDishNameInput.TextChanged += textBoxDishNameInput_TextChanged;
            // 
            // textBoxDishDescriptionInput
            // 
            textBoxDishDescriptionInput.Location = new Point(398, 190);
            textBoxDishDescriptionInput.Name = "textBoxDishDescriptionInput";
            textBoxDishDescriptionInput.Size = new Size(264, 23);
            textBoxDishDescriptionInput.TabIndex = 2;
            // 
            // textBoxDishPriceInput
            // 
            textBoxDishPriceInput.Location = new Point(398, 264);
            textBoxDishPriceInput.Name = "textBoxDishPriceInput";
            textBoxDishPriceInput.Size = new Size(264, 23);
            textBoxDishPriceInput.TabIndex = 3;
            // 
            // buttonAddDish
            // 
            buttonAddDish.Location = new Point(334, 358);
            buttonAddDish.Name = "buttonAddDish";
            buttonAddDish.Size = new Size(102, 40);
            buttonAddDish.TabIndex = 4;
            buttonAddDish.Text = "Save dish";
            buttonAddDish.UseVisualStyleBackColor = true;
            buttonAddDish.Click += buttonAddDish_Click;
            // 
            // labelDishNameInput
            // 
            labelDishNameInput.AutoSize = true;
            labelDishNameInput.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDishNameInput.Location = new Point(271, 131);
            labelDishNameInput.Name = "labelDishNameInput";
            labelDishNameInput.Size = new Size(79, 20);
            labelDishNameInput.TabIndex = 5;
            labelDishNameInput.Text = "Dish name";
            // 
            // labelDishDescriptionInput
            // 
            labelDishDescriptionInput.AutoSize = true;
            labelDishDescriptionInput.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDishDescriptionInput.Location = new Point(271, 193);
            labelDishDescriptionInput.Name = "labelDishDescriptionInput";
            labelDishDescriptionInput.Size = new Size(116, 20);
            labelDishDescriptionInput.TabIndex = 6;
            labelDishDescriptionInput.Text = "Dish description";
            // 
            // labelDishPriceInput
            // 
            labelDishPriceInput.AutoSize = true;
            labelDishPriceInput.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDishPriceInput.Location = new Point(271, 267);
            labelDishPriceInput.Name = "labelDishPriceInput";
            labelDishPriceInput.Size = new Size(75, 20);
            labelDishPriceInput.TabIndex = 7;
            labelDishPriceInput.Text = "Dish price";
            // 
            // pictureBoxDishPictureInput
            // 
            pictureBoxDishPictureInput.BackColor = SystemColors.ButtonShadow;
            pictureBoxDishPictureInput.Location = new Point(34, 89);
            pictureBoxDishPictureInput.Name = "pictureBoxDishPictureInput";
            pictureBoxDishPictureInput.Size = new Size(220, 220);
            pictureBoxDishPictureInput.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDishPictureInput.TabIndex = 8;
            pictureBoxDishPictureInput.TabStop = false;
            pictureBoxDishPictureInput.Click += pictureBoxDishPictureInput_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxDishPictureInput);
            Controls.Add(labelDishPriceInput);
            Controls.Add(labelDishDescriptionInput);
            Controls.Add(labelDishNameInput);
            Controls.Add(buttonAddDish);
            Controls.Add(textBoxDishPriceInput);
            Controls.Add(textBoxDishDescriptionInput);
            Controls.Add(textBoxDishNameInput);
            Controls.Add(labelAddDish);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxDishPictureInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAddDish;
        private TextBox textBoxDishNameInput;
        private TextBox textBoxDishDescriptionInput;
        private TextBox textBoxDishPriceInput;
        private Button buttonAddDish;
        private Label labelDishNameInput;
        private Label labelDishDescriptionInput;
        private Label labelDishPriceInput;
        private PictureBox pictureBoxDishPictureInput;
        private ErrorProvider errorProvider1;
    }
}