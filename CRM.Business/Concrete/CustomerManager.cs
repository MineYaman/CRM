using CRM.Business.Abstract;
using CRM.DataAccess.Abstract;
using CRM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _CustomerDal;

        public CustomerManager(ICustomerDal CustomerDal)
        {
            _CustomerDal = CustomerDal;
        }

        public void Create(Customer entity)
        {
            _CustomerDal.Create(entity);
        }

        public void Delete(Customer entity)
        {
            _CustomerDal.Delete(entity);
        }

        public List<Customer> GetAll()
        {
            return _CustomerDal.GetAll().ToList();
        }

        public Customer GetById(int id)
        {
            return _CustomerDal.GetById(id);
        }

        public void Update(Customer entity)
        {
            _CustomerDal.Update(entity);
        }
    }
}
