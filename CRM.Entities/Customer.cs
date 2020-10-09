using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Deleted { get; set; }

        public List<CustomerJob> CustomerJobs { get; set; }
    }
}
