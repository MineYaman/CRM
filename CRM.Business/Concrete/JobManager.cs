using CRM.Business.Abstract;
using CRM.DataAccess.Abstract;
using CRM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.Business.Concrete
{
    public class JobManager : IJobService
    {
        private IJobDal _JobDal;

        public JobManager(IJobDal JobDal)
        {
            _JobDal = JobDal;
        }

        public void Create(Job entity)
        {
            _JobDal.Create(entity);
        }

        public void Delete(Job entity)
        {
            _JobDal.Delete(entity);
        }

        public List<Job> GetAll()
        {
            return _JobDal.GetAll().ToList();
        }

        public Job GetById(int id)
        {
            return _JobDal.GetById(id);
        }

        public void Update(Job entity)
        {
            _JobDal.Update(entity);
        }
    }
}
