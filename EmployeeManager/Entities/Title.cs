using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManager.Entities
{
    public class Title
    {
        [ForeignKey("Skill")]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}