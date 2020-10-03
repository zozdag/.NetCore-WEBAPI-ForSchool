using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIForSchool.Models
{
    public class Human
    {
        [Key]
        public int id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string SurName { get; set; }

        public int Age { get; set; }
        public string Gender { get; set; }

    }
}
