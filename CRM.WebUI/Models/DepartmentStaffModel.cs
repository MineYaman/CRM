using CRM.Entities;
using CRM.WebUI.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.WebUI.Models
{
    public class DepartmentStaffModel
    {
        public List<DepartmentStaff> DepartmentStaffs { get; set; }

       /* public List<Department> Departmentstaffs { get; set; }
        public List<ApplicationUser> ApplicationUsers { get; set; }
        public List<IdentityRole> AppRoles { get; set; }*/

        /*public Department department { get; set; }
        public ApplicationUser userApp { get; set; }
        public IdentityRole ıdentityRole { get; set; }*/
    }
}
