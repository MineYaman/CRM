using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Entities
{
    public class Role
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public List<UserRole> UserRoles { get; set; }
    }
}
