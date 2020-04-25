using Microsoft.Extensions.Configuration;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Repository.Category
{
    public class CategoryRepo : ICategoryRepo
    {
        public static IConfiguration _ConnectionString;
        public CategoryRepo(IConfiguration Configuration)
        {
            _ConnectionString = Configuration;
        }

        //To View all Categorys details    
        public IList<CategoryModel> GetAllCategorys()
        {
            List<CategoryModel> lstCategory = new List<CategoryModel>();
            using (SqlConnection con = new SqlConnection(_ConnectionString.GetSection("ConnectionString").Value))
            {
                SqlCommand cmd = new SqlCommand("spGetAllCategorys", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    CategoryModel Category = new CategoryModel();
                    Category.CategoryID = Convert.ToInt32(rdr["CategoryID"]);
                    Category.CategoryName = rdr["CategoryName"].ToString();
                    lstCategory.Add(Category);
                }
                con.Close();
            }
            return lstCategory;
        }
        //To Add new Category record    
        public void AddCategory(CategoryModel Category)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.GetSection("ConnectionString").Value))
            {
                SqlCommand cmd = new SqlCommand("spAddCategory", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoryName", Category.CategoryName);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        //To Update the records of a particluar Category  
        public void UpdateCategory(CategoryModel Category)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.GetSection("ConnectionString").Value))
            {
                SqlCommand cmd = new SqlCommand("spUpdateCategory", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoryId", Category.CategoryID);
                cmd.Parameters.AddWithValue("@CategoryName", Category.CategoryName);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        //Get the details of a particular Category  
        public CategoryModel GetCategoryData(int? id)
        {
            CategoryModel Category = new CategoryModel();
            using (SqlConnection con = new SqlConnection(_ConnectionString.GetSection("ConnectionString").Value))
            {
                string sqlQuery = "SELECT * FROM tblCategory WHERE Id= " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Category.CategoryID = Convert.ToInt16(rdr["CategoryId"]);
                    Category.CategoryName = rdr["CategoryName"].ToString();
                }
            }
            return Category;
        }
        //To Delete the record on a particular Category  
        public void DeleteCategory(int? id)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.GetSection("ConnectionString").Value))
            {
                SqlCommand cmd = new SqlCommand("spDeleteCategory", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoryId", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
