using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NorthwindPersitance.Migrations
{
    public partial class InitialMigration_7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customerCustomerDemographs",
                schema: "efcore",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(nullable: false),
                    CustomerTypeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customerCustomerDemographs", x => new { x.CustomerId, x.CustomerTypeId });
                    table.ForeignKey(
                        name: "FK_customerCustomerDemographs_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalSchema: "efcore",
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_customerCustomerDemographs_CustomerDemoGraphics_CustomerTypeId",
                        column: x => x.CustomerTypeId,
                        principalSchema: "efcore",
                        principalTable: "CustomerDemoGraphics",
                        principalColumn: "CustomerTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_customerCustomerDemographs_CustomerTypeId",
                schema: "efcore",
                table: "customerCustomerDemographs",
                column: "CustomerTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customerCustomerDemographs",
                schema: "efcore");
        }
    }
}
