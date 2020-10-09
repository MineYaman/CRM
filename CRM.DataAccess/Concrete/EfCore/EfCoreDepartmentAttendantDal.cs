using CRM.DataAccess.Abstract;
using CRM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.DataAccess.Concrete.EfCore
{
    public class EfCoreDepartmentAttendantDal : EfCoreGenericRepository<DepartmentAttendant, CrmContext>, IDepartmentAttendantDal
    {
        public void DeleteDepartmentAttendant(int departmentId, string userId)
        {
            using (var context = new CrmContext())
            {
                var result = context.DepartmentAttendants.FirstOrDefault(x => x.DepartmentId == departmentId && x.UserId == userId);
                context.Remove(result);
                context.SaveChanges();
            }
        }
    }
}
