using Allup.DAL;
using Allup.Extensions;
using Allup.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Areas.Manage.Controllers
{
    [Area("manage")]
    public class SettingController : Controller
    {
        private readonly AllupDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SettingController(AllupDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;

        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Settings.FirstOrDefaultAsync());
        }
        public async Task<IActionResult> Detail()
        {
            return View(await _context.Settings.FirstOrDefaultAsync());
        }
        public async Task<IActionResult> Update()
        {
            return View(await _context.Settings.FirstOrDefaultAsync());
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Update(Settings settings)
        {
            
            Settings dbsetting = await _context.Settings.FirstOrDefaultAsync();
            settings.Logo = dbsetting.Logo;

            if (settings.LogoImage != null)
            {

                if (!settings.LogoImage.CheckSize(70))
                {

                    ModelState.AddModelError("LogoImage", "Shekilin olcusu max 70 kb ola biler");
                    return View(settings);
                }

                if (!settings.LogoImage.CheckType("image/png"))
                {
                    ModelState.AddModelError("LogoImage", "Shekil png formatinda olmalidir");
                    return View(settings);
                }

                Helper.Helper.DeleteFile(dbsetting.Logo, _env, "assets", "images");

                dbsetting.Logo = settings.LogoImage.CreateFile(_env, "assets", "images");
            }
          
            dbsetting.Offer = settings.Offer;
            dbsetting.Phone = settings.Phone;
            dbsetting.SupportPhone = settings.SupportPhone;
            dbsetting.WorkDay = settings.WorkDay;
            dbsetting.Email = settings.Email;
            dbsetting.Address = settings.Address;
            dbsetting.UpdatedAt = DateTime.UtcNow.AddHours(+4);

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
