using AlMajd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlMajd.Controllers
{
    public class HomeController : Controller
    {
        AlMajdEntities door = new AlMajdEntities();


        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TravellersIndex()
        {
            var list = door.TravellerInformations.OrderByDescending(a => a.dateOfTravel).ToList();

            if (list.Any())
            {
                var List = door.ServiceTypes.ToList();
                var ServiseList = new SelectList(List, "serviceId", "serviceName");
                ViewBag.ServiseList = ServiseList;

                ViewBag.listTravllers = list;
                return View();
            }
            return View();
        }
        public ActionResult CommingIndex()
        {
            return View();
        }

    }
}