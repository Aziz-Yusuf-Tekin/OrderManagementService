using Business.Abstract;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrderManagementService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        /// <summary>
        /// Get All Order
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Order> Get()
        {
            return _orderService.GetListAll();
        }


        /// <summary>
        /// Create an Order
        /// </summary>
        /// <param name="home"></param>
        [HttpPost]
        public void Post([FromBody] Order order)
        {
            _orderService.Insert(order);
        }

        /// <summary>
        /// Update an Order
        /// </summary>
        /// <param name="home"></param>
        [HttpPut]
        public void Put([FromBody] Order order)
        {
            _orderService.Update(order);
        }

        /// <summary>
        /// Delete an Order
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("(id)")]
        public void Delete(int id)
        {
            _orderService.Delete(id);
        }
    }
}
