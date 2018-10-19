using EmployeeManager.Entities;
using EmployeeManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManager.Extensions
{
    public static class EmployeeExtensions
    {
        public static EmployeeModel ToModel(this Employee employee)
        {
            List<SkillModel> modelSkills = new List<SkillModel>();

            foreach (var skill in employee.Skills)
            {
                modelSkills.Add(skill.ToModel());
            }

            return new EmployeeModel
            {
                Id = employee.Id,
                FullName = employee.FullName,
                Salary = employee.Salary,
                Skills = modelSkills
            };
        }

        public static Employee ToEntity(this EmployeeModel modelEmployee)
        {
            List<Skill> skills = new List<Skill>();

            foreach (var skill in modelEmployee.Skills)
            {
                skills.Add(skill.ToEntity());
            }

            return new Employee
            {
                Id = modelEmployee.Id,
                FullName = modelEmployee.FullName,
                Salary = modelEmployee.Salary,
                Skills = skills
            };
        }
    }
}