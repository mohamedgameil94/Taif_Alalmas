using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Taif.Web.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string PhotoPath { get; set; }
        public int CategoryId { get; set; }
    }
}