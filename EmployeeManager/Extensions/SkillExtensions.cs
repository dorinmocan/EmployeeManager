using EmployeeManager.Entities;
using EmployeeManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
                Experience = skill.Experience
            };
        }

        public static Skill ToEntity(this SkillModel modelSkill)
        {
            return new Skill
            {
                Id = modelSkill.Id,
                Field = modelSkill.Field.ToEntity(),
                Title = modelSkill.Title.ToEntity(),
                Experience = modelSkill.Experience
            };
        }
    }
}