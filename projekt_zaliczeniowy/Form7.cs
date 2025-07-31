using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_zaliczeniowy
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        public Form7(Order order)
        {
            int totalPrice = 0;
            InitializeComponent();
            foreach(var dish in order.dish_amount)
            {
                    Dish dishToDisplay = DishList.Instance.getDishByDishId(dish.Key);
                    ListViewItem orderItem = new ListViewItem(dishToDisplay.Name);
                    orderItem.SubItems.Add(order.dish_amount[dish.Key].ToString());
                    orderItem.SubItems.Add(dishToDisplay.Price.ToString());
                    listViewOrderDetails.Items.Add(orderItem);
                    totalPrice += dishToDisplay.Price * order.dish_amount[dish.Key];
                
            }
            ListViewItem deliveryItem = new ListViewItem("Delivery cost");
            deliveryItem.SubItems.Add("---");
            deliveryItem.SubItems.Add(order.address.deliveryCost.ToString());
            listViewOrderDetails.Items.Add(deliveryItem);

            totalPrice += order.address.deliveryCost;
            labelTotalCostValue.Text = totalPrice.ToString();
        }
    }
}
