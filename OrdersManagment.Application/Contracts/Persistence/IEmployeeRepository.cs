using OrdersManagment.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersManagment.Application.Contracts.Persistence
{
    public interface IEmployeeRepository: IGenericRepository<Employee>
    {
    }
}
