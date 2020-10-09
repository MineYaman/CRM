using CRM.Business.Abstract;
using CRM.DataAccess.Abstract;
using CRM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CRM.Business.Concrete
{
    public class CustomerJobManager : ICustomerJobService
    {
        private ICustomerJobDal _CustomerJobDal;

        public CustomerJobManager(ICustomerJobDal CustomerJobDal)
        {
            _CustomerJobDal = CustomerJobDal;
        }

        public void Create(CustomerJob entity)
        {
            _CustomerJobDal.Create(entity);
        }

        public void Delete(CustomerJob entity)
        {
            _CustomerJobDal.Delete(entity);
        }

        public List<CustomerJob> GetAll()
        {
            return _CustomerJobDal.GetAll().ToList();
        }

        public CustomerJob GetById(int id)
        {
            return _CustomerJobDal.GetById(id);
        }

        public void Update(CustomerJob entity)
        {
            _CustomerJobDal.Update(entity);
        }
    }
}
