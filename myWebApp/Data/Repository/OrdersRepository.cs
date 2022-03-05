using System;
using myWebApp.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myWebApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace myWebApp.Data.Repository
{
    public class OrdersRepository : IOrders
    {
        public readonly AppDBContent appDBContent;
        public OrdersRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Orders> AllOrders => appDBContent.Orders.Include(c => c.ToString());
    }
}
