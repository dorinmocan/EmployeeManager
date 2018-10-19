using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManager.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public decimal Salary { get; set; }

        public virtual List<SkillModel> Skills { get; set; }
    }
}