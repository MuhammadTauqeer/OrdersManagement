using AutoMapper;
using MediatR;
using OrdersManagment.Application.Contracts.Persistence;
using OrdersManagment.Application.DTOs.Supplier;
using OrdersManagment.Application.Features.Suppliers.Requests.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManagment.Application.Features.Suppliers.Handlers.Queries
{
    public class GetSupplierByIdRequestHandler: IRequestHandler<GetSupplierByIdRequest, GetSupplierByIdDto>
    {
        private readonly IMapper _mapper;
        private readonly ISupplierRepository _supplierRepository;
        public GetSupplierByIdRequestHandler(IMapper mapper, ISupplierRepository supplierRepository)
        {
            _mapper = mapper;
            _supplierRepository = supplierRepository;
        }

        public async Task<GetSupplierByIdDto> Handle(GetSupplierByIdRequest request, CancellationToken cancellationToken)
        {
            var supplier = await _supplierRepository.Get(request.Id);
            return _mapper.Map<GetSupplierByIdDto>(supplier);
        }
    }
}
