using CRM.Business.Abstract;
using CRM.DataAccess.Abstract;
using CRM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.Business.Concrete
{
    public class RoleManager : IRoleService
    {
        private IRoleDal _RoleDal;

        public RoleManager(IRoleDal RoleDal)
        {
            _RoleDal = RoleDal;
        }

        public void Create(Role entity)
        {
            _RoleDal.Create(entity);
        }

        public void Delete(Role entity)
        {
            _RoleDal.Delete(entity);
        }

        public List<Role> GetAll()
        {
            return _RoleDal.GetAll().ToList();
        }

        public Role GetById(int id)
        {
            return _RoleDal.GetById(id);
        }

        public void Update(Role entity)
        {
            _RoleDal.Update(entity);
        }
    }
}
