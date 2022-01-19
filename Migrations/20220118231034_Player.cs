using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameApi.Solution.Migrations
{
    public partial class Player : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    EquippedCardiganCardiganId = table.Column<int>(type: "int", nullable: true),
                    EquippedShoesShoeId = table.Column<int>(type: "int", nullable: true),
                    HandItemItemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_Players_Cardigans_EquippedCardiganCardiganId",
                        column: x => x.EquippedCardiganCardiganId,
                        principalTable: "Cardigans",
                        principalColumn: "CardiganId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Players_Items_HandItemItemId",
                        column: x => x.HandItemItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Players_Shoes_EquippedShoesShoeId",
                        column: x => x.EquippedShoesShoeId,
                        principalTable: "Shoes",
                        principalColumn: "ShoeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_EquippedCardiganCardiganId",
                table: "Players",
                column: "EquippedCardiganCardiganId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_EquippedShoesShoeId",
                table: "Players",
                column: "EquippedShoesShoeId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_HandItemItemId",
                table: "Players",
                column: "HandItemItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
