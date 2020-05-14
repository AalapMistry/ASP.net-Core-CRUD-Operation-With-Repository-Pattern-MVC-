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

namespace Repository.Product
{
    public class ProductRepo : IProductRepo
    {
        private readonly IConfiguration _ConnectionString;
        public ProductRepo(IConfiguration Configuration)
        {
            _ConnectionString = Configuration;
        }

        //To View all Products details    
        public async Task<IList<ProductModel>> GetAllProducts()
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.GetSection("ConnectionString").Value))
            {
                string sQuery = "spGetAllProduct";
                DynamicParameters param = new DynamicParameters();
                con.Open();
                var result = await con.QueryAsync<ProductModel>(sQuery, param, commandType: CommandType.StoredProcedure);
                con.Close();
                return result.ToList();
            }
        }
        //To Add new Product record    
        public async Task AddProduct(ProductModel Product)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.GetSection("ConnectionString").Value))
            {
                string sQuery = "spAddProduct";
                DynamicParameters param = new DynamicParameters();
                param.Add("@ProductName", Product.ProductName);
                param.Add("@Description", Product.Description);
                param.Add("@Categories", Product.Categories);
                param.Add("@Stock", Product.Stock);
                param.Add("@Price", Product.Price);
                con.Open();
                await con.ExecuteAsync(sQuery, param, commandType: CommandType.StoredProcedure);
                con.Close();
            }
        }
        //To Update the records of a particluar Product  
        public async Task UpdateProduct(ProductModel Product)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.GetSection("ConnectionString").Value))
            {
                string sQuery = "spUpdateProduct";
                DynamicParameters param = new DynamicParameters();
                param.Add("@ProductName", Product.ProductName);
                param.Add("@Description", Product.Description);
                param.Add("@Categories", Product.Categories);
                param.Add("@Stock", Product.Stock);
                param.Add("@Price", Product.Price);
                con.Open();
                await con.ExecuteAsync(sQuery, param, commandType: CommandType.StoredProcedure);
                con.Close();
            }
        }
        //Get the details of a particular Product  
        public async Task<ProductModel> GetProductData(int? id)
        {
            ProductModel Product = new ProductModel();
            using (SqlConnection con = new SqlConnection(_ConnectionString.GetSection("ConnectionString").Value))
            {
                string sqlQuery = "SELECT * FROM tblProduct WHERE Id= " + id;
                con.Open();
                var result = await con.QueryAsync<ProductModel>(sqlQuery);
                con.Close();
                return result.FirstOrDefault();
            }
        }
        //To Delete the record on a particular Product  
        public async Task DeleteProduct(int? id)
        {
            using (SqlConnection con = new SqlConnection(_ConnectionString.GetSection("ConnectionString").Value))
            {
                string sQuery = "spDeleteProduct";
                DynamicParameters param = new DynamicParameters();
                param.Add("@ProductId", id);
                con.Open();
                await con.ExecuteAsync(sQuery, param, commandType: CommandType.StoredProcedure);
                con.Close();
            }
        }
    }
}
