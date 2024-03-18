using AutoMapper;
using MediatR;
using OrdersManagment.Application.Contracts.Persistence;
using OrdersManagment.Application.DTOs.Employees;
using OrdersManagment.Application.Features.Employees.Requests.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManagment.Application.Features.Employees.Handlers.Queries
{
    public class GetEmployeeByIdRequestHandler: IRequestHandler<GetEmployeeByIdRequest, GetEmployeeByIdDto>
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepository;
        public GetEmployeeByIdRequestHandler(IMapper mapper, IEmployeeRepository employeeRepository)
        {
            _mapper = mapper;
            _employeeRepository = employeeRepository;
        }

        public async Task<GetEmployeeByIdDto> Handle(GetEmployeeByIdRequest request, CancellationToken cancellationToken)
        {
            var response = await _employeeRepository.Get(request.Id);
            return _mapper.Map<GetEmployeeByIdDto>(response);
        }
    }
}
