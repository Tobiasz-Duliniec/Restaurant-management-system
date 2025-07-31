using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_zaliczeniowy
{
    public static class ListViewManager
    {

        public static void addDishToListViewDishList(ListView dishList, Dish dish, string tagContent = "picture")
        {
            if (dish == null) return;
            ListViewItem dishItem = new ListViewItem(dish.Name);

            dishItem.SubItems.Add(dish.Description);
            dishItem.SubItems.Add(dish.Price.ToString());
            if (tagContent == "picture")
            {
                dishItem.Tag = dish.Picture;
            }
            else if(tagContent == "id"){
                dishItem.Tag = dish.id.ToString();
            }
            dishList.Items.Add(dishItem);
        }

        public static void fillListView(ListView dishView, List<Dish> dishes, string tagContent = "picture")
        {
            foreach (var dish in dishes)
            {
                ListViewManager.addDishToListViewDishList(dishView, dish, tagContent);
            }
        }
    }
}
