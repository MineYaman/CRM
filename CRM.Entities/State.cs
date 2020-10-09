using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Entities
{
    public class State
    {
        public int Id { get; set; }

        public string StateName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DateCompleted { get; set; }


        public List<JobState> JobStates { get; set; }
    }
}
