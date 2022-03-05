using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace myWebApp.Data.Models
{
    public class Reservation
    {

        //model that represents a Reservation object made by a user
        //consists of 8 fields:
        //    date(Date) :date of reservation
        //     time(Time):time of reservation
        //     party(int):quantity of people attending
        //    name(str) :name of a customer
        //    email(Email) :email address
        //    phone(int) :phone number of a customer
        //     total_price(float):total price of a reservation
        //     orders(ManyToManyRelation):ManyToManyRelation to Order class
        [Key]
        public int Id { get; set; }
        public DateTime datetime { get; set; }
        public int party { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public float price { get; set; }
        public List<Orders> orders { get; set; }
        public string Print()
        {
            return datetime.ToString("g");
        }
        /*public override string ToString()
        {
            return "datetime :" + Convert.ToString(datetime) + "\nparty :" + Convert.ToString(party) + "\nname :"
                + name + "\nemail :" + email + "\nphone :" + phone + "\nprice :" + Convert.ToString(price) + "\norders :\n" + orders.ToString();//if error exists then try yo change to 'Convert.ToString(orders)'
        }*/
    }
}
