using OrdersManagment.Application.Contracts.Persistence;
using OrdersManagment.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Persistence.Repositories
{
    public class CustomerRepository: GenericRepository<Customer>, ICustomerRepository
    {
        private readonly OrderManagementDbContext _dbContext;
        public CustomerRepository(OrderManagementDbContext dbContext): base(dbContext)
        {

            _dbContext = dbContext;

        }
    }
}
