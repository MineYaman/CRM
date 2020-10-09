using CRM.Business.Abstract;
using CRM.DataAccess.Abstract;
using CRM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.Business.Concrete
{
    public class DepartmentStaffManager : IDepartmentStaffService
    {
        private IDepartmentStaffDal _DepartmentStaffDal;

        public DepartmentStaffManager(IDepartmentStaffDal DepartmentStaffDal)
        {
            _DepartmentStaffDal = DepartmentStaffDal;
        }

        public void Create(DepartmentStaff entity)
        {
            _DepartmentStaffDal.Create(entity);
        }

        public void Delete(DepartmentStaff entity)
        {
            _DepartmentStaffDal.Delete(entity);
        }

        public void DeleteDepartmentStaff(int departmentId, string userId)
        {
            _DepartmentStaffDal.DeleteDepartmentStaff(departmentId, userId);
        }

        public List<DepartmentStaff> GetAll()
        {
            return _DepartmentStaffDal.GetAll().ToList();
        }

        public DepartmentStaff GetById(int id)
        {
            return _DepartmentStaffDal.GetById(id);
        }

        public void Update(DepartmentStaff entity)
        {
            _DepartmentStaffDal.Update(entity);
        }
    }
}
