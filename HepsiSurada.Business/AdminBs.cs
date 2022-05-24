using System;
using System.Collections.Generic;
using HepsiSurada.DataAccess.Repositories;
using HepsiSurada.Model.Entities;

namespace HepsiSurada.Business
{
    public class AdminBs
    {
        AdminRepository _repo;

        public AdminBs()
        {
            _repo = new AdminRepository();
        }

        public Admin LogIn(string Email, string Password,params string[] includeList)
        {
            return _repo.LogIn(Email, Password, includeList);
        }

        public List<Admin> GetAll(params string[] includeList )
        {
            return _repo.GetAll(filter: null, includeList: includeList);
        }
        public void  Insert(Admin admin)
        {
            _repo.Add(admin);
        }

         public void Delete(int id)
        {
            _repo.Delete(id);
        }
    }
}
