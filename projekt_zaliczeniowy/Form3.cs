using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace projekt_zaliczeniowy
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            if (OrderList.Instance.allOrders().Count != 0)
            {
                foreach(var order in OrderList.Instance.allOrders())
                {
                    ListViewItem orderItem = new ListViewItem(order.id.ToString());
                    if (string.IsNullOrWhiteSpace(order.address.ToString()))
                    {
                        orderItem.SubItems.Add("Pickup");
                    }
                    else
                    {
                        orderItem.SubItems.Add(order.address.ToString());
                    }

                    orderItem.SubItems.Add(order.status);
                    listViewOrderList.Items.Add(orderItem);
                }
            }
        }

        private void labelOrder_Click(object sender, EventArgs e)
        {

        }

        private void buttonOrderFood_Click(object sender, EventArgs e)
        {
            Form5 addOrderForm = new();
            if (addOrderForm.ShowDialog() == DialogResult.OK)
            {
                Order order = addOrderForm.Get();
                if (order == null) return;
                OrderList.Instance.addOrder(order);
                OrderList.Instance.saveOrders();
                ListViewItem orderItem = new ListViewItem(order.id.ToString());
                orderItem.SubItems.Add(order.address.ToString());
                orderItem.SubItems.Add(order.status);
                listViewOrderList.Items.Add(orderItem);
                OrderList.Instance.saveOrders();
            }
        }

        private void buttonShowReceipt_Click(object sender, EventArgs e)
        {
            if (listViewOrderList.SelectedItems.Count == 0) return;
            Form7 ReceiptForm = new(OrderList.Instance.allOrders()[listViewOrderList.SelectedIndices[0]]);
            ReceiptForm.Show();
        }

        private void buttonEditOrder_Click(object sender, EventArgs e)
        {
            if (listViewOrderList.SelectedItems.Count == 0) return;
            int id = int.Parse(listViewOrderList.SelectedItems[0].SubItems[0].Text.ToString());
            Form5 editOrderForm = new(id);
            if(editOrderForm.ShowDialog() == DialogResult.OK)
            {
                OrderList.Instance.modifyOrder(id, editOrderForm.Get());
            }

            listViewOrderList.Items.Clear();
            if (OrderList.Instance.allOrders().Count != 0)
            {
                foreach (var order in OrderList.Instance.allOrders())
                {
                    ListViewItem orderItem = new ListViewItem(order.id.ToString());
                    orderItem.SubItems.Add(order.address.ToString());
                    orderItem.SubItems.Add(order.status);
                    listViewOrderList.Items.Add(orderItem);
                }
            }
            OrderList.Instance.saveOrders();
        }

        private void buttonOrderDetails_Click(object sender, EventArgs e)
        {
            if (listViewOrderList.SelectedItems.Count == 0) return;
            Form6 viewOrderForm = new Form6(OrderList.Instance.allOrders()[listViewOrderList.SelectedIndices[0]]);
            viewOrderForm.Show();

        }

        private void buttonSaveOrdersToFile_Click(object sender, EventArgs e)
        {
            OrderList.Instance.saveOrders();
        }
    }
}
