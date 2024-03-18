using OrdersManagment.Application.Contracts.Persistence;
using OrdersManagment.Domain;

namespace OrderManagement.Persistence.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        private readonly OrderManagementDbContext _dbContext;
        public EmployeeRepository(OrderManagementDbContext dbContext): base(dbContext)
        {

            _dbContext = dbContext;

        }
    }
}
