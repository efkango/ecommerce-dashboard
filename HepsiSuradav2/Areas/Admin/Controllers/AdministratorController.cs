using System;
using System.Collections.Generic;
using System.Linq;
using HepsiSurada.Business;
using HepsiSurada.Model.Entities;
using HepsiSuradav2.Areas.Admin.Filters;
using HepsiSuradav2.Areas.Admin.Models;
using HepsiSuradav2.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HepsiSuradav2.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdministratorController : Controller
    {

        private readonly AdminBs _adminBs;
        private readonly RoleBs _roleBs;
        private readonly AdminRoleBs _adminRoleBs;

        public AdministratorController()
        {
            _adminBs = new AdminBs();
            _roleBs = new RoleBs();
            _adminRoleBs = new AdminRoleBs();
        }

        [CheckifAllowed(AllowedRoles = new int[] { 1})]
        public IActionResult Index()
        {
            List<HepsiSurada.Model.Entities.Admin> adminList = _adminBs.GetAll("AdminRoles","AdminRoles.Role");

            return View(adminList);
        
        }
        [HttpGet]
        public IActionResult Add()
        {
            List<Role> roleList = _roleBs.GetAll();
            return View(roleList);
        }
        [HttpPost]
        public IActionResult Add(AddNewAdminVm vm)
        {

            HepsiSurada.Model.Entities.Admin admin = new HepsiSurada.Model.Entities.Admin();
            admin.FullName = vm.FullName;
            admin.Email = vm.Email;
            admin.Password = vm.Password;
            admin.IsActive = vm.Aktif;
            //admin.PhotoPath = vm.PhotoPath;
            admin.HireDate = vm.HireDate;

            _adminBs.Insert(admin);

            for (int i = 0; i < vm.RoleId.Length; i++)
            {
                AdminRole aRole = new AdminRole();
                aRole.AdminId = admin.Id;
                aRole.RoleId = vm.RoleId[i];
                aRole.IsActive= true;


                _adminRoleBs.Insert(aRole);
            }

            return Json(new {Result= true, Message="Kayit Basarili" });
         
        }
        
        //[HttpPost]
        //public IActionResult UploadAdminPhoto(IFormCollection data)
        //{

        //    IFormFile file = data.Files[0];

        //    if (file == null)
        //    {
        //        return Json(new { Result = false, Message = "Lutfen Fotograf Seciniz" });
        //    }
        //    if (!file.ContentType.Contains("image/"))
        //    {
        //        return Json(new { Result = false, Message = "Lutfen Resim Dosyasi Seciniz" });
        //    }
        //    if (file.Length > 300 * 1024)
        //    {
        //        return Json(new { Result = false, Message = "Resim Dosyasi 300kb den fazla olamaz" });
        //    }
        //    return Json(new {Result= true,PhotoPath =""});
        //}
        //public IActionResult DeleteAdmin(int adId)
        //{
        //    List<AdminRole> roles = _adminRoleBs.GetAllByAdminId(adId);

        //    foreach (var item in roles)
        //        _adminRoleBs.Delete(item);

        //    _adminBs.Delete(adId);

        //    return Json(new {Result=true, Message="Yonetici Basariyla Silindi" });
        //}
        public IActionResult Forbidden()
        {
             return View();
        }

    }
}
