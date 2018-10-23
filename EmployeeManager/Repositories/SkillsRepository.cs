using EmployeeManager.Databases;
using EmployeeManager.Entities;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManager.Repositories
{
    public class SkillsRepository
    {
        private EmployeeDbContext _employeeDbContext;

        public SkillsRepository(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }

        public IEnumerable<Skill> Get()
        {
            return _employeeDbContext.Skills;
        }

        public Skill Get(int id)
        {
            return _employeeDbContext.Skills.SingleOrDefault(s => s.Id == id);
        }

        public void Add(Skill skill)
        {
            if (skill.Field != null)
            {
                _employeeDbContext.Fields.Add(skill.Field);
            }

            if (skill.Title != null)
            {
                _employeeDbContext.Titles.Add(skill.Title);
            }

            _employeeDbContext.Skills.Add(skill);
            Commit();
        }

        public void Remove(int id)
        {
            Skill skill = _employeeDbContext.Skills.SingleOrDefault(s => s.Id == id);

            if (skill != null)
            {
                _employeeDbContext.Skills.Remove(skill);
                Commit();
            }
        }

        public void Update(Skill skill)
        {
            Skill dbSkill = _employeeDbContext.Skills.SingleOrDefault(s => s.Id == skill.Id);

            if (dbSkill != null)
            {
                dbSkill.YearsOfExperience = skill.YearsOfExperience;
                dbSkill.FieldId = skill.FieldId;
                dbSkill.Field = skill.Field;
                dbSkill.TitleId = skill.TitleId;
                dbSkill.Title = skill.Title;
                dbSkill.EmployeeId = skill.EmployeeId;
                dbSkill.Employee = skill.Employee;
                Commit();
                //todo
            }
        }

        private void Commit()
        {
            _employeeDbContext.SaveChanges();
        }
    }
}