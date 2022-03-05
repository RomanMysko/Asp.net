using myWebApp.Data.Interfaces;
using myWebApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myWebApp.Data.Mocks
{
    public class MockOrders : IOrders
    {
        public IEnumerable<Orders> AllOrders
        {
            get
            {
                return new List<Orders>
             {
                 new Orders {dish = "varenuchki", quantity = 4},
                 new Orders {dish = "Kotletka", quantity = 2}
             }; 
            }
        }
    }
}
