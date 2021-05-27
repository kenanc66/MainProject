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
            RuleFor(p => p.ProductName).MinimumLength(2).WithMessage("Name should be minimum of 2 letter");
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(10);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10)
                .When(p => p.CategoryId == 1).WithMessage("Products should have price of at least 10");
            

        }
    }
}
