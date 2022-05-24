using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HepsiSuradav2.Areas.Admin.Models
{
    public class LogInViewModel
    {
        
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
