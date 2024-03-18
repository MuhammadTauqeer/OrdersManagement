using FluentValidation;

namespace OrdersManagment.Application.DTOs.Employees.Validators
{
    public class CreateEmployeeDtoValidator: AbstractValidator<CreateEmployeeDto>
    {
        public CreateEmployeeDtoValidator()
        {
            Include(new IEmployeeDtoValidator());
        }
    }
}
