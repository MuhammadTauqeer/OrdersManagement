using AutoMapper;
using MediatR;
using OrdersManagment.Application.Contracts.Persistence;
using OrdersManagment.Application.DTOs.Employees;
using OrdersManagment.Application.Features.Employees.Requests.Queries;


namespace OrdersManagment.Application.Features.Employees.Handlers.Queries
{
    public class GetAllEmployeesRequestHandler : IRequestHandler<GetAllEmployeesRequest, List<GetEmployeesListDto>>
    {
        IMapper _mapper;
        IEmployeeRepository _employeeRepository;


        public GetAllEmployeesRequestHandler(IMapper mapper, IEmployeeRepository employeeRepository)
        {
            _mapper = mapper;
            _employeeRepository = employeeRepository;
        }

        public async Task<List<GetEmployeesListDto>> Handle(GetAllEmployeesRequest request, CancellationToken cancellationToken)
        {
            var employees = await _employeeRepository.GetAll();
            return _mapper.Map<List<GetEmployeesListDto>>(employees);
        }
    }
}
