using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace myWebApp.Data.Models
{
    public class Orders
    {
        //model that represents an order table related to Reservation model
        //consists of 2 fields:
        //    dish(str) :name of dish
        //     quantity(int):quantity of dishes
        [Key]
        public int Id { get; set; }
        public string dish { get; set; }
        public int quantity { get; set; }
        public override string ToString()
        {
            return Convert.ToString(dish) + ":" + Convert.ToString(quantity);
        }
    }
}
