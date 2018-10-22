using System.Collections.Generic;

namespace EmployeeManager.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public decimal Salary { get; set; }

        public ICollection<Skill> Skills { get; set; }
    }
}