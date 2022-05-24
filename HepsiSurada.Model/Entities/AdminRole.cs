using System;
using Infrastructure.Models;

namespace HepsiSurada.Model.Entities
{
    public class AdminRole:BaseEntity
    {
      public int? AdminId { get; set; }
      public int? RoleId { get; set; }

      public virtual Role Role { get; set; }
      
        
    }
}
