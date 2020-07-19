using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DockerAPI.Models;
using DockerAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DockerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeRepository _employeesData;
        public EmployeeController(IEmployeeRepository employeesData)
        {
            _employeesData = employeesData;
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            var res = await _employeesData.SaveEmployee(employee);
            return Ok(res);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployee()
        {
            var res = await _employeesData.GetAllEmployee();
            return Ok(res);
        }
    }
}
