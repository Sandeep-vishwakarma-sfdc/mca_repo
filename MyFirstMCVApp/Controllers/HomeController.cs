using MyFirstMCVApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMCVApp.Controllers
{
    public class HomeController:Controller {
        // GET: Home
        public ViewResult Index() {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Day";
            return View();
        }
        [HttpGet]
        public ViewResult CustomerInput() {
            return View();
        }

        [HttpPost]
        public ViewResult CustomerInput(Customer c1) {
            if (ModelState.IsValid)
                return View("customerDisplay",c1);
            else
                return View();

        }
    }
}