using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NorthwindPersitance.Migrations
{
    public partial class InitialMigration_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Territories",
                schema: "efcore",
                columns: table => new
                {
                    TerritoryId = table.Column<Guid>(nullable: false),
                    TerritoryDescription = table.Column<string>(nullable: true),
                    RegionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Territories", x => x.TerritoryId);
                    table.ForeignKey(
                        name: "FK_Territories_Regions_RegionId",
                        column: x => x.RegionId,
                        principalSchema: "efcore",
                        principalTable: "Regions",
                        principalColumn: "RegionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Territories_RegionId",
                schema: "efcore",
                table: "Territories",
                column: "RegionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Territories",
                schema: "efcore");
        }
    }
}
