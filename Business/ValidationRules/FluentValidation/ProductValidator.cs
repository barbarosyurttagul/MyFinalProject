using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(product => product.ProductName).NotEmpty();
            RuleFor(product => product.ProductName).MinimumLength(2);
            RuleFor(product => product.UnitPrice).NotEmpty();
            RuleFor(product => product.UnitPrice).GreaterThanOrEqualTo(0).When(product => product.CategoryId == 1);
            RuleFor(product => product.ProductName).Must(StartWithA);
        }

        private bool StartWithA(string arg)
        {
            return (arg.StartsWith("A")); 
                 
        }
    }
}
