using EmployeeManager.Databases;
using EmployeeManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
            return _employeeDbContext.Employees;
        }

        public Employee Get(int id)
        {
            return _employeeDbContext.Employees.SingleOrDefault(e => e.Id == id);
        }

        public void Add(Employee employee)
        {
            _employeeDbContext.Employees.Add(employee);
            Commit();
        }

        public void Remove(int id)
        {
            Employee dbEmployee = _employeeDbContext.Employees.SingleOrDefault(e => e.Id == id);

            if (dbEmployee != null)
            {
                _employeeDbContext.Skills.RemoveRange(dbEmployee.Skills);
                _employeeDbContext.Employees.Remove(dbEmployee);
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
                Commit();
            }
        }

        private void Commit()
        {
            _employeeDbContext.SaveChanges();
        }
    }
}