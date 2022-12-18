using Business.Abstract;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrderManagementService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        /// <summary>
        /// Get All Company
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Company> Get()
        {
            return _companyService.GetListAll();
        }

        /// <summary>
        /// Create Company
        /// </summary>
        /// <param name="company"></param>
        [HttpPost]
        public void Post([FromBody]Company company)
        {
            _companyService.Insert(company);
        }

        /// <summary>
        /// Update Company
        /// </summary>
        /// <param name="company"></param>
        [HttpPut]
        public void Put([FromBody]Company company)
        {
            _companyService.Update(company);
        }

        /// <summary>
        /// Delete Company
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("(id)")]
        public void Delete(int id)
        {
            _companyService.Delete(id);
        }
    }
}
