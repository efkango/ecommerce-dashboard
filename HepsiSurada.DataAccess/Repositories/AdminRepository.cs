using System;
using HepsiSurada.DataAccess.Contexts;
using HepsiSurada.Model.Entities;
using System.Linq;
using Infrastructure.DataAccess;

namespace HepsiSurada.DataAccess.Repositories
{
    public class AdminRepository : RepositoryBase<Admin, HepsiSuradaDBContext>
    {

        public Admin LogIn(string Email, string Password, params string[] includeList)
        {
            return Get(x => x.Email == Email && x.Password == Password, includeList);



        }

    }
}
