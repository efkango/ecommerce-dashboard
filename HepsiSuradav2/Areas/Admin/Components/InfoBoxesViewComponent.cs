using System;
using Microsoft.AspNetCore.Mvc;

namespace HepsiSuradav2.Areas.Admin.Components
{
    public class InfoBoxesViewComponent:ViewComponent
    {

        public IViewComponentResult Invoke(string bgColorClassName)
        {
            ViewBag.bgColorClassName = bgColorClassName;
            return View();
        }

        
    }
}
