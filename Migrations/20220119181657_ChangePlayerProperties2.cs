using Microsoft.EntityFrameworkCore.Migrations;

namespace GameApi.Solution.Migrations
{
    public partial class ChangePlayerProperties2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Cardigans_EquippedCardiganCardiganId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Items_HandItemItemId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Shoes_EquippedShoesShoeId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_EquippedCardiganCardiganId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_EquippedShoesShoeId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_HandItemItemId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "EquippedCardiganCardiganId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "EquippedShoesShoeId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "HandItemItemId",
                table: "Players");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EquippedCardiganCardiganId",
                table: "Players",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EquippedShoesShoeId",
                table: "Players",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HandItemItemId",
                table: "Players",
                type: "int",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Cardigans_EquippedCardiganCardiganId",
                table: "Players",
                column: "EquippedCardiganCardiganId",
                principalTable: "Cardigans",
                principalColumn: "CardiganId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Items_HandItemItemId",
                table: "Players",
                column: "HandItemItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Shoes_EquippedShoesShoeId",
                table: "Players",
                column: "EquippedShoesShoeId",
                principalTable: "Shoes",
                principalColumn: "ShoeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
