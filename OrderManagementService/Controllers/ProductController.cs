using Business.Abstract;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrderManagementService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        /// <summary>
        /// Get All Product
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Product> Get()
        {
            return _productService.GetListAll();
        }


        /// <summary>
        /// Create an Product
        /// </summary>
        /// <param name="home"></param>
        [HttpPost]
        public void Post([FromBody] Product product
            )
        {
            _productService.Insert(product);
        }

        /// <summary>
        /// Update an Product
        /// </summary>
        /// <param name="home"></param>
        [HttpPut]
        public void Put([FromBody] Product product)
        {
            _productService.Update(product);
        }

        /// <summary>
        /// Delete an Product
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("(id)")]
        public void Delete(int id)
        {
            _productService.Delete(id);
        }
    }
}
