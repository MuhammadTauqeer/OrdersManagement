using Microsoft.EntityFrameworkCore;
using OrdersManagment.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Persistence.Repositories
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly OrderManagementDbContext _dbcontext;
        private IEmployeeRepository _employeeRepository { get; set; }
        private ICustomerRepository _customerRepository { get; set; }
        private ICategoryRepository _categoryRepository { get; set; }
        private IShipperRepository _shipperRepository { get; set; }
        private ISupplierRepository _supplierRepository { get; set; }
        private IProductRepository _productRepository { get; set; }

        public UnitOfWork(OrderManagementDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        public IEmployeeRepository EmployeeRepository =>
            _employeeRepository ??= new EmployeeRepository(_dbcontext);

        public ICustomerRepository CustomerRepository =>
            _customerRepository ??= new CustomerRepository(_dbcontext);

        public ICategoryRepository CategoryRepository =>
            _categoryRepository ??= new CategoryRepository(_dbcontext);
        public IShipperRepository ShipperRepository =>
            _shipperRepository ??= new ShipperRepository(_dbcontext);
        public ISupplierRepository SupplierRepository =>
            _supplierRepository ??= new SupplierRepository(_dbcontext);
        public IProductRepository ProductRepository =>
            _productRepository ??= new ProductRepository(_dbcontext);


        public void Dispose()
        {
            _dbcontext.Dispose();
            GC.SuppressFinalize(this);
        }
        public async Task Save()
        {
            await _dbcontext.SaveChangesAsync();
        }
    }
}
