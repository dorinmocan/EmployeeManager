using EmployeeManager.Entities;
using System.Configuration;
using System.Data.Entity;

namespace EmployeeManager.Databases
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext() : base(ConfigurationManager.ConnectionStrings["EmployeesDbContext"].ConnectionString)
        {
        }

        public DbSet<Field> Fields { get; set; }

        public DbSet<Title> Titles { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Field>()
            .HasMany<Skill>(f => f.Skills)
            .WithRequired(s => s.Field)
            .HasForeignKey<int>(s => s.FieldId);

            modelBuilder.Entity<Title>()
            .HasMany<Skill>(t => t.Skills)
            .WithRequired(s => s.Title)
            .HasForeignKey<int>(s => s.TitleId);

            modelBuilder.Entity<Employee>()
            .HasMany<Skill>(e => e.Skills)
            .WithRequired(s => s.Employee)
            .HasForeignKey<int>(s => s.EmployeeId);
        }
    }
}