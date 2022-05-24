using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Models
{
    
    public abstract class BaseEntity
    {
        
        public int Id { get; set; }
        public Boolean IsActive { get; set; }
    }
}
