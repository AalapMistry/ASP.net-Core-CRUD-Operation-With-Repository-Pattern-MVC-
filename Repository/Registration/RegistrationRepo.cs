using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Repository.Registration
{
    public class RegistrationRepo : IRegistrationRepo
    {
        string connectionString = "Put Your Connection string here";
        //To View all Registrations details    
        public IList<RegistrationModel> GetAllRegistrations()
        {
            List<RegistrationModel> lstRegistration = new List<RegistrationModel>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spGetAllRegistrations", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    RegistrationModel Registration = new RegistrationModel();
                    Registration.ID = Convert.ToInt32(rdr["RegistrationID"]);
                    Registration.FirstName = rdr["FirstName"].ToString();
                    Registration.LastName = rdr["lastName"].ToString();
                    Registration.Gender = rdr["Gender"].ToString();
                    Registration.DOB = Convert.ToDateTime(rdr["DOB"]);
                    Registration.Email = rdr["Email"].ToString();
                    Registration.Mobile = rdr["Mobile"].ToString();
                    Registration.Country = rdr["Country"].ToString();
                    Registration.State = rdr["State"].ToString();
                    Registration.City = rdr["City"].ToString();
                    Registration.Address = rdr["Address"].ToString();
                    lstRegistration.Add(Registration);
                }
                con.Close();
            }
            return lstRegistration;
        }
        //To Add new Registration record    
        public void AddRegistration(RegistrationModel Registration)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddRegistration", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", Registration.FirstName);
                cmd.Parameters.AddWithValue("@lastName", Registration.LastName);
                cmd.Parameters.AddWithValue("@DOB", Registration.DOB);
                cmd.Parameters.AddWithValue("@Gender", Registration.Gender);
                cmd.Parameters.AddWithValue("@Email", Registration.Email);
                cmd.Parameters.AddWithValue("@Country", Registration.Country);
                cmd.Parameters.AddWithValue("@State", Registration.State);
                cmd.Parameters.AddWithValue("@City", Registration.City);
                cmd.Parameters.AddWithValue("@Address", Registration.Address);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        //To Update the records of a particluar Registration  
        public void UpdateRegistration(RegistrationModel Registration)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdateRegistration", con);
                cmd.Parameters.AddWithValue("@regId", Registration.ID);
                cmd.Parameters.AddWithValue("@FirstName", Registration.FirstName);
                cmd.Parameters.AddWithValue("@lastName", Registration.LastName);
                cmd.Parameters.AddWithValue("@DOB", Registration.DOB);
                cmd.Parameters.AddWithValue("@Gender", Registration.Gender);
                cmd.Parameters.AddWithValue("@Email", Registration.Email);
                cmd.Parameters.AddWithValue("@Country", Registration.Country);
                cmd.Parameters.AddWithValue("@State", Registration.State);
                cmd.Parameters.AddWithValue("@City", Registration.City);
                cmd.Parameters.AddWithValue("@Address", Registration.Address);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        //Get the details of a particular Registration  
        public RegistrationModel GetRegistrationData(int? id)
        {
            RegistrationModel Registration = new RegistrationModel();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM tblRegistration WHERE RegistrationID= " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Registration.FirstName = rdr["FirstName"].ToString();
                    Registration.LastName = rdr["lastName"].ToString();
                    Registration.Gender = rdr["Gender"].ToString();
                    Registration.DOB = Convert.ToDateTime(rdr["DOB"]);
                    Registration.Email = rdr["Email"].ToString();
                    Registration.Mobile = rdr["Mobile"].ToString();
                    Registration.Country = rdr["Country"].ToString();
                    Registration.State = rdr["State"].ToString();
                    Registration.City = rdr["City"].ToString();
                    Registration.Address = rdr["Address"].ToString();
                }
            }
            return Registration;
        }
        //To Delete the record on a particular Registration  
        public void DeleteRegistration(int? id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spDeleteRegistration", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@regId", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
