using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taif.Data.Entities.Product;

namespace Taif.Services.ProductService
{
   public class ProductValidator : AbstractValidator<Product> 
    {
        public ProductValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("CantBe Null");
        }

    }
}
