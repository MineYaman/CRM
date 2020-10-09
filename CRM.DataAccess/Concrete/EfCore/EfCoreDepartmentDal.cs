using CRM.DataAccess.Abstract;
using CRM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CRM.DataAccess.Concrete.EfCore
{
    public class EfCoreDepartmentDal : EfCoreGenericRepository<Department,CrmContext> ,IDepartmentDal
    {
       
    }
}
