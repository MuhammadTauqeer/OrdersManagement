﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderManagement.Persistence;

#nullable disable

namespace OrderManagement.Persistence.Migrations
{
    [DbContext(typeof(OrderManagementDbContext))]
    partial class OrderManagementDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OrdersManagment.Domain.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Main Street",
                            City = "Anytown",
                            ContactName = "John Smith",
                            Country = "USA",
                            CustomerName = "ABC Mart",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "john@example.com",
                            PostalCode = "12345"
                        },
                        new
                        {
                            Id = 2,
                            Address = "456 Oak Avenue",
                            City = "Sometown",
                            ContactName = "Jane Doe",
                            Country = "Canada",
                            CustomerName = "XYZ Electronics",
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "jane@example.com",
                            PostalCode = "54321"
                        });
                });

            modelBuilder.Entity("OrdersManagment.Domain.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateOnly(1987, 5, 15),
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jessica",
                            LastName = "Rodriguez",
                            Notes = "Jessica holds a degree in Computer Science from Stanford University. She is an avid reader and enjoys hiking in her free time.",
                            Photo = "Jessica.pic"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateOnly(1983, 11, 8),
                            DateCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Ryan",
                            LastName = "Thompson",
                            Notes = " Ryan has a background in Business Administration from Harvard University. He is passionate about volunteer work and actively volunteers at the local animal shelter.",
                            Photo = "Ryan.pic"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
