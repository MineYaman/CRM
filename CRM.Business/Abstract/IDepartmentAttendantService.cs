using CRM.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Business.Abstract
{
    public interface IDepartmentAttendantService : IGenericService<DepartmentAttendant>
    {
        void DeleteDepartmentAttendant(int departmentId, string userId);
    }
}
