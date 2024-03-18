using FluentValidation;
using OrdersManagment.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManagment.Application.DTOs.Supplier.Validators
{
    public class ISupplierDtoValidator: AbstractValidator<ISupplierDto>
    {
        public ISupplierDtoValidator()
        {
            
        }
    }
}
