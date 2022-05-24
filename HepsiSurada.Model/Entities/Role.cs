using System;
using System.Collections.Generic;
using Infrastructure.Models;

namespace HepsiSurada.Model.Entities
{
    public class Role:BaseEntity
    {
        public string RoleName { get; set; }


        public ICollection<AdminRole> AdminRoles { get; set; }
    }
}
