using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taif.Data.Data;
using Taif.Data.Entities.Product;

namespace Taif.Services.ProductService
{
    public interface IproductService
    {
        IEnumerable<Product> List();
    }
}
