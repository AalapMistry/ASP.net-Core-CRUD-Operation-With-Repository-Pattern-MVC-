using Dapper;
using Microsoft.Extensions.Configuration;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Employee
{
    public class EmployeeRepo
    {

        private readonly IConfiguration _ConnectionString;
        public EmployeeRepo(IConfiguration Configuration)
        {
            _ConnectionString = Configuration;
        }

        //To View all Employees details    
        public async Task<IList<EmployeeModel>> GetAllEmployees()
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.GetSection("ConnectionString").Value))
            {
                string sQuery = "spGetAllEmployees";
                DynamicParameters param = new DynamicParameters();
                con.Open();
                var result = await con.QueryAsync<EmployeeModel>(sQuery, param, commandType: CommandType.StoredProcedure);
                con.Close();
                return result.ToList();
            }
        }
        //To Add new Employee record    
        public async Task AddEmployee(EmployeeModel Employee)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.GetSection("ConnectionString").Value))
            {
                string sQuery = "spAddEmployee";
                DynamicParameters param = new DynamicParameters();
                param.Add("@Fname", Employee.Fname);
                param.Add("@Lname", Employee.Lname);
                param.Add("@email", Employee.email);
                param.Add("@gender", Employee.gender);
                con.Open();
                await con.ExecuteAsync(sQuery, param, commandType: CommandType.StoredProcedure);
                con.Close();
            }
        }
        //To Update the records of a particluar Employee  
        public async Task UpdateEmployee(EmployeeModel Employee)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.GetSection("ConnectionString").Value))
            {
                string sQuery = "spUpdateEmployee";
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", Employee.ID);
                param.Add("@Fname", Employee.Fname);
                param.Add("@Lname", Employee.Lname);
                param.Add("@email", Employee.email);
                param.Add("@gender", Employee.gender);
                con.Open();
                await con.ExecuteAsync(sQuery, param, commandType: CommandType.StoredProcedure);
                con.Close();
            }
        }
        //Get the details of a particular Employee  
        public async Task<EmployeeModel> GetEmployeeData(int? id)
        {
            EmployeeModel Employee = new EmployeeModel();
            using (SqlConnection con = new SqlConnection(_ConnectionString.GetSection("ConnectionString").Value))
            {
                string sqlQuery = "SELECT * FROM tblEmployee WHERE Id= " + id;
                con.Open();
                var result = await con.QueryAsync<EmployeeModel>(sqlQuery);
                con.Close();
                return result.FirstOrDefault();
            }
        }
        //To Delete the record on a particular Employee  
        public async Task DeleteEmployee(int? id)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.GetSection("ConnectionString").Value))
            {
                string sQuery = "spDeleteEmployee";
                DynamicParameters param = new DynamicParameters();
                param.Add("@regId", id);
                con.Open();
                await con.ExecuteAsync(sQuery, param, commandType: CommandType.StoredProcedure);
                con.Close();
            }
        }
    }
}
