using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HepsiSurada.Business;
using Microsoft.AspNetCore.Mvc;
using HepsiSurada.Model;
using HepsiSuradav2.Areas.Admin.Models;
using HepsiSurada.Model.Entities;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using HepsiSuradav2.Extensions;


namespace HepsiSuradav2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthenticationController : Controller
    {
        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }



        //FULLPOSTBACK ILE
        //[HttpPost]
        //public ViewResult LogIn(LogInViewModel vm)
        //{

        //    AdminBs bs = new AdminBs();

        //    HepsiSurada.Model.Entities.Admin Admin = bs.LogIn(vm.Email, vm.Password);


        //    if (Admin != null)
        //    {
        //        ViewBag.Message = "Basarili";
        //        ViewBag.AlertStyle = "success";
        //        return View();
        //    }
        //    else
        //    {
        //        ViewBag.Message = "Basarisiz";
        //        ViewBag.AlertStyle = "danger";
        //        return View();
        //    }

        //}



        //JQUERY AJAX YONTEMI ILE
        [HttpPost]
        public JsonResult LogIn(LogInViewModel jsonData)
        {
            AdminBs bs = new AdminBs();
            HepsiSurada.Model.Entities.Admin admin =
                bs.LogIn(jsonData.Email, jsonData.Password,"AdminRoles");
            if (admin != null)
            {
              

                HttpContext.Session.SetObject("LoggedInAdmin", admin); 
                return Json(new { Result=true });

                
                
            }
            else
            {
                return Json(new { Result=false, Message = "Kullanıcı Bulunamadı", AlertStyle = "danger" });
            }

        }
    }
}
