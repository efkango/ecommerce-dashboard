using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql;
namespace HepsiSurada.Model.Entities
{
    
    public class Admin:BaseEntity
    {
        
        public string FullName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        //public string PhotoPath { get; set; }

        public string HireDate { get; set; }


        public virtual ICollection<AdminRole> AdminRoles { get; set; }
        
    }
}
