using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManager.Entities
{
    public class Skill
    {
        public int Id { get; set; }

        public int FieldId { get; set; }
        public virtual Field Field { get; set; }

        public int TitleId { get; set; }
        public virtual Title Title { get; set; }

        public DateTime Experience { get; set; }
    }
}