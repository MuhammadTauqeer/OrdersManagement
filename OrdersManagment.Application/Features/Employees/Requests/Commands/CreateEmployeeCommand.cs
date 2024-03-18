using MediatR;
using OrdersManagment.Application.DTOs.Employees;
using OrdersManagment.Application.Responses;
using System.Security.Cryptography.X509Certificates;


namespace OrdersManagment.Application.Features.Employees.Requests.Commands
{
    public class CreateEmployeeCommand: IRequest<BaseCommandResponse>
    {
        public CreateEmployeeDto EmployeeDto { get; set; }
    }
}
