using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamBuilder.Models;

namespace TeamBuilder.Controllers
{
    public class HowitworksController : Controller
    {
        private readonly DataBaseContext db;

        public HowitworksController(DataBaseContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewData["ProfileVisible"] = HttpContext.Request.Cookies.ContainsKey("UserData");
            if ((bool)ViewData["ProfileVisible"])
            {
                int VkId = int.Parse(HttpContext.Request.Cookies["UserData"]);
                User User = await db.Users.Where(u => u.VkId == VkId).FirstAsync();
                ViewData["FirstName"] = User.FirstName;
                ViewData["LastName"] = User.LastName;
                ViewData["Photo50"] = User.Photo50;
            }
            return View();
        }
    }
}
