using Microsoft.EntityFrameworkCore;
using SchoolMagazine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace School_Magazine
{
    internal class ApplicationContext : DbContext
    {
        string section { get; set; }
        public DbSet<Student> Students { get; set; }
        public ApplicationContext(string inf)
        {
            this.section = inf;

            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(section);
        }
    }
} 
