using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrdersManagment.Application.DTOs.Customer;
using OrdersManagment.Application.Features.Customers.Requests.Commands;
using OrdersManagment.Application.Features.Customers.Requests.Queries;
using OrdersManagment.Application.Features.Employees.Requests.Queries;
using OrdersManagment.Application.Responses;

namespace OrdersManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET api/<CustomerController>
        [HttpGet]
        public async Task<ActionResult<List<GetCustomersListDto>>> Get()
        {
            var customers = await _mediator.Send(new GetAllCustomersRequest());

            return Ok(customers);
        }

        // GET api/<CustomerController>/8
        [HttpGet("{id}")]
        public async Task<ActionResult<GetCustomerByIdDto>> Get(int Id)
        {
            var customer = await _mediator.Send(new GetCustomerByIdRequest { Id = Id });
            return Ok(customer);
        }

        // POST api/<CustomerController>
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] CreateCustomerDto createCustomerDto)
        {
            var command = new CreateCustomerCommand { CreateCustomerDto = createCustomerDto };
            var respone = await _mediator.Send(command);
            return Ok(respone);
        }
    }
}
