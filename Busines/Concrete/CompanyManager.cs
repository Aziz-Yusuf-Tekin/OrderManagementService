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
    public class CompanyManager : ICompanyService
    {
        private ICompanyRepository _companyRepository;
        public CompanyManager(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public void Delete(int id)
        {
            var entity = _companyRepository.GetById(id);
            _companyRepository.Delete(entity);
        }

        public Company GetById(int id)
        {
            return _companyRepository.GetById(id);
        }

        public List<Company> GetListAll()
        {
            return _companyRepository.GetListAll();
        }

        public void Insert(Company company)
        {
            _companyRepository.Insert(company);
        }

        public void Update(Company company)
        {
            _companyRepository.Update(company);
        }
    }
}
