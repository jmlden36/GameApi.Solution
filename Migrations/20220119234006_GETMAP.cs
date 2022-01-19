using Microsoft.EntityFrameworkCore.Migrations;

namespace GameApi.Solution.Migrations
{
    public partial class GETMAP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ZaWorldo_Tiles_TileId",
                table: "ZaWorldo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ZaWorldo",
                table: "ZaWorldo");

            migrationBuilder.RenameTable(
                name: "ZaWorldo",
                newName: "World");

            migrationBuilder.RenameIndex(
                name: "IX_ZaWorldo_TileId",
                table: "World",
                newName: "IX_World_TileId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_World",
                table: "World",
                column: "TilePositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_World_Tiles_TileId",
                table: "World",
                column: "TileId",
                principalTable: "Tiles",
                principalColumn: "TileId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_World_Tiles_TileId",
                table: "World");

            migrationBuilder.DropPrimaryKey(
                name: "PK_World",
                table: "World");

            migrationBuilder.RenameTable(
                name: "World",
                newName: "ZaWorldo");

            migrationBuilder.RenameIndex(
                name: "IX_World_TileId",
                table: "ZaWorldo",
                newName: "IX_ZaWorldo_TileId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ZaWorldo",
                table: "ZaWorldo",
                column: "TilePositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_ZaWorldo_Tiles_TileId",
                table: "ZaWorldo",
                column: "TileId",
                principalTable: "Tiles",
                principalColumn: "TileId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
