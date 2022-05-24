using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HepsiSuradav2.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace HepsiSuradav2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string jsonStr = HttpContext.Session.GetString("LoggedInAdmin");



            HepsiSurada.Model.Entities.Admin admin = HttpContext.Session.GetObject<HepsiSurada.Model.Entities.Admin>("LoggedInAdmin");


            ViewBag.LoggedInAdminFullName = admin.FullName;
            return View();
        }
    }
}