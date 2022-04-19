using Allup.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Areas.Manage.Controllers
{
    [Area("manage")]
    public class BrandsController : Controller
    {
        private readonly AllupDbContext _context;
        public BrandsController(AllupDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Brands.FirstOrDefaultAsync()) ;
        }
        public async Task<IActionResult> Update()
        {
            return View(await _context.Brands.FirstOrDefaultAsync());
        }
        public async Task<IActionResult> Detail()
        {
            ViewBag.Brands = await _context.Brands.FirstOrDefaultAsync();
            return View(await _context.Brands.FirstOrDefaultAsync());
        }
    }
}
