using Microsoft.AspNetCore.Mvc;
using myWebApp.Data.Interfaces;
using myWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace myWebApp.Controllers
{
    public class ReservationController : ApiController
    {
        /*private readonly IReservation allReservations;
        private readonly IOrders allOrders;
        private readonly IPrices allPrices;
        public ReservationController(IReservation IallReservations, IOrders Iallorders, IPrices IallPrices)
        {
            allReservations = IallReservations;
            allOrders = Iallorders;
            allPrices = IallPrices;
        }

        public ViewResult Index()
        {
            ReservationListViewModel obj = new ReservationListViewModel();
            obj.AllReservations = allReservations.AllReservations;
            var reservations = allReservations.AllReservations;
            return View(obj);
        }*/
        public IHttpActionResult PostNewStudent(ReservationListViewModel student)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            using (var ctx = new SchoolDBEntities())
            {
                ctx.Students.Add(new Student()
                {
                    StudentID = student.Id,
                    FirstName = student.FirstName,
                    LastName = student.LastName
                });

                ctx.SaveChanges();
            }

            return Ok();
        }
    }
}
