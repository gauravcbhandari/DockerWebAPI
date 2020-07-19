using DockerAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerAPI.Repository
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        {

        }
        public DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connstring = "Server=tcp:gbdockerdb.database.windows.net,1433;Initial Catalog=gaurav;Persist Security Info=False;User ID=gauravcbhandari;Password=gomzzy@951991";

            optionsBuilder.UseSqlServer(connstring);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
