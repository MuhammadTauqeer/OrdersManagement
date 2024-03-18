using MediatR;
using Microsoft.AspNetCore.Mvc;
using OrdersManagment.Application.DTOs.Employees;
using OrdersManagment.Application.Features.Employees.Requests.Commands;
using OrdersManagment.Application.Features.Employees.Requests.Queries;
using OrdersManagment.Application.Responses;

namespace OrdersManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IMediator _mediator;
        //private readonly IHttpContextAccessor _httpContextAccessor;
        public EmployeeController(
            IMediator mediator
            //IHttpContextAccessor httpContextAccessor
            )
        {
            _mediator = mediator;
            //_httpContextAccessor = httpContextAccessor;
        }

        // GET api/<EmployeeController>
        [HttpGet]
        public async Task<ActionResult<List<GetEmployeesListDto>>> Get()
        {
            var employees = await _mediator.Send(new GetAllEmployeesRequest());

            return Ok(employees);
        }

        // GET api/<EmployeeController>/4
        [HttpGet("{id}")]
        public async Task <ActionResult<GetEmployeeByIdDto>>Get(int Id)
        {
            var employee  = await _mediator.Send(new GetEmployeeByIdRequest { Id = Id });
            return Ok(employee);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] CreateEmployeeDto createEmployeeDto)
        {
            var command = new CreateEmployeeCommand { EmployeeDto = createEmployeeDto };
            var response = await _mediator.Send(command);
            return Ok(response);
        }
    }
}
