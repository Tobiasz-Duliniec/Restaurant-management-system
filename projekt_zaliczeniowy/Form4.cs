using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_zaliczeniowy
{
    public partial class Form4 : Form, IDDX<Dish>
    {
        public Form4()
        {
            InitializeComponent();
        }

        public Form4(Dish dish)
        {
            InitializeComponent();
            fillForm(dish);
        }

        private void fillForm(Dish dish)
        {
            textBoxDishNameInput.Text = dish.Name;
            textBoxDishDescriptionInput.Text = dish.Description;
            textBoxDishPriceInput.Text = dish.Price.ToString();
            pictureBoxDishPictureInput.Image = Image.FromFile(dish.Picture);
            pictureBoxDishPictureInput.Tag = dish.Picture;
        }

        private bool validateDish()
        {
            bool isValid = true;

            if (pictureBoxDishPictureInput.Image == null)
            {
                errorProvider1.SetError(pictureBoxDishPictureInput, "Every dish must have a picture!");
                return false;
            }

            if (string.IsNullOrEmpty(textBoxDishNameInput.Text))
            {
                errorProvider1.SetError(textBoxDishNameInput, "Dish name cannot be empty!");
                return false;
            }

            if (string.IsNullOrEmpty(textBoxDishDescriptionInput.Text))
            {
                errorProvider1.SetError(textBoxDishDescriptionInput, "Dish desciption cannot be empty!");
                return false;
            }
            try
            {
                int price = int.Parse(textBoxDishPriceInput.Text);
            }
            catch (Exception e)
            {
                errorProvider1.SetError(textBoxDishPriceInput, "Not an integer!");
                isValid = false;
            }

            return isValid;
        }

        public Dish Get()
        {
            if (DishList.Instance.getDishes().Count > 0)
            {
                return new Dish
                {
                    id = DishList.Instance.getDishes()[DishList.Instance.getDishes().Count - 1].id + 1,
                    Name = textBoxDishNameInput.Text,
                    Description = textBoxDishDescriptionInput.Text,
                    Price = int.Parse(textBoxDishPriceInput.Text),
                    Picture = pictureBoxDishPictureInput.Tag.ToString()
                };
            }
            else
            {
                return new Dish
                {
                    id = 0,
                    Name = textBoxDishNameInput.Text,
                    Description = textBoxDishDescriptionInput.Text,
                    Price = int.Parse(textBoxDishPriceInput.Text),
                    Picture = pictureBoxDishPictureInput.Tag.ToString()
                };
            }

        }

        public void Set(Dish elem)
        {
            textBoxDishNameInput.Text = elem.Name;
            textBoxDishDescriptionInput.Text = elem.Description;
            textBoxDishPriceInput.Text = elem.Price.ToString();
            pictureBoxDishPictureInput.Image = Image.FromFile(elem.Picture);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddDish_Click(object sender, EventArgs e)
        {
            if (validateDish()) this.DialogResult = DialogResult.OK;
        }

        private void pictureBoxDishPictureInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Image Files(*.PNG; *.JPG)| *.PNG; *.JPG; | All files(*.*) | *.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxDishPictureInput.Image = Image.FromFile(openFileDialog.FileName);
                pictureBoxDishPictureInput.Tag = openFileDialog.FileName;
            }
        }

        private void textBoxDishNameInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
