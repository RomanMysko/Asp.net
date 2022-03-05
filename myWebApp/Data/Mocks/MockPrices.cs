using myWebApp.Data.Interfaces;
using myWebApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myWebApp.Data.Mocks
{
    public class MockPrices : IPrices
    {
        public IEnumerable<Prices> AllPrices
        {
            get
            {
                return new List<Prices>
                {
                    new Prices{dish = "Guacamole & chips", price = 7},
                    new Prices{dish = "Kotletka", price = 125}
                };
            }
        }
    }
}
