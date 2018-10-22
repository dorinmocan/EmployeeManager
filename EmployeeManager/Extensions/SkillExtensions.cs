using EmployeeManager.Entities;
using EmployeeManager.Models;

namespace EmployeeManager.Extensions
{
    public static class SkillExtensions
    {
        public static SkillModel ToModel(this Skill skill)
        {
            return new SkillModel
            {
                Id = skill.Id,
                Field = skill.Field.ToModel(),
                Title = skill.Title.ToModel(),
                YearsOfExperience = skill.YearsOfExperience,
                Employee = skill.Employee.ToModel()
            };
        }

        public static Skill ToEntity(this SkillModel modelSkill)
        {
            return new Skill
            {
                Id = modelSkill.Id,
                FieldId = modelSkill.Field.Id,
                Field = modelSkill.Field.ToEntity(),
                TitleId = modelSkill.Title.Id,
                Title = modelSkill.Title.ToEntity(),
                YearsOfExperience = modelSkill.YearsOfExperience,
                EmployeeId = modelSkill.Employee.Id,
                Employee = modelSkill.Employee.ToEntity()
            };
        }
    }
}