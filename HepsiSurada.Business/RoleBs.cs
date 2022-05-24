using System;
using System.Collections.Generic;
using HepsiSurada.DataAccess.Repositories;
using HepsiSurada.Model.Entities;

namespace HepsiSurada.Business
{
    public class RoleBs
    {
        RoleRepository _repo;

        public RoleBs()
        {
            _repo = new RoleRepository();
        }

        public Role GetById(int Id)
        {
            return _repo.GetByID(Id);
        }

        public List<Role> GetAll()
        {
            return _repo.GetAll();
        }
    }
}
