using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Pipes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_zaliczeniowy
{

    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
            ListViewManager.fillListView(listViewDishList, DishList.Instance.getDishes());
        }


        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            Form4 addProductForm = new Form4();
            if (addProductForm.ShowDialog() == DialogResult.OK)
            {
                Dish dish = addProductForm.Get();
                ListViewManager.addDishToListViewDishList(listViewDishList, dish);
                DishList.Instance.addDish(dish);
            }
        }

        private void listViewDishList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pictureBoxDishImage.Image != null)
            {
                pictureBoxDishImage.Image.Dispose();
                pictureBoxDishImage.Image = null;
            }
            if (listViewDishList.SelectedItems.Count == 1)
            {
                pictureBoxDishImage.Image = Image.FromFile(listViewDishList.SelectedItems[0].Tag.ToString());
            }
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            if (listViewDishList.SelectedItems.Count == 0) return;

            Dish dish = new Dish(listViewDishList.SelectedItems[0].SubItems[0].Text,
                listViewDishList.SelectedItems[0].SubItems[1].Text,
                int.Parse(listViewDishList.SelectedItems[0].SubItems[2].Text),
                listViewDishList.SelectedItems[0].Tag.ToString()
            );

            Form4 editForm = new Form4(dish);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                Dish newDish = editForm.Get();

                ListViewItem newDishItem = new ListViewItem(newDish.Name);
                newDishItem.SubItems.Add(newDish.Description);
                newDishItem.SubItems.Add(newDish.Price.ToString());
                newDishItem.Tag = newDish.Picture;

                int indeks = listViewDishList.SelectedIndices[0];
                listViewDishList.Items[indeks] = newDishItem;
                DishList.Instance.modifyDish(newDish, indeks);
            }
        }

        private void buttonRemoveProduct_Click(object sender, EventArgs e)
        {
            if (listViewDishList.SelectedItems.Count == 0) return;
            int indeks = listViewDishList.SelectedIndices[0];
            foreach (var order in OrderList.Instance.allOrders())
            {
                foreach (var dish in order.dish_amount)
                {
                    if (dish.Key.ToString() == DishList.Instance.getDishByDishId(indeks).Name)
                    {
                        order.dish_amount.Remove(dish.Key);
                    }
                }
            }
            listViewDishList.Items.RemoveAt(indeks);
            DishList.Instance.removeDish(indeks);
        }

        private void buttonSearchProduct_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewDishList.Items.Count; i++)
            {
                listViewDishList.Items[i].Selected = false;
            }
            List<int> matchingDishes = DishList.Instance.filterDishes(textBoxSeachDish.Text);
            foreach (int index in matchingDishes)
            {
                listViewDishList.Items[index].Selected = true;
            }
        }

        private void buttonSaveProducts_Click(object sender, EventArgs e)
        {
            DishList.Instance.saveDishes();
        }

    }
}
