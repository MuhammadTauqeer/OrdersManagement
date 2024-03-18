using AutoMapper;
using MediatR;
using OrdersManagment.Application.Contracts.Persistence;
using OrdersManagment.Application.DTOs.Supplier;
using OrdersManagment.Application.DTOs.Supplier.Validators;
using OrdersManagment.Application.Features.Suppliers.Requests.Commands;
using OrdersManagment.Application.Responses;
using OrdersManagment.Domain;

namespace OrdersManagment.Application.Features.Suppliers.Handlers.Commands
{
    public class CreateSupplierCommandHandler : IRequestHandler<CreateSupplierCommand, BaseCommandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public CreateSupplierCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<BaseCommandResponse> Handle(CreateSupplierCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateSupplierDtoValidator();
            var validationResult = await validator.ValidateAsync(request.CreateSupplierDto);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation Failed";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            }
            else
            {
                var supplier = _mapper.Map<Supplier>(request.CreateSupplierDto);
                supplier = await _unitOfWork.SupplierRepository.Add(supplier);

                response.Success = true;
                response.Message = "Created Successfully";
                response.Id = supplier.Id;
            }
            return response;
        }
    }
}
