using Models;
using Repository.Employee;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Employee
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepo _iEmployeeRepo;

        public EmployeeService(IEmployeeRepo iemployeeRepo)
        {
            _iEmployeeRepo = iemployeeRepo;
        }
        //To View all Employees details    
        public async Task<IList<EmployeeModel>> GetAllEmployees()
        {
            IList<EmployeeModel> list = new List<EmployeeModel>();
            try
            {
                list = await _iEmployeeRepo.GetAllEmployees();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return list;
        }
        //To Add new Employee record    
        public async Task AddEmployee(EmployeeModel Employee)
        {
            try
            {
                await _iEmployeeRepo.AddEmployee(Employee);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }
        //To Update the records of a particluar Employee  
        public async Task UpdateEmployee(EmployeeModel Employee)
        {
            try
            {
                await _iEmployeeRepo.UpdateEmployee(Employee);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        //Get the details of a particular Employee  
        public async Task<EmployeeModel> GetEmployeeData(int? id)
        {
            EmployeeModel objEmployee = new EmployeeModel();
            try
            {
                objEmployee = await _iEmployeeRepo.GetEmployeeData(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return objEmployee;
        }
        //To Delete the record on a particular Employee  
        public async Task DeleteEmployee(int? id)
        {
            try
            {
                await _iEmployeeRepo.DeleteEmployee(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
