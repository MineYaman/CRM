using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsEmpty { get; set; }
        public bool Deleted { get; set; }

        public List<Assignment> Assignments { get; set; }
        public List<DepartmentJob> DepartmentJobs { get; set; }
        public List<DepartmentStaff> DepartmentStaffs { get; set; }
        public List<DepartmentAttendant> DepartmentAttendants { get; set; }

    }
}
