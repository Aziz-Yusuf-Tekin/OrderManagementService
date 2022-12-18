using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Product : BaseModel
    {
        public int ProductStock { get; set; }
        public int ProductPrice { get; set; }
        public Company Company { get; set; }
    }
}
