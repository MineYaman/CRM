using CRM.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.DataAccess.Abstract
{
    public interface IDepartmentJobDal : IRepository<DepartmentJob>
    {
        void DeleteDepartmentJob(int departmentId, int jobId);
    }
}
