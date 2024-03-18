using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrdersManagment.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Persistence.Configurations.Entities
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee
                {
                    Id = 1,
                    FirstName = "Jessica",
                    LastName = "Rodriguez",
                    BirthDate = new DateOnly(1987,5,15),
                    Photo = "Jessica.pic",
                    Notes = "Jessica holds a degree in Computer Science from Stanford University. She is an avid reader and enjoys hiking in her free time."
                },
                new Employee
                {
                    Id= 2,
                    FirstName = "Ryan",
                    LastName = "Thompson",
                    BirthDate = new DateOnly(1983,11,8),
                    Photo = "Ryan.pic",
                    Notes = " Ryan has a background in Business Administration from Harvard University. He is passionate about volunteer work and actively volunteers at the local animal shelter."
                }
                );
        }
    }
}
