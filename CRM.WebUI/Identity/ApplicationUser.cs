using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.WebUI.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }

        public string RoleName { get; set; }

        public bool Working { get; set; }

        public bool Deleted { get; set; }
    }
}
