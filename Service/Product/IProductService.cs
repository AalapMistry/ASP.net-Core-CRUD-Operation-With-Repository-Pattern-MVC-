using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Product
{
    public interface IProductService
    {
        Task<IList<ProductModel>> GetAllProducts();

        Task AddProduct(ProductModel Product);

        Task UpdateProduct(ProductModel Product);

        Task<ProductModel> GetProductData(int? id);

        Task DeleteProduct(int? id);
    }
}
