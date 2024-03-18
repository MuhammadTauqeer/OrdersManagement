using FluentValidation;


namespace OrdersManagment.Application.DTOs.Supplier.Validators
{
    public class CreateSupplierDtoValidator: AbstractValidator<CreateSupplierDto>
    {
        public CreateSupplierDtoValidator()
        {
            Include(new ISupplierDtoValidator());
        }
    }
}
