using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Models;
using Service.Product;

namespace AalapCRUDWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [DisableCors]
    public class ProductController : Controller
    {
        private readonly IProductService _iProductService;

        public ProductController(IProductService iProductService)
        {
            _iProductService = iProductService;
        }


        // GET: api/Products
        [HttpGet]
        public async Task<IList<ProductModel>> GettblProduct()
        {
            IList<ProductModel> EmpList = new List<ProductModel>();
            EmpList = await _iProductService.GetAllProducts();
            return EmpList;
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Product = await _iProductService.GetProductData(id);

            if (Product == null)
            {
                return NotFound();
            }

            return Ok(Product);
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct([FromRoute] int id, [FromBody] ProductModel Product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != Product.ProductId)
            {
                return BadRequest();
            }
            await _iProductService.UpdateProduct(Product);

            return NoContent();
        }

        // POST: api/Products
        [HttpPost]
        public async Task<IActionResult> PostProduct([FromBody] ProductModel Product)
        {


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _iProductService.AddProduct(Product);

            return CreatedAtAction("GetProduct", new { id = Product.ProductId }, Product);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _iProductService.DeleteProduct(id);

            return Ok();
        }
    }
}