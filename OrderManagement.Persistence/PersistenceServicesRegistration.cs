using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OrderManagement.Persistence.Repositories;
using OrdersManagment.Application.Contracts.Persistence;

namespace OrderManagement.Persistence
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<OrderManagementDbContext>(options =>
              options.UseSqlServer(
                  configuration.GetConnectionString("OrderManagementConnectionString")));

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ISupplierRepository, SupplierRepository>();



            return services;
        }
    }

    public class OrderManagementDbContectFactory : IDesignTimeDbContextFactory<OrderManagementDbContext>
    {
        public OrderManagementDbContext CreateDbContext(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true);
            builder.Build();

            var dbContextBuilder = new DbContextOptionsBuilder<OrderManagementDbContext>();
            IConfiguration configuration = builder.Build();
             var connectionString = configuration.GetConnectionString("OrderManagementConnectionString");

            dbContextBuilder.UseSqlServer(connectionString);

            return new OrderManagementDbContext(dbContextBuilder.Options);

        }
    }
}