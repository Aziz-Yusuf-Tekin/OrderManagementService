using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICompanyService
    {
        List<Company> GetListAll();
        Company GetById(int id);
        void Insert(Company company);
        void Update(Company company);
        void Delete(int id);
    }
}
