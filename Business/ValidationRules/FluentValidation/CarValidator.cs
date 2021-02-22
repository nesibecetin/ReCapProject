using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator: AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c=>c.CarName).NotEmpty().Length(1,50);
            RuleFor(c => c.DailyPrice).LessThanOrEqualTo(100);
            RuleFor(c => c.Description).NotEmpty().Length(1, 500);
        }
    }
}
