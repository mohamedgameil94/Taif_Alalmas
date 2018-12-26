using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taif.Data.Entities.Product
{
    public class Product :BaseEntity
    {
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string PhotoPath { get; set; }
        public int  CategoryId { get; set; }

        
    }
}
