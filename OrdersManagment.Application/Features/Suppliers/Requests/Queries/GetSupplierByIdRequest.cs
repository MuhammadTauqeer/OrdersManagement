using MediatR;
using OrdersManagment.Application.DTOs.Customer;
using OrdersManagment.Application.DTOs.Supplier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManagment.Application.Features.Suppliers.Requests.Queries
{
    public class GetSupplierByIdRequest: IRequest<GetSupplierByIdDto>
    {
        public int Id { get; set; }
    }
}
