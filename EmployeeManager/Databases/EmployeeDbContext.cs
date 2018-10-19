using EmployeeManager.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeeManager.Databases
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext() : base(ConfigurationManager.ConnectionStrings["EmployeesDbContext"].ConnectionString)
        {
        }
        
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<Field> Fields { get; set; }

        public DbSet<Title> Titles { get; set; }

        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            dbModelBuilder.Entity<Employee>().HasMany(e => e.Skills);
        }
    }
}