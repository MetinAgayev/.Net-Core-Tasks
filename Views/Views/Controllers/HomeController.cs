using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Views.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index() {
            ViewData["Name"] = "Metin";
            return View();
        }
        public IActionResult About() {
            return View();
        }
        public IActionResult Contact() {
            return View();
        }
    }
}
