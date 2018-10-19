using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManager.Models
{
    public class SkillModel
    {
        public int Id { get; set; }

        public virtual FieldModel Field { get; set; }

        public virtual TitleModel Title { get; set; }

        public DateTime Experience { get; set; }
    }
}