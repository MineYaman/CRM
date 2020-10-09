using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.WebUI.Models
{
    public class DepartmentModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Departman adı boş geçilemez")]
        [StringLength(60, MinimumLength = 4, ErrorMessage = "Departman adı minimum 4 karakter ve maksimum 60 karakter olmalıdır.")]
        public string Name { get; set; }
        public bool Deleted { get; set; }
    }
}
