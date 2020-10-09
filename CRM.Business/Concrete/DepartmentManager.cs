using CRM.Business.Abstract;
using CRM.DataAccess.Abstract;
using CRM.DataAccess.Concrete.EfCore;
using CRM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.Business.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        private IDepartmentDal _departmentDal;

        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }

        public void Create(Department entity)
        {
            _departmentDal.Create(entity);
        }

        public void Delete(Department entity)
        {
            _departmentDal.Delete(entity);
        }

        public List<Department> GetAll()
        {
           // return _departmentDal.GetAll().ToList();
            return _departmentDal.GetAll(d=>d.Deleted==false).ToList();
        }

        public Department GetById(int id)
        {
            return _departmentDal.GetById(id);
        }

        public void Update(Department entity)
        {
            _departmentDal.Update(entity);
        }
    }
}
