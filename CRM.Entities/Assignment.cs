using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Entities
{
    public class Assignment
    {
        public int DepartmentId { get; set; }
        public Department Departments { get; set; }

        public string UserId { get; set; }
        public User Users { get; set; }

        public int JobId { get; set; }
        public Job Jobs { get; set; }
    }
}
