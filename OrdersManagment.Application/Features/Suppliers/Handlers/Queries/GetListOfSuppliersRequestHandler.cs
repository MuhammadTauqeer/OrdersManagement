using AutoMapper;
using MediatR;
using OrdersManagment.Application.Contracts.Persistence;
using OrdersManagment.Application.DTOs.Supplier;
using OrdersManagment.Application.Features.Suppliers.Requests.Queries;

namespace OrdersManagment.Application.Features.Suppliers.Handlers.Queries
{
    public class GetListOfSuppliersRequestHandler: IRequestHandler<GetListOfSuppliersRequest, List<GetSupplierListDto>>
    {
        private readonly IMapper _mapper;
        private readonly ISupplierRepository _supplierRepository;
        public GetListOfSuppliersRequestHandler(IMapper mapper, ISupplierRepository supplierRepository)
        {
            _mapper = mapper;
            _supplierRepository = supplierRepository;
        }

        public async Task<List<GetSupplierListDto>> Handle(GetListOfSuppliersRequest request, CancellationToken cancellationToken)
        {
            var suppliers = await _supplierRepository.GetAll();
            return _mapper.Map<List<GetSupplierListDto>>(suppliers);
        }
    }
}
