using CRM.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Business.Abstract
{
    public interface IDepartmentJobService : IGenericService<DepartmentJob>
    {
        void DeleteDepartmentJob(int departmentId, int jobId);
    }
}
