using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myWebApp.ViewModels;

namespace myWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(ReservationViewModel model)
        {

            return Index();
        }
    }
}
