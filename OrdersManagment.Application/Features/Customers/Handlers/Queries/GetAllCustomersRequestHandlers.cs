using AutoMapper;
using MediatR;
using OrdersManagment.Application.Contracts.Persistence;
using OrdersManagment.Application.DTOs.Customer;
using OrdersManagment.Application.Features.Customers.Requests.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManagment.Application.Features.Customers.Handlers.Queries
{
    public class GetAllCustomersRequestHandlers: IRequestHandler<GetAllCustomersRequest, List<GetCustomersListDto>>
    {
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _customerRepository;
        public GetAllCustomersRequestHandlers(IMapper mapper, ICustomerRepository customerRepository)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
        }

        public async Task<List<GetCustomersListDto>> Handle(GetAllCustomersRequest request, CancellationToken cancellationToken)
        {
            var cutomers = await _customerRepository.GetAll();
            return _mapper.Map<List<GetCustomersListDto>>(cutomers);
        }
    }
}
