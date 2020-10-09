using CRM.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.DataAccess.Abstract
{
    public interface IDepartmentStaffDal : IRepository<DepartmentStaff>
    {
        void DeleteDepartmentStaff(int departmentId, string userId);
    }
}
