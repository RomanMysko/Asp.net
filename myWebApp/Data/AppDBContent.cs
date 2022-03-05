using Microsoft.EntityFrameworkCore;
using myWebApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myWebApp.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options){

        }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<Prices> Prices { get; set; }
        public DbSet<Orders> Orders { get; set; }
    }
}
