using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using HairSalon.Models;

namespace HairSalon.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
        List<Stylist> newStylists = Stylist.GetAll();
        return View(newStylists);
        }

        [HttpPost("/")]
        public ActionResult GetName()
        {
          int stylistName = int.Parse(Request.Form["stylist"]);
          List<Stylist> newList = Stylist.GetName(stylistName);
          return View("Index", newList);
        }

        [HttpPost("/new")]
        public ActionResult Alpha()
        {
          string stylistName = (Request.Form["name"]);
          List<Stylist> newList = Stylist.GetAlphabetically(sylistName);
          return View("Index", newList);
        }




    }
}
