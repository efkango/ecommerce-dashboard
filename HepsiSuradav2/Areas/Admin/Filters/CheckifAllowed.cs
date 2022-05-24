using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using HepsiSuradav2.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace HepsiSuradav2.Areas.Admin.Filters
{
    public class CheckifAllowed:ActionFilterAttribute ,IActionFilter 
    {
        public int[] AllowedRoles { get; set; } 
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            HepsiSurada.Model.Entities.Admin admin = context.HttpContext.Session.GetObject<HepsiSurada.Model.Entities.Admin>("LoggedInAdmin");


            foreach (var role in admin.AdminRoles)
            {
                foreach (var allowedRoleId  in AllowedRoles )
                {
                    if(allowedRoleId == role.RoleId)
                    {
                        return;
                    }
                }
            }

            context.Result = new RedirectToActionResult("Forbidden", "Administrator", null);
        }


    }
}
