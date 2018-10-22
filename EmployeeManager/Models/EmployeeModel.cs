using System.Collections.Generic;

namespace EmployeeManager.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public decimal Salary { get; set; }

        public List<SkillModel> Skills { get; set; }

        public EmployeeModel()
        {
            Skills = new List<SkillModel>();
        }
    }
}