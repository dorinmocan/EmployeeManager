using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManager.Entities
{
    public class Field
    {
        [ForeignKey("Skill")]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}