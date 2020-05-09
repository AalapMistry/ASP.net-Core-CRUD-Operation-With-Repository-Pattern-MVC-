using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Employee
{
    public interface IEmployeeRepo
    {
        Task<IList<EmployeeModel>> GetAllEmployees();

        Task AddEmployee(EmployeeModel Registration);

        Task UpdateEmployee(EmployeeModel Registration);

        Task<EmployeeModel> GetEmployeeData(int? id);

        Task DeleteEmployee(int? id);

    }
}
