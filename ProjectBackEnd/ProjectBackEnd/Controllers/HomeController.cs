using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectBackEnd.DAL;
using ProjectBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEnd.Controllers
{
    public class HomeController : Controller
    {
        private readonly NestDb _context;
        public HomeController(NestDb context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            Section1 section1 = _context.Section1.Include(a=>a.Section1Searches).FirstOrDefault();
            Section2 section2 = _context.Section2.FirstOrDefault();
            return View(section1);
        }
    }
}
