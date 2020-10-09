using CRM.DataAccess.Abstract;
using CRM.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.DataAccess.Concrete.EfCore
{
    public class EfCoreDepartmentStaffDal : EfCoreGenericRepository<DepartmentStaff, CrmContext>, IDepartmentStaffDal
    {
        public void DeleteDepartmentStaff(int departmentId, string userId)
        {
            using (var context = new CrmContext())
            {
                var result = context.DepartmentStaffs.FirstOrDefault(x => x.DepartmentId == departmentId && x.UserId == userId);
                context.Remove(result);
                context.SaveChanges();
            }
        }
    }
}
