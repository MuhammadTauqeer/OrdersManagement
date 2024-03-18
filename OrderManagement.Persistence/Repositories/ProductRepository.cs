using OrdersManagment.Application.Contracts.Persistence;
using OrdersManagment.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Persistence.Repositories
{
    public class ProductRepository: GenericRepository<Product>, IProductRepository
    {
        private readonly OrderManagementDbContext _dbContext;
        public ProductRepository(OrderManagementDbContext dbContext): base(dbContext)
        {

            _dbContext = dbContext;

        }
    }
}
