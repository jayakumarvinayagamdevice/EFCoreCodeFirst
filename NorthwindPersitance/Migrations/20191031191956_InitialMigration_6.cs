using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NorthwindPersitance.Migrations
{
    public partial class InitialMigration_6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customer_CustomerId",
                schema: "efcore",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Employees_EmployeeId",
                schema: "efcore",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Shippers_ShipperId",
                schema: "efcore",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Categories_CategoryId",
                schema: "efcore",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Suppliers_SupplierId",
                schema: "efcore",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                schema: "efcore",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                schema: "efcore",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                schema: "efcore",
                table: "Customer");

            migrationBuilder.RenameTable(
                name: "Product",
                schema: "efcore",
                newName: "Products",
                newSchema: "efcore");

            migrationBuilder.RenameTable(
                name: "Order",
                schema: "efcore",
                newName: "Orders",
                newSchema: "efcore");

            migrationBuilder.RenameTable(
                name: "Customer",
                schema: "efcore",
                newName: "Customers",
                newSchema: "efcore");

            migrationBuilder.RenameIndex(
                name: "IX_Product_SupplierId",
                schema: "efcore",
                table: "Products",
                newName: "IX_Products_SupplierId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_CategoryId",
                schema: "efcore",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_ShipperId",
                schema: "efcore",
                table: "Orders",
                newName: "IX_Orders_ShipperId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_EmployeeId",
                schema: "efcore",
                table: "Orders",
                newName: "IX_Orders_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_CustomerId",
                schema: "efcore",
                table: "Orders",
                newName: "IX_Orders_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                schema: "efcore",
                table: "Products",
                column: "ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                schema: "efcore",
                table: "Orders",
                column: "OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                schema: "efcore",
                table: "Customers",
                column: "CustomerId");

            migrationBuilder.CreateTable(
                name: "EmployeeTerritories",
                schema: "efcore",
                columns: table => new
                {
                    EmployeeId = table.Column<Guid>(nullable: false),
                    TerritoryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTerritories", x => new { x.EmployeeId, x.TerritoryId });
                    table.ForeignKey(
                        name: "FK_EmployeeTerritories_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalSchema: "efcore",
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeTerritories_Territories_TerritoryId",
                        column: x => x.TerritoryId,
                        principalSchema: "efcore",
                        principalTable: "Territories",
                        principalColumn: "TerritoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTerritories_TerritoryId",
                schema: "efcore",
                table: "EmployeeTerritories",
                column: "TerritoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                schema: "efcore",
                table: "Orders",
                column: "CustomerId",
                principalSchema: "efcore",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Employees_EmployeeId",
                schema: "efcore",
                table: "Orders",
                column: "EmployeeId",
                principalSchema: "efcore",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Shippers_ShipperId",
                schema: "efcore",
                table: "Orders",
                column: "ShipperId",
                principalSchema: "efcore",
                principalTable: "Shippers",
                principalColumn: "ShipperId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                schema: "efcore",
                table: "Products",
                column: "CategoryId",
                principalSchema: "efcore",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Suppliers_SupplierId",
                schema: "efcore",
                table: "Products",
                column: "SupplierId",
                principalSchema: "efcore",
                principalTable: "Suppliers",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                schema: "efcore",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Employees_EmployeeId",
                schema: "efcore",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Shippers_ShipperId",
                schema: "efcore",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                schema: "efcore",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Suppliers_SupplierId",
                schema: "efcore",
                table: "Products");

            migrationBuilder.DropTable(
                name: "EmployeeTerritories",
                schema: "efcore");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                schema: "efcore",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                schema: "efcore",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                schema: "efcore",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "Products",
                schema: "efcore",
                newName: "Product",
                newSchema: "efcore");

            migrationBuilder.RenameTable(
                name: "Orders",
                schema: "efcore",
                newName: "Order",
                newSchema: "efcore");

            migrationBuilder.RenameTable(
                name: "Customers",
                schema: "efcore",
                newName: "Customer",
                newSchema: "efcore");

            migrationBuilder.RenameIndex(
                name: "IX_Products_SupplierId",
                schema: "efcore",
                table: "Product",
                newName: "IX_Product_SupplierId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                schema: "efcore",
                table: "Product",
                newName: "IX_Product_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ShipperId",
                schema: "efcore",
                table: "Order",
                newName: "IX_Order_ShipperId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_EmployeeId",
                schema: "efcore",
                table: "Order",
                newName: "IX_Order_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CustomerId",
                schema: "efcore",
                table: "Order",
                newName: "IX_Order_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                schema: "efcore",
                table: "Product",
                column: "ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                schema: "efcore",
                table: "Order",
                column: "OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                schema: "efcore",
                table: "Customer",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customer_CustomerId",
                schema: "efcore",
                table: "Order",
                column: "CustomerId",
                principalSchema: "efcore",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Employees_EmployeeId",
                schema: "efcore",
                table: "Order",
                column: "EmployeeId",
                principalSchema: "efcore",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Shippers_ShipperId",
                schema: "efcore",
                table: "Order",
                column: "ShipperId",
                principalSchema: "efcore",
                principalTable: "Shippers",
                principalColumn: "ShipperId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Categories_CategoryId",
                schema: "efcore",
                table: "Product",
                column: "CategoryId",
                principalSchema: "efcore",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Suppliers_SupplierId",
                schema: "efcore",
                table: "Product",
                column: "SupplierId",
                principalSchema: "efcore",
                principalTable: "Suppliers",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
