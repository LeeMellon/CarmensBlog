using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarmenSandiego.Models
{
    public class CarmenSandiegoContext : DbContext
    {
        public DbSet<Location> Locations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"Server=localhost;Port=8889;database=carmensandiego;uid=root;pwd=root;");
    }
}
