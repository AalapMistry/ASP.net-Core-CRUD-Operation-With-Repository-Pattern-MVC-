using Models;
using Repository.Product;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Product
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _iProductRepo;

        public ProductService(IProductRepo iProductRepo)
        {
            _iProductRepo = iProductRepo;
        }
        //To View all Products details    
        public async Task<IList<ProductModel>> GetAllProducts()
        {
            IList<ProductModel> list = new List<ProductModel>();
            try
            {
                list = await _iProductRepo.GetAllProducts();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return list;
        }
        //To Add new Product record    
        public async Task AddProduct(ProductModel Product)
        {
            try
            {
                await _iProductRepo.AddProduct(Product);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }
        //To Update the records of a particluar Product  
        public async Task UpdateProduct(ProductModel Product)
        {
            try
            {
                await _iProductRepo.UpdateProduct(Product);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        //Get the details of a particular Product  
        public async Task<ProductModel> GetProductData(int? id)
        {
            ProductModel objProduct = new ProductModel();
            try
            {
                objProduct = await _iProductRepo.GetProductData(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return objProduct;
        }
        //To Delete the record on a particular Product  
        public async Task DeleteProduct(int? id)
        {
            try
            {
                await _iProductRepo.DeleteProduct(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
