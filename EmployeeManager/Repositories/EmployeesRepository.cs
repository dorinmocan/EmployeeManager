using EmployeeManager.Databases;
using EmployeeManager.Entities;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManager.Repositories
{
    public class EmployeesRepository
    {
        private EmployeeDbContext _employeeDbContext;

        public EmployeesRepository(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }

        public IEnumerable<Employee> Get()
        {
            IEnumerable<Employee> employees = _employeeDbContext.Employees;

            foreach (var employee in employees)
            {
                GetEmployeeSkills(employee);
            }

            return employees;
        }

        public Employee Get(int id)
        {
            Employee employee = _employeeDbContext.Employees.SingleOrDefault(e => e.Id == id);

            GetEmployeeSkills(employee);

            return employee;
        }

        public void Add(Employee employee)
        {
            if (employee.Skills != null)
            {
                foreach (var skill in employee.Skills)
                {
                    if (skill.Field != null)
                    {
                        _employeeDbContext.Fields.Add(skill.Field);
                    }

                    if (skill.Title != null)
                    {
                        _employeeDbContext.Titles.Add(skill.Title);
                    }
                }

                _employeeDbContext.Skills.AddRange(employee.Skills);
            }

            _employeeDbContext.Employees.Add(employee);
            Commit();
        }

        public void Remove(int id)
        {
            Employee employee = _employeeDbContext.Employees.SingleOrDefault(e => e.Id == id);

            if (employee != null)
            {
                GetEmployeeSkills(employee);
                _employeeDbContext.Skills.RemoveRange(employee.Skills);
                _employeeDbContext.Employees.Remove(employee);
                Commit();
            }
        }

        public void Update(Employee employee)
        {
            Employee dbEmployee = _employeeDbContext.Employees.SingleOrDefault(e => e.Id == employee.Id);

            if (dbEmployee != null)
            {
                dbEmployee.FullName = employee.FullName;
                dbEmployee.Salary = employee.Salary;
                _employeeDbContext.Skills.RemoveRange(dbEmployee.Skills);
                _employeeDbContext.Skills.AddRange(employee.Skills);
                dbEmployee.Skills = employee.Skills;
                Commit();
            }
        }

        private void Commit()
        {
            _employeeDbContext.SaveChanges();
        }

        private void GetEmployeeSkills(Employee employee)
        {
            var skills = _employeeDbContext.Skills.Where(s => s.Employee.Id == employee.Id);

            foreach (var skill in skills)
            {
                employee.Skills.Add(skill);
            }
        }
    }
}