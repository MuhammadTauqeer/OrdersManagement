using AutoMapper;
using MediatR;
using OrdersManagment.Application.Contracts.Persistence;
using OrdersManagment.Application.DTOs.Employees.Validators;
using OrdersManagment.Application.Features.Employees.Requests.Commands;
using OrdersManagment.Application.Responses;
using OrdersManagment.Domain;


namespace OrdersManagment.Application.Features.Employees.Handlers.Commands
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, BaseCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public CreateEmployeeCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<BaseCommandResponse> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateEmployeeDtoValidator();
            var validationResult = await validator.ValidateAsync(request.EmployeeDto);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation Failed";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            }
            else
            {
                var employee = _mapper.Map<Employee>(request.EmployeeDto);
                employee = await _unitOfWork.EmployeeRepository.Add(employee);
                await _unitOfWork.Save();

                response.Success = true;
                response.Message = "Created Successfully";
                response.Id = employee.Id;
            }
            return response;
        }
    }
}
