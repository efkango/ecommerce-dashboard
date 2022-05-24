using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HepsiSuradav2.Areas.Ogrenci.Controllers
{
    [Area("Ogrenci")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}