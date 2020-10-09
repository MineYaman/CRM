using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Entities
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string RoleName { get; set; }
        public bool Working { get; set; }
        public bool Deleted { get; set; }

        public List<Assignment> Assignments { get; set; }
        public List<UserRole> UserRoles { get; set; }
        public List<DepartmentStaff> DepartmentStaffs { get; set; }
        public List<DepartmentAttendant> DepartmentAttendants { get; set; }
    }
}
