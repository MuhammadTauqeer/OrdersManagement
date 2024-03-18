using FluentValidation;

namespace OrdersManagment.Application.DTOs.Customer.Validations
{
    public class CreateCustomerDtoValidator: AbstractValidator<CreateCustomerDto>
    {
        public CreateCustomerDtoValidator()
        {
            Include(new ICustomerDtoValidator());
        }
    }
}
