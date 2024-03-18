 using FluentValidation;


namespace OrdersManagment.Application.DTOs.Employees.Validators
{
    public class IEmployeeDtoValidator: AbstractValidator<IEmployeeDto>
    {
        public IEmployeeDtoValidator()
        {
            RuleFor(p => p.FirstName)
               .NotEmpty().WithMessage("{PropertyFirstName} is required.")
               .NotNull()
               .MaximumLength(50).WithMessage("{PropertyName} must not exceed {ComparisonValue} characters.");

            RuleFor(p => p.LastName)
               .NotEmpty().WithMessage("{PropertyLastName} is required.")
               .NotNull()
               .MaximumLength(50).WithMessage("{PropertyName} must not exceed {ComparisonValue} characters.");
        }
    }
}
