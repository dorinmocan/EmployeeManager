using EmployeeManager.Models;
using EmployeeManager.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeManager.Controllers
{
    public class EmployeesController : ApiController
    {
        EmployeesService _employeesService;

        public EmployeesController(EmployeesService employeesService)
        {
            _employeesService = employeesService;
        }

        // GET api/values
        public IEnumerable<EmployeeModel> Get()
        {
            return _employeesService.Get();
        }

        // GET api/values/5
        public EmployeeModel Get(int id)
        {
            return _employeesService.Get(id);
        }

        // POST api/values
        public void Post([FromBody]EmployeeModel employeeModel)
        {
            _employeesService.Add(employeeModel);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]EmployeeModel employeeModel)
        {
            _employeesService.Update(employeeModel);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            _employeesService.Remove(id);
        }
    }
}
