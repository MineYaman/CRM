using CRM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM.DataAccess.Concrete.EfCore
{
    public class SeedDatabase
    {
        public static void Seed()
        {
            var context = new CrmContext();

            if (context.Departments.Count()==0)
            {
                context.Departments.AddRange(Departments);
            }

            context.SaveChanges();
        }

        private static Department[] Departments ={
            new Department() {Name = "Arge", Deleted = false},
            new Department() {Name = "Insan Kaynaklari", Deleted = false}
        };
    }
}
