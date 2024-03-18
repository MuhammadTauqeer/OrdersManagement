using OrdersManagment.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManagment.Application.DTOs.Employees
{
    public class GetEmployeesListDto: BaseDto, IEmployeeDto
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Photo { get; set; }
    }
}
