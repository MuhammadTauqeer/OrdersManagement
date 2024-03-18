using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrdersManagment.Application.DTOs.Supplier;
using OrdersManagment.Application.Features.Suppliers.Requests.Commands;
using OrdersManagment.Application.Features.Suppliers.Requests.Queries;
using OrdersManagment.Application.Responses;

namespace OrdersManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SupplierController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET/<SupplierController>
        [HttpGet]
        public async Task<ActionResult<List<GetSupplierListDto>>> Get()
        {
            var suppliers = await _mediator.Send(new GetListOfSuppliersRequest());
            return Ok(suppliers);
        }

        // GET/<SupplierController>/6
        [HttpGet("{id}")]
        public async Task<ActionResult<GetSupplierByIdDto>> Get(int id)
        {
            var suppliers = await _mediator.Send(new GetSupplierByIdRequest { Id = id});
            return Ok(suppliers);
        }

        // POST/<SupplierController>
        [HttpPost]
        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] CreateSupplierDto createSupplierDto)
        {
            var command = new CreateSupplierCommand { CreateSupplierDto = createSupplierDto };
            var response = await _mediator.Send(command);
            return Ok(response);
        }
    }
}
