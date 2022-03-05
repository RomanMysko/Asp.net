using myWebApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myWebApp.ViewModels
{
    public class ReservationViewModel
    {
        public int Id { get; set; }
        public DateTime datetime { get; set; }
        public int party { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public float price { get; set; }
        public List<Orders> orders { get; set; }
    }
}
