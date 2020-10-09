using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Entities
{
    public class Job
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descripton { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DateCompleted { get; set; }

        public List<Assignment> Assignments { get; set; }
        public List<DepartmentJob> DepartmentJobs { get; set; }
        public List<CustomerJob> CustomerJobs { get; set; }
        public List<JobState> JobStates { get; set; }
    }
}
