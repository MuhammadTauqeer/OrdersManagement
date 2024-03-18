using MediatR;
using OrdersManagment.Application.DTOs.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManagment.Application.Features.Employees.Requests.Queries
{
    public class GetEmployeeByIdRequest: IRequest<GetEmployeeByIdDto>
    {
        public int Id { get; set; }
    }
}
