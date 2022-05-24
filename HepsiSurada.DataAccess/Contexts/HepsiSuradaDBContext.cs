using Microsoft.EntityFrameworkCore;
using HepsiSurada.Model.Entities;
using Npgsql;
using HepsiSurada.Model;
using System.Data.SqlTypes;
using Microsoft.Extensions.Options;

namespace HepsiSurada.DataAccess.Contexts
{
    public class HepsiSuradaDBContext : DbContext
    {
    

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=HepsiSuradaDB;Username=postgres;Password=1923");

         
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<AdminRole> AdminRoles { get; set; }
    }   
}
