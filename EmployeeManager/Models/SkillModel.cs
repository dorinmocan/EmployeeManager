namespace EmployeeManager.Models
{
    public class SkillModel
    {
        public int Id { get; set; }

        public FieldModel Field { get; set; }

        public TitleModel Title { get; set; }

        public byte YearsOfExperience { get; set; }

        public EmployeeModel Employee { get; set; }
    }
}