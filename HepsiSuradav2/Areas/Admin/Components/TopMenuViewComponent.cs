using System;
using Microsoft.AspNetCore.Mvc;

namespace HepsiSuradav2.Areas.Admin.Components
{
    public class TopMenuViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
        
    }
}
