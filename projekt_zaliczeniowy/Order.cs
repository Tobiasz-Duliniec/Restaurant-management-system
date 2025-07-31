using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace projekt_zaliczeniowy
{
    public class Order
    {

        public Dictionary<int, int> dish_amount { get; set; } = new();

        public int id { get; set; } = 0;

        public string status { get; set; } = String.Empty;
        public DestinationAddress address { get; set; } = new DestinationAddress();

        public Order(){}

        public override string ToString()
        {
            string return_string = $"Delivery #{id} to {address.ToString()}. Status: {status}";
            return return_string;
        }

        public void addDishToOrder(Dish dish)
        {
            if (dish == null) return;
            addDishToOrder(dish.id);
        }

        public void addDishToOrder(int id)
        {
            if (dish_amount.ContainsKey(id))
            {
                dish_amount[id]++;
            }
            else
            {
                dish_amount.Add(id, 1);
            }
        }
        
        public int getOrderLength()
        {
            return dish_amount.Count;
        }

        /*
        public float calculateOrderPrice() {
            float orderPrice = 0f;
            foreach(var dish in orderedDishes)
            {
                orderPrice += dish.Price;
            }
            return orderPrice;
        }
        */
    }
}
