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
    public class CustomerManager : ICustomerService
    {
        private ICustomerRepository _costumerRepository;
        public CustomerManager(ICustomerRepository costumerRepository)
        {
            _costumerRepository = costumerRepository;
        }

        public void Delete(int id)
        {
            var entity = _costumerRepository.GetById(id);
            _costumerRepository.Delete(entity);
        }

        public Customer GetById(int id)
        {
            return _costumerRepository.GetById(id);
        }

        public List<Customer> GetListAll()
        {
            return _costumerRepository.GetListAll();
        }

        public void Insert(Customer customer)
        {
            _costumerRepository.Insert(customer);
        }

        public void Update(Customer customer)
        {
            _costumerRepository.Update(customer);
        }
    }
}

