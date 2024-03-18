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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData
                (
                new Category
                {
                    Id = 1,
                    CategoryName = "Hard Drive ABC",
                    CategoryDescription = "SSD NVME 3200 MB/s Read/Write",
                },
                new Category
                {
                    Id = 2,
                    CategoryName = "Hard Drive XYZ",
                    CategoryDescription = "SSD 500 MB/s Read/Wrote"
                }

                );
        }
    }
}
