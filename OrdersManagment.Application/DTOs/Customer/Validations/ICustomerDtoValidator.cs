using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManagment.Application.DTOs.Customer.Validations
{
    public class ICustomerDtoValidator : AbstractValidator<ICustomerDto>
    {
        public ICustomerDtoValidator()
        {
            RuleFor(p => p.CustomerName)
               .NotEmpty().WithMessage("{PropertyFirstName} is required.")
               .NotNull()
               .MaximumLength(50).WithMessage("{PropertyName} must not exceed {ComparisonValue} characters.");

            RuleFor(p => p.CustomerName)
               .NotEmpty().WithMessage("{PropertyLastName} is required.")
               .NotNull()
               .MaximumLength(50).WithMessage("{PropertyName} must not exceed {ComparisonValue} characters.");
        }
    }
}
