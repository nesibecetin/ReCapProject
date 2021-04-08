using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator: AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(c => c.BrandName).NotEmpty().Length(3, 10).WithMessage("Marka Adı 3 ile 10 arasında olmalıdır.");
        }
    }
}
