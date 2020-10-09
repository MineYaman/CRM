using CRM.Business.Abstract;
using CRM.DataAccess.Abstract;
using CRM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.Business.Concrete
{
    public class UserRoleManager : IUserRoleService
    {
        private IUserRoleDal _UserRoleDal;

        public UserRoleManager(IUserRoleDal UserRoleDal)
        {
            _UserRoleDal = UserRoleDal;
        }
        public void Create(UserRole entity)
        {
            _UserRoleDal.Create(entity);
        }

        public void Delete(UserRole entity)
        {
            _UserRoleDal.Delete(entity);
        }

        public List<UserRole> GetAll()
        {
            return _UserRoleDal.GetAll().ToList();
        }

        public UserRole GetById(int id)
        {
            return _UserRoleDal.GetById(id);
        }

        public void Update(UserRole entity)
        {
            _UserRoleDal.Update(entity);
        }
    }
}
