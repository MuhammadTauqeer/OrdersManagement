using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrdersManagment.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Persistence.Configurations.Entities
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer
                {
                    Id = 1,
                    CustomerName = "ABC Mart",
                    ContactName = "John Smith",
                    EmailAddress = "john@example.com",
                    Address = "123 Main Street",
                    City = "Anytown",
                    PostalCode = "12345",
                    Country = "USA"
                },
                new Customer
                {
                    Id = 2,
                    CustomerName = "XYZ Electronics",
                    ContactName = "Jane Doe",
                    EmailAddress = "jane@example.com",
                    Address = "456 Oak Avenue",
                    City = "Sometown",
                    PostalCode = "54321",
                    Country = "Canada"
                }
                );
        }
    }
}
