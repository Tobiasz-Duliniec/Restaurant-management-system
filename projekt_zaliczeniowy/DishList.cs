using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace projekt_zaliczeniowy
{
    internal class DishList
    {
        public List<Dish> dishes = new();
        const string DISHFILE = "dishInfo.json";

        public static readonly DishList Instance = new DishList();

        private DishList(){
            dishes = loadDishes() ?? new List<Dish>();
        }

        public List<int> filterDishes(string pattern)
        {
            List<int> filteredDishes = new();
            string regexPattern = $".*{pattern}.*";
            Regex rg = new Regex(regexPattern);
            for(int i=0;i<dishes.Count;i++)
            {
                if(rg.IsMatch(dishes[i].Name)) { 
                    filteredDishes.Add(i);
                }
            }
            return filteredDishes;
        }

        public Dish? getDishByDishId(int id)
        {
            foreach(var dish in dishes)
            {
                if(dish.id == id)
                {
                    return dish;
                }
            }
            return null;
        }

        public List<Dish> getDishes()
        {
            return dishes;
        }

        public void modifyDish(Dish dish, int index)
        {
            dishes[index] = dish;
            saveDishes();
        }

        public void addDish(Dish dish)
        {
            dishes.Add(dish);
        }

        public void removeDish(int indeks)
        {
            foreach(var order in OrderList.Instance.allOrders())
            {
                order.dish_amount.Remove(indeks);
            }
            OrderList.Instance.saveOrders();
            dishes.RemoveAt(indeks);
            saveDishes();
        }

        public void saveDishes()
        {
            string dishJSON = System.Text.Json.JsonSerializer.Serialize(dishes);
            File.WriteAllText(DISHFILE, dishJSON);
        }

        public List<Dish>? loadDishes()
        {
            List<Dish> dishes = new();
            if (!File.Exists(DISHFILE))
            {
                return null;
            }

            string allDishes = File.ReadAllText(DISHFILE);
            if (string.IsNullOrEmpty(allDishes))
            {
                return null;
            }

            dishes = System.Text.Json.JsonSerializer.Deserialize<List<Dish>>(allDishes);
            return dishes;
        }

    }
}
