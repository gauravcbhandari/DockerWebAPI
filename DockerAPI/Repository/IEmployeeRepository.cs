using DockerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerAPI.Repository
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllEmployee();

        Task<int> SaveEmployee(Employee employee);
    }
}
