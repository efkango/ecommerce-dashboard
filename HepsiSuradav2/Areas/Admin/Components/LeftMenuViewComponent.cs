using System;
using HepsiSuradav2.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace HepsiSuradav2.Areas.Admin.Components
{
    public class LeftMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            HepsiSurada.Model.Entities.Admin admin = HttpContext.Session.GetObject<HepsiSurada.Model.Entities.Admin>("LoggedInAdmin");

            ViewBag.LoggedInAdmin = admin;

            return View();
        }
    }
}
