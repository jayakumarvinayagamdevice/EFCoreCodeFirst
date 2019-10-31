using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NorthwindPersitance.Migrations
{
    public partial class InitialMigration_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customer_CustomerId",
                schema: "efcore",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Shippers_ShipperId",
                schema: "efcore",
                table: "Order");
           

            migrationBuilder.AlterColumn<Guid>(
                name: "EmployeeId",
                schema: "efcore",
                table: "Order",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "efcore",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    SupplierId = table.Column<Guid>(nullable: false),
                    CategoryId = table.Column<Guid>(nullable: false),
                    QuantyPerUnit = table.Column<decimal>(nullable: false),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    UnitInStock = table.Column<int>(nullable: false),
                    UnitInOrder = table.Column<int>(nullable: false),
                    ReOrderLevel = table.Column<int>(nullable: false),
                    Discount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "efcore",
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalSchema: "efcore",
                        principalTable: "Suppliers",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                schema: "efcore",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SupplierId",
                schema: "efcore",
                table: "Product",
                column: "SupplierId");

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
                name: "FK_Order_Shippers_ShipperId",
                schema: "efcore",
                table: "Order",
                column: "ShipperId",
                principalSchema: "efcore",
                principalTable: "Shippers",
                principalColumn: "ShipperId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customer_CustomerId",
                schema: "efcore",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Shippers_ShipperId",
                schema: "efcore",
                table: "Order");

            migrationBuilder.DropTable(
                name: "Product",
                schema: "efcore");

            migrationBuilder.AlterColumn<Guid>(
                name: "EmployeeId",
                schema: "efcore",
                table: "Order",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<Guid>(
                name: "EmloyeeId",
                schema: "efcore",
                table: "Order",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customer_CustomerId",
                schema: "efcore",
                table: "Order",
                column: "CustomerId",
                principalSchema: "efcore",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Shippers_ShipperId",
                schema: "efcore",
                table: "Order",
                column: "ShipperId",
                principalSchema: "efcore",
                principalTable: "Shippers",
                principalColumn: "ShipperId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
