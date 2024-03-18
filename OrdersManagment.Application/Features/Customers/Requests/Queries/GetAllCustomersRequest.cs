using MediatR;
using OrdersManagment.Application.DTOs.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManagment.Application.Features.Customers.Requests.Queries
{
    public class GetAllCustomersRequest: IRequest<List<GetCustomersListDto>>
    {
    }
}
