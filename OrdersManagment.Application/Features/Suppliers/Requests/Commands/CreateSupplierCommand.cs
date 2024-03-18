using MediatR;
using OrdersManagment.Application.DTOs.Supplier;
using OrdersManagment.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManagment.Application.Features.Suppliers.Requests.Commands
{
    public class CreateSupplierCommand: IRequest<BaseCommandResponse>
    {
        public CreateSupplierDto CreateSupplierDto { get; set; }
    }
}
