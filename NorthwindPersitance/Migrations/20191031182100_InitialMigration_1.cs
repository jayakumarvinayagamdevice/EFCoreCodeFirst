using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NorthwindPersitance.Migrations
{
    public partial class InitialMigration_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerDemoGraphics",
                schema: "efcore",
                columns: table => new
                {
                    CustomerTypeId = table.Column<Guid>(nullable: false),
                    CustomerDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerDemoGraphics", x => x.CustomerTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                schema: "efcore",
                columns: table => new
                {
                    EmployeeId = table.Column<Guid>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    TitleOfCourtesy = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    HireDate = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    HomePhone = table.Column<string>(nullable: true),
                    Extension = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    ReportsTo = table.Column<Guid>(nullable: false),
                    PhotoPath = table.Column<string>(nullable: true),
                    Salary = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                schema: "efcore",
                columns: table => new
                {
                    RegionId = table.Column<Guid>(nullable: false),
                    RegionDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.RegionId);
                });

            migrationBuilder.CreateTable(
                name: "Shippers",
                schema: "efcore",
                columns: table => new
                {
                    ShipperId = table.Column<Guid>(nullable: false),
                    CompanyName = table.Column<string>(maxLength: 40, nullable: true),
                    Phone = table.Column<string>(maxLength: 24, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shippers", x => x.ShipperId);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                schema: "efcore",
                columns: table => new
                {
                    SupplierId = table.Column<Guid>(nullable: false),
                    SupplierName = table.Column<string>(nullable: true),
                    ContactName = table.Column<string>(nullable: true),
                    ContactTitle = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    HomePage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerDemoGraphics",
                schema: "efcore");

            migrationBuilder.DropTable(
                name: "Employees",
                schema: "efcore");

            migrationBuilder.DropTable(
                name: "Regions",
                schema: "efcore");

            migrationBuilder.DropTable(
                name: "Shippers",
                schema: "efcore");

            migrationBuilder.DropTable(
                name: "Suppliers",
                schema: "efcore");
        }
    }
}
