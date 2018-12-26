using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taif.Data.Entities.Product;

namespace Taif.Data.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {

            ToTable("Products");
            HasKey(p => p.Id);
          
        }

    }
}
