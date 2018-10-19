using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManager.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public decimal Salary { get; set; }

        public virtual ICollection<Skill> Skills { get; set; } = new List<Skill>();
    }
}