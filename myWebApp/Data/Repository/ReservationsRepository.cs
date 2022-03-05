using Microsoft.EntityFrameworkCore;
using myWebApp.Data.Interfaces;
using myWebApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myWebApp.Data.Repository
{
    public class ReservationsRepository : IReservation
    {
        public readonly AppDBContent appDBContent;
        public ReservationsRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent; 
        }
        public IEnumerable<Reservation> AllReservations => appDBContent.Reservation.Include(c => c.ToString());
    }
}
