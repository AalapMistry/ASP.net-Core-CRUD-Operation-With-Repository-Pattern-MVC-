using Dapper;
using Microsoft.Extensions.Configuration;
using Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Registration
{
    public class RegistrationRepo : IRegistrationRepo
    {
        private readonly IConfiguration _ConnectionString;
        public RegistrationRepo(IConfiguration Configuration)
        {
            _ConnectionString = Configuration;
        }

        //To View all Registrations details    
        public async Task<IList<RegistrationModel>> GetAllRegistrations()
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.GetSection("ConnectionString").Value))
            {
                string sQuery = "spGetAllRegistrations";
                DynamicParameters param = new DynamicParameters();
                con.Open();
                var result = await con.QueryAsync<RegistrationModel>(sQuery, param, commandType: CommandType.StoredProcedure);
                con.Close();
                return result.ToList();
            }
        }
        //To Add new Registration record    
        public async Task AddRegistration(RegistrationModel Registration)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.GetSection("ConnectionString").Value))
            {
                string sQuery = "spAddRegistration";
                DynamicParameters param = new DynamicParameters();
                param.Add("@FirstName", Registration.FirstName);
                param.Add("@lastName", Registration.LastName);
                param.Add("@DOB", Registration.DOB);
                param.Add("@Gender", Registration.Gender);
                param.Add("@Email", Registration.Email);
                param.Add("@Mobile", Registration.Mobile);
                param.Add("@Country", Registration.Country);
                param.Add("@State", Registration.State);
                param.Add("@City", Registration.City);
                param.Add("@Address", Registration.Address);
                con.Open();
                await con.ExecuteAsync(sQuery, param, commandType: CommandType.StoredProcedure);
                con.Close();
            }
        }
        //To Update the records of a particluar Registration  
        public async Task UpdateRegistration(RegistrationModel Registration)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.GetSection("ConnectionString").Value))
            {
                string sQuery = "spUpdateRegistration";
                DynamicParameters param = new DynamicParameters();
                param.Add("@Id", Registration.ID);
                param.Add("@FirstName", Registration.FirstName);
                param.Add("@lastName", Registration.LastName);
                param.Add("@DOB", Registration.DOB);
                param.Add("@Gender", Registration.Gender);
                param.Add("@Email", Registration.Email);
                param.Add("@Mobile", Registration.Mobile);
                param.Add("@Country", Registration.Country);
                param.Add("@State", Registration.State);
                param.Add("@City", Registration.City);
                param.Add("@Address", Registration.Address);
                con.Open();
                await con.ExecuteAsync(sQuery, param, commandType: CommandType.StoredProcedure);
                con.Close();
            }
        }
        //Get the details of a particular Registration  
        public async Task<RegistrationModel> GetRegistrationData(int? id)
        {
            RegistrationModel Registration = new RegistrationModel();
            using (SqlConnection con = new SqlConnection(_ConnectionString.GetSection("ConnectionString").Value))
            {
                string sqlQuery = "SELECT * FROM tblRegistration WHERE Id= " + id;
                con.Open();
                var result = await con.QueryAsync<RegistrationModel>(sqlQuery);
                con.Close();
                return result.FirstOrDefault();
            }
        }
        //To Delete the record on a particular Registration  
        public async Task DeleteRegistration(int? id)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.GetSection("ConnectionString").Value))
            {
                string sQuery = "spDeleteRegistration";
                DynamicParameters param = new DynamicParameters();
                param.Add("@regId", id);
                con.Open();
                await con.ExecuteAsync(sQuery, param, commandType: CommandType.StoredProcedure);
                con.Close();
            }
        }
    }
}
