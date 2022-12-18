using Business.Abstract;
using DataAccess.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private IOrderRepository _orderRepository;
        public OrderManager(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void Delete(int id)
        {
           var entity= _orderRepository.GetById(id);
            _orderRepository.Delete(entity);
        }

        public Order GetById(int id)
        {
            return _orderRepository.GetById(id);
        }

        public List<Order> GetListAll()
        {
            return _orderRepository.GetListAll();
        }

        public void Insert(Order order)
        {
            _orderRepository.Insert(order);
        }

        public void Update(Order order)
        {
            _orderRepository.Update(order);
        }
    }
}
