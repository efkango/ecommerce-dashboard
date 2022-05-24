using System;
using System.Collections.Generic;
using HepsiSurada.DataAccess.Repositories;
using HepsiSurada.Model.Entities;

namespace HepsiSurada.Business
{
    public class AdminRoleBs
    {
        AdminRoleRepository _repo;

        public AdminRoleBs()
        {
            _repo = new AdminRoleRepository();
        }

        public AdminRole GetById(int Id)
        {
            return _repo.GetByID(Id);
        }

        public List<AdminRole> GetAll()
        {
            return _repo.GetAll();
        }

        public List<AdminRole> GetAllByAdminId(int adminId)
        {
            return _repo.GetAll(x => x.AdminId == adminId);

        }
        public void Insert(AdminRole adminRole)
        {
            _repo.Add(adminRole);
        }

        public void Delete(AdminRole entity)
        {
            _repo.delete(entity);
        }
    }
}
