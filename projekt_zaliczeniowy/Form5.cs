using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_zaliczeniowy
{
    public partial class Form5 : Form, IDDX<Order>
    {
        Order order = new();
        Dictionary<string, int> deliveryCosts = new();
        

        void updateOrderList()
        {
            listViewOrderedFood.Items.Clear();
            foreach (var dish in order.dish_amount)
            {
                ListViewItem orderItem = new ListViewItem(DishList.Instance.getDishByDishId(dish.Key).Name);
                //ListViewItem orderItem = new ListViewItem(DishList.Instance.getDishes()[dish.Key].Name);
                orderItem.SubItems.Add(dish.Value.ToString());
                listViewOrderedFood.Items.Add(orderItem);
            }
        }

        public Form5()
        {
            InitializeComponent();
            deliveryCosts["Example Street 1"] = 23;
            deliveryCosts["Example Street 2"] = 13;
            deliveryCosts["Example Street 3"] = 15;
            foreach (var address in deliveryCosts.Keys)
            {
                comboBoxAddressSelect.Items.Add(address);
            }
            comboBoxStatusSelector.SelectedIndex = 0;
            comboBoxAddressSelect.SelectedIndex = 0;
            ListViewManager.fillListView(listViewOrderableFood, DishList.Instance.dishes, "id");
        }

        public Form5(int id)
        {
            InitializeComponent();
            ListViewManager.fillListView(listViewOrderableFood, DishList.Instance.dishes, "id");
            Order orderToBeEdited = OrderList.Instance.allOrders()[id];
            comboBoxAddressSelect.SelectedIndex = comboBoxAddressSelect.FindStringExact(orderToBeEdited.address.ToString());
            comboBoxStatusSelector.SelectedIndex = comboBoxStatusSelector.FindStringExact(orderToBeEdited.status);
            foreach (var item in orderToBeEdited.dish_amount)
            {
                ListViewItem? orderItem = new ListViewItem((DishList.Instance.getDishByDishId(item.Key).Name));
                if (orderItem == null) ;
                orderItem.SubItems.Add(orderToBeEdited.dish_amount[item.Key].ToString());
                listViewOrderedFood.Items.Add(orderItem);
            }
            order = orderToBeEdited;
        }

        public Order Get()
        {
            order.status = comboBoxStatusSelector.Text;
            if (comboBoxAddressSelect.Enabled)
            {
                order.address = new DestinationAddress(
                    string.Join(" ", comboBoxAddressSelect.Text.Split(" ")[0..2]),
                    comboBoxAddressSelect.Text.Split(" ").Last(),
                    deliveryCosts[comboBoxAddressSelect.Text.ToString()]
                );
            }
            else
            {
                order.address = new DestinationAddress ( null, null, 0 );
            }
            return order;
        }

        public void Set(Order elem)
        {
            throw new NotImplementedException();
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            if (listViewOrderableFood.SelectedItems.Count == 0) return;
            order.addDishToOrder(int.Parse(listViewOrderableFood.SelectedItems[0].Tag.ToString()));
            updateOrderList();
        }

        private void buttonSaveOrder_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxPickup_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPickup.Checked) { comboBoxAddressSelect.Enabled = false; }
            else { comboBoxAddressSelect.Enabled = true; }
        }
    }
}
