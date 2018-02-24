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
        List<City> newCitys = City.GetAll();
        return View(newCitys);
        }

        [HttpPost("/")]
        public ActionResult GetPopulation()
        {
          int cityPopulation = int.Parse(Request.Form["population"]);
          List<City> newList = City.GetMostPopulous(cityPopulation);
          return View("Index", newList);
        }

        [HttpPost("/new")]
        public ActionResult Alpha()
        {
          string cityName = (Request.Form["name"]);
          List<City> newList = City.GetAlphabetically(cityName);
          return View("Index", newList);
        }




    }
}
