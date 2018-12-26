using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taif.Data.Data;
using Taif.Data.Entities.Product;

namespace Taif.Services.ProductService
{
    public class ProductService : IproductService
    {
        private IRepository<Product> _productRepository;
        public ProductService(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;

        }

        public IEnumerable<Product> List()
        {
            var list = _productRepository.GetAll();
            return list.ToList();
        }
    }
}
