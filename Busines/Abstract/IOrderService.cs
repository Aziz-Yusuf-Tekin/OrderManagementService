using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderService
    {
        List<Order> GetListAll();
        Order GetById(int id);
        void Insert(Order order);
        void Update(Order order);
        void Delete(int id);
    }
}
