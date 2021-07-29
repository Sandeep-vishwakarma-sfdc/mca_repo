using CustomerMVC_APP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerMVC_APP.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult CustomerInput()
        {
            return View();
        }
        [HttpPost]
        public ViewResult CustomerInput(Customer C1)
        {
            if (ModelState.IsValid)
            {
                return View("CustomerDisplayed", C1);
            }
            else
                return View(); 
        }
    }
}