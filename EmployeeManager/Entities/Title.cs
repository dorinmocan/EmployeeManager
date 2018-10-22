using System.Collections.Generic;

namespace EmployeeManager.Entities
{
    public class Title
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Skill> Skills { get; set; }
    }
}