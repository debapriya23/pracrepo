using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication24.Models
{
    [Table("person")]
    public class person
    {
        [Key]
        public int pid { get; set; }

        [Required]
        public int Name { get; set; }
        [Required]

        public int Age { get; set; }
    }
}
