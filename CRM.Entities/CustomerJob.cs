using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Entities
{
    public class CustomerJob
    {
        public int CustomerId { get; set; }
        public Customer Customers { get; set; }

        public int JobId { get; set; }
        public Job Jobs { get; set; }
    }
}
