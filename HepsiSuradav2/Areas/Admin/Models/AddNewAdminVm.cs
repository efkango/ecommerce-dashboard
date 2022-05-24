using System;
namespace HepsiSuradav2.Areas.Admin.Models
{
    public class AddNewAdminVm
    {
        public string FullName { get; set; }
        public string Password { get; set; }
        public bool Aktif { get; set;  }
        public string PhotoPath { get; set; } 
        public string Email { get; set; }
        public string HireDate { get; set; }
        public int[] RoleId { get; set; }
    }
}
 