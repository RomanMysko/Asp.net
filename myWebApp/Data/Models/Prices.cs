using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace myWebApp.Data.Models
{
    public class Prices
    {
        /*
        model that represents a table of premade prices in a menu.
        consists of 2 fields:
        dish(string):name of a dish
        price(float):price of a dish
        */
        [Key]
        public int Id { get; set; }
        public string dish { set; get; }
        public float price { set; get; }
        public override string ToString()
        {
            return Convert.ToString(dish) + ":" + Convert.ToString(price);
        }
    }
}
