using MediatR;
using OrdersManagment.Application.DTOs.Supplier;

namespace OrdersManagment.Application.Features.Suppliers.Requests.Queries
{
    public class GetListOfSuppliersRequest: IRequest<List<GetSupplierListDto>>
    {
    }
}
