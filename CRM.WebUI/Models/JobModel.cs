using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.WebUI.Models
{
    public class JobModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "İş adı boş geçilemez")]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "İş adı minimum 4 karakter ve maksimum 20 karakter olmalıdır.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "İş açıklaması boş geçilemez")]
        [StringLength(60, MinimumLength = 10, ErrorMessage = "İş  10 karakter ve maksimum 60 karakter olmalıdır.")]
        public string Descripton { get; set; }

        [Required(ErrorMessage = "Tarih boş geçilemez")]
        [Column(TypeName = "smalldatetime")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Tarih boş geçilemez")]
        [Column(TypeName = "smalldatetime")]
        public DateTime DateCompleted { get; set; }
    }
}
