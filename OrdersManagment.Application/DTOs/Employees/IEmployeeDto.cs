using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManagment.Application.DTOs.Employees
{
    public interface IEmployeeDto
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
}
