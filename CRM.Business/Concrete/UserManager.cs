using CRM.Business.Abstract;
using CRM.DataAccess.Abstract;
using CRM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _UserDal;

        public UserManager(IUserDal UserDal)
        {
            _UserDal = UserDal;
        }

        public void Create(User entity)
        {
            _UserDal.Create(entity);
        }

        public void Delete(User entity)
        {
            _UserDal.Delete(entity);
        }

        public List<User> GetAll()
        {
            return _UserDal.GetAll().ToList();
        }

        public User GetById(int id)
        {
            return _UserDal.GetById(id);
        }

        public void Update(User entity)
        {
            _UserDal.Update(entity);
        }
    }
}
