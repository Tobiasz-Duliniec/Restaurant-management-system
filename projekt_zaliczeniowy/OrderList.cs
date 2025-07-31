using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;

namespace projekt_zaliczeniowy
{


    internal class OrderList
    {
        List<Order> allOrdersList;
        public static readonly OrderList Instance = new OrderList();

        const string ORDERFILE = "ordersInfo.json";

        private OrderList()
        {
            allOrdersList = loadOrders() ?? new List<Order>();
        }

        public List<Order>? loadOrders()
        {
            List<Order> dishes = new();
            if (!File.Exists(ORDERFILE))
            {
                return null;
            }

            string allDishes = File.ReadAllText(ORDERFILE);
            if (string.IsNullOrEmpty(allDishes))
            {
                return null;
            }

            return JsonConvert.DeserializeObject<List<Order>>(File.ReadAllText(ORDERFILE));
        }

        public List<Order> allOrders()
        {
            return allOrdersList;
        }

        public void saveOrders()
        {
            string txt = JsonConvert.SerializeObject(allOrdersList, Formatting.Indented);
            File.WriteAllText(ORDERFILE, txt);
        }

        public void addOrder(Order order)
        {
            order.id = allOrdersList.Count;
            allOrdersList.Add(order);
        }

        public void modifyOrder(int id, Order order) {
            allOrdersList[id] = order;
        }
    }
}
