using CRM.Business.Abstract;
using CRM.DataAccess.Abstract;
using CRM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.Business.Concrete
{
    public class DepartmentAttendantManager : IDepartmentAttendantService
    {
        private IDepartmentAttendantDal _DepartmentAttendantDal;

        public DepartmentAttendantManager(IDepartmentAttendantDal DepartmentAttendantDal)
        {
            _DepartmentAttendantDal = DepartmentAttendantDal;
        }

        public void Create(DepartmentAttendant entity)
        {
            _DepartmentAttendantDal.Create(entity);
        }

        public void Delete(DepartmentAttendant entity)
        {
            _DepartmentAttendantDal.Delete(entity);
        }

        public void DeleteDepartmentAttendant(int departmentId, string userId)
        {
            _DepartmentAttendantDal.DeleteDepartmentAttendant(departmentId, userId);
        }

        public List<DepartmentAttendant> GetAll()
        {
            return _DepartmentAttendantDal.GetAll().ToList();
        }

        public DepartmentAttendant GetById(int id)
        {
            return _DepartmentAttendantDal.GetById(id);
        }

        public void Update(DepartmentAttendant entity)
        {
            _DepartmentAttendantDal.Update(entity);
        }
    }
}
