using MediatR;
using OrdersManagment.Application.DTOs.Customer;
using OrdersManagment.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManagment.Application.Features.Customers.Requests.Commands
{
    public class CreateCustomerCommand: IRequest<BaseCommandResponse>
    {
        public CreateCustomerDto CreateCustomerDto { get; set; }
    }
}
