using AutoMapper;
using MediatR;
using OrdersManagment.Application.Contracts.Persistence;
using OrdersManagment.Application.DTOs.Customer.Validations;
using OrdersManagment.Application.Features.Customers.Requests.Commands;
using OrdersManagment.Application.Responses;
using OrdersManagment.Domain;
using System.Reflection.Metadata.Ecma335;

namespace OrdersManagment.Application.Features.Customers.Handlers.Commands
{
    public class CreateCustomerCommandHandler: IRequestHandler<CreateCustomerCommand, BaseCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public CreateCustomerCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BaseCommandResponse> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateCustomerDtoValidator();
            var validationResult = await validator.ValidateAsync(request.CreateCustomerDto);

            if (validationResult != null)
            {
                response.Success = false;
                response.Message = "Creation Failed";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            }
            else
            {

                var customer = _mapper.Map<Customer>(request.CreateCustomerDto);
                customer = await _unitOfWork.CustomerRepository.Add(customer);
                await _unitOfWork.Save();

                response.Success = true;
                response.Message = "Created Successfully";
                response.Id = customer.Id;
            }
            return response;
        }
        
    }
}
