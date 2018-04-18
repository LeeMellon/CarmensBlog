using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using CarmenSandiego.Models;
namespace CarmenSandiego.Models
{
    [Table("Experiences")]
    public class Experience
    {
        [Key]
        public int ExperienceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual Location Location { get; set; }
        public int LocationId { get; set; }
        public virtual List<Person> People { get; set; }

    }
}
