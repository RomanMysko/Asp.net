using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myWebApp.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Update
    {
        [Required]
        [MaxLength(140)]
        public string Status { get; set; }
        public DateTime Date { get; set; }
    }
}
