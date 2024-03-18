using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OrderManagement.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedingCustomerAndEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "City", "ContactName", "Country", "CustomerName", "DateCreated", "EmailAddress", "PostalCode" },
                values: new object[,]
                {
                    { 1, "123 Main Street", "Anytown", "John Smith", "USA", "ABC Mart", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@example.com", "12345" },
                    { 2, "456 Oak Avenue", "Sometown", "Jane Doe", "Canada", "XYZ Electronics", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "jane@example.com", "54321" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "BirthDate", "DateCreated", "FirstName", "LastName", "Notes", "Photo" },
                values: new object[,]
                {
                    { 1, new DateOnly(1987, 5, 15), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jessica", "Rodriguez", "Jessica holds a degree in Computer Science from Stanford University. She is an avid reader and enjoys hiking in her free time.", "Jessica.pic" },
                    { 2, new DateOnly(1983, 11, 8), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ryan", "Thompson", " Ryan has a background in Business Administration from Harvard University. He is passionate about volunteer work and actively volunteers at the local animal shelter.", "Ryan.pic" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
