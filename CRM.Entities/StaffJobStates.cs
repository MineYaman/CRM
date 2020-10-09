using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Entities
{
    public  class StaffJobStates
    {
        public string UserId { get; set; }
        public User Users { get; set; }

        public int JobStateId { get; set; }
        public JobState JobStates { get; set; }
    }
}
