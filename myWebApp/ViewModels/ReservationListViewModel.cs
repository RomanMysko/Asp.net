using myWebApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myWebApp.ViewModels
{
    public class ReservationListViewModel
    {
        public IEnumerable<Reservation> AllReservations { get; set; }
    }
}
