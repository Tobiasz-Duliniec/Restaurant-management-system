using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_zaliczeniowy
{
    public class Dish
    {
        public Dish()
        {

        }

        public Dish(string name, string description, int price, string picture)
        {
            Name = name;
            Description = description;
            Price = price;
            Picture = picture;
        }

        public int id { get; set; } = 0;
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public int Price { get; set; } = 0;
        public string? Picture { get; set; } = String.Empty;

        public override string ToString()
        {
            return $"{Name} ({Description})";
        }
    }

}
