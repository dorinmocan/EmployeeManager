using EmployeeManager.Entities;
using EmployeeManager.Extensions;
using EmployeeManager.Models;
using EmployeeManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManager.Services
{
    public class EmployeesService
    {
        private EmployeesRepository _employeesRepository;

        public EmployeesService(EmployeesRepository employeesRepository)
        {
            _employeesRepository = employeesRepository;
        }

        public IEnumerable<EmployeeModel> Get()
        {
            IEnumerable<Employee> employees = _employeesRepository.Get();

            List<EmployeeModel> modelEmployees = new List<EmployeeModel>();

            foreach (var employee in employees)
            {
                modelEmployees.Add(employee.ToModel());
            }

            return modelEmployees;
        }

        public EmployeeModel Get(int id)
        {
            return _employeesRepository.Get(id).ToModel();
        }

        public void Add(EmployeeModel employee)
        {
            _employeesRepository.Add(employee.ToEntity());
        }

        public void Remove(int id)
        {
            _employeesRepository.Remove(id);
        }

        public void Update(EmployeeModel modelEmployee)
        {
            _employeesRepository.Update(modelEmployee.ToEntity());
        }
    }
}