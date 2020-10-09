using CRM.Business.Abstract;
using CRM.DataAccess.Abstract;
using CRM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.Business.Concrete
{
    public class JobStateManager : IJobStateService
    {
        private IJobStateDal _JobStateDal;

        public JobStateManager(IJobStateDal JobStateDal)
        {
            _JobStateDal = JobStateDal;
        }

        public void Create(JobState entity)
        {
            _JobStateDal.Create(entity);
        }

        public void Delete(JobState entity)
        {
            _JobStateDal.Delete(entity);
        }

        public List<JobState> GetAll()
        {
            return _JobStateDal.GetAll().ToList();
        }

        public JobState GetById(int id)
        {
            return _JobStateDal.GetById(id);
        }

        public void Update(JobState entity)
        {
            _JobStateDal.Update(entity);
        }
    }
}
