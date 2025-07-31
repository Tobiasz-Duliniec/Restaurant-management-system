using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_zaliczeniowy
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        public Form6(Order order)
        {
            InitializeComponent();
            if (string.IsNullOrWhiteSpace(order.address.ToString())){
                labelDestinationAddress.Text = "Pickup";
            }
            else
            {
                labelDestinationAddress.Text = order.address.ToString();
            }
                labelStatus.Text = order.status;
            foreach (var key in order.dish_amount.Keys)
            {
                var orderedDish = DishList.Instance.getDishByDishId(key);
                if (orderedDish != null)
                {
                    ListViewItem orderItem = new ListViewItem(orderedDish.Name);
                    orderItem.SubItems.Add(order.dish_amount[key].ToString());
                    listViewDishInformation.Items.Add(orderItem);
                }
            }
        }
    }
}
