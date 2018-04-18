using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using CarmenSandiego.Models;

namespace CarmenSandiego.Models
{
    [Table("People")]
    public class Person
    {   
        [Key]
        public int PersonId { get; set; }
        public string Name { get; set; }
        public Experience Experience { get; set; }
        public int ExperienceId { get; set; }
        public string Description { get; set; }
    }
}
