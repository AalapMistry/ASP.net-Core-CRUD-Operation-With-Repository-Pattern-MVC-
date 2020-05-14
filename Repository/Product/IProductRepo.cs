using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Product
{
    public interface IProductRepo
    {
        Task<IList<ProductModel>> GetAllProducts();

        Task AddProduct(ProductModel Registration);

        Task UpdateProduct(ProductModel Registration);

        Task<ProductModel> GetProductData(int? id);

        Task DeleteProduct(int? id);
    }
}
