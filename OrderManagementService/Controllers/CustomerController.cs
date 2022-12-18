using Business.Abstract;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrderManagementService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        /// <summary>
        /// Get All Customers
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Customer> Get()
        {
            return _customerService.GetListAll();
        }


        /// <summary>
        /// Create an Customer
        /// </summary>
        /// <param name="home"></param>
        [HttpPost]
        public void Post([FromBody] Customer home)
        {
            _customerService.Insert(home);
        }

        /// <summary>
        /// Update an Customer
        /// </summary>
        /// <param name="home"></param>
        [HttpPut]
        public void Put([FromBody] Customer home)
        {
            _customerService.Update(home);
        }

        /// <summary>
        /// Delete an Customer
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("(id)")]
        public void Delete(int id)
        {
            _customerService.Delete(id);
        }
    }
}
