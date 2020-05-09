using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Employee
{
    public interface IEmployeeService
    {
        Task<IList<EmployeeModel>> GetAllEmployees();

        Task AddEmployee(EmployeeModel Employee);

        Task UpdateEmployee(EmployeeModel Employee);

        Task<EmployeeModel> GetEmployeeData(int? id);

        Task DeleteEmployee(int? id);
    }
}
