using myWebApp.Data.Interfaces;
using myWebApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myWebApp.Data.Mocks
{
    public class MockReservation : IReservation
    {
        private readonly IOrders myorder = new MockOrders();
        List<Orders> myList = new List<Orders>();
        public IEnumerable<Reservation> AllReservations
        {
            get
            {
                List<Orders> myList = new List<Orders>();
                myList.Add(myorder.AllOrders.ElementAt(0));
                myList.Add(myorder.AllOrders.ElementAt(1));
                return new List<Reservation>
                {
                    new Reservation{ datetime = new DateTime(2021, 9, 27, 3, 57, 0), party = 4, name = "Oleg", email = "Olewka@gmail.com", phone = "+380500730599", price = 300, orders = myList},
                    new Reservation{ datetime = new DateTime(2021, 11, 22, 3, 57, 0), party = 2, name = "Ivan", email = "Ivawka@gmail.com", phone = "+380500820599", price = 160, orders = myList}

                };
            }
        }
    }
}
