using CRM.Business.Abstract;
using CRM.DataAccess.Abstract;
using CRM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.Business.Concrete
{
    public class DepartmentJobManager : IDepartmentJobService
    {
        private IDepartmentJobDal _DepartmentJobDal;

        public DepartmentJobManager(IDepartmentJobDal DepartmentJobDal)
        {
            _DepartmentJobDal = DepartmentJobDal;
        }

        public void Create(DepartmentJob entity)
        {
            _DepartmentJobDal.Create(entity);
        }

        public void Delete(DepartmentJob entity)
        {
            _DepartmentJobDal.Delete(entity);
        }

        public void DeleteDepartmentJob(int departmentId, int jobId)
        {
            _DepartmentJobDal.DeleteDepartmentJob(departmentId, jobId);
        }

        public List<DepartmentJob> GetAll()
        {
            return _DepartmentJobDal.GetAll().ToList();
        }

        public DepartmentJob GetById(int id)
        {
            return _DepartmentJobDal.GetById(id);
        }

        public void Update(DepartmentJob entity)
        {
            _DepartmentJobDal.Update(entity);
        }
    }
}
