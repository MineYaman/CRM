using CRM.DataAccess.Abstract;
using CRM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.DataAccess.Concrete.EfCore
{
    public class EfCoreDepartmentJobDal : EfCoreGenericRepository<DepartmentJob, CrmContext>, IDepartmentJobDal
    {
        public void DeleteDepartmentJob(int departmentId, int jobId)
        {
            using (var context = new CrmContext())
            {
                var result = context.DepartmentJobs.FirstOrDefault(x => x.DepartmentId == departmentId && x.JobId == jobId);
                context.Remove(result);
                context.SaveChanges();
            }
        }
    }
}
