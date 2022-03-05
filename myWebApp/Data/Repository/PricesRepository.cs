using System;
using System.Collections.Generic;
using myWebApp.Data.Interfaces;
using System.Linq;
using System.Threading.Tasks;
using myWebApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace myWebApp.Data.Repository
{
    public class PricesRepository : IPrices
    {
        public readonly AppDBContent appDBContent;
        public PricesRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Prices> AllPrices => appDBContent.Prices.Include(c => c.ToString());
    }
}
