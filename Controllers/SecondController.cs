using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMVCCore.Controllers
{
    public class SecondController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult First()
        {
            return View();
        }

        public string Second()
        {
            return "Hello from Secong Action Method";
        }

        public IActionResult Third()
        {
            return RedirectToAction("Index");
        }

        public IActionResult Fourth()
        {
            // ViewBag is like a dynamic object
            ViewBag.date = new DateTime().ToShortDateString();
            ViewBag.name = "Deepak";
            // Dictionary
            ViewData["address"] = "Delhi";
            return View();
        }
    }
}
