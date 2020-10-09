using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Entities
{
    public class JobState
    {
        public int JobId { get; set; }
        public Job Jobs { get; set; }

        public int StateId { get; set; }
        public JobState JobStates { get; set; }

    }
}
