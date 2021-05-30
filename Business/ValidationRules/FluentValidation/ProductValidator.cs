using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Recipe>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Name).MinimumLength(2).WithMessage("Name should be minimum of 2 letter");
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.ImageUrl).NotEmpty();            
            
            

        }
    }
}
