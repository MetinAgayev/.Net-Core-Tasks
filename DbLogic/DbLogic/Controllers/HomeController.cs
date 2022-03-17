using DbLogic.DAL;
using DbLogic.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbLogic.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProDbContext _context;
        public HomeController(ProDbContext proDbContext)
        {
            _context = proDbContext;
        }
        public IActionResult Index()
        {
           List<Product> products =_context.products.ToList();

            return View(products);
        }
    }
}
