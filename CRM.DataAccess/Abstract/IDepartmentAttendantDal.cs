using CRM.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.DataAccess.Abstract
{
    public interface IDepartmentAttendantDal : IRepository<DepartmentAttendant>
    {
        void DeleteDepartmentAttendant(int departmentId, string userId);
    }
}
