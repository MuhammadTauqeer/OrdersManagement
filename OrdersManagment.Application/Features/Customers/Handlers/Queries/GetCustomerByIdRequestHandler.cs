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
    public class GetCustomerByIdRequestHandler: IRequestHandler<GetCustomerByIdRequest, GetCustomerByIdDto>
    {
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _customerRepository;
        public GetCustomerByIdRequestHandler(IMapper mapper, ICustomerRepository customerRepository)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
        }

        public async Task<GetCustomerByIdDto> Handle(GetCustomerByIdRequest request, CancellationToken cancellationToken)
        {
           var customer = await _customerRepository.Get(request.Id);
            return _mapper.Map<GetCustomerByIdDto>(customer);
        }
    }
}
