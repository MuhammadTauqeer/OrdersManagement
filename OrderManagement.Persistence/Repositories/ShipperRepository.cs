using OrdersManagment.Application.Contracts.Persistence;
using OrdersManagment.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Persistence.Repositories
{
    public class ShipperRepository: GenericRepository<Shipper>, IShipperRepository
    {
        private readonly OrderManagementDbContext _dbContext;
        public ShipperRepository(OrderManagementDbContext dbContext): base(dbContext) 
        {

            _dbContext = dbContext;

        }
    }
}
