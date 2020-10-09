using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.WebUI.Models
{
    public class UserModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string RoleName { get; set; }
        public bool Working { get; set; }
        public bool Deleted { get; set; }
    }
}
