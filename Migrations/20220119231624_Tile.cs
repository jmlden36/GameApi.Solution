using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GameApi.Solution.Migrations
{
    public partial class Tile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cardigans");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Shoes");

            migrationBuilder.CreateTable(
                name: "Tiles",
                columns: table => new
                {
                    TileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Transparent = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tiles", x => x.TileId);
                });

            migrationBuilder.CreateTable(
                name: "ZaWorldo",
                columns: table => new
                {
                    TilePositionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TileId = table.Column<int>(type: "int", nullable: false),
                    x = table.Column<int>(type: "int", nullable: false),
                    y = table.Column<int>(type: "int", nullable: false),
                    z = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZaWorldo", x => x.TilePositionId);
                    table.ForeignKey(
                        name: "FK_ZaWorldo_Tiles_TileId",
                        column: x => x.TileId,
                        principalTable: "Tiles",
                        principalColumn: "TileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Tiles",
                columns: new[] { "TileId", "Name", "Transparent" },
                values: new object[] { 1, "floor", true });

            migrationBuilder.InsertData(
                table: "Tiles",
                columns: new[] { "TileId", "Name", "Transparent" },
                values: new object[] { 2, "wall", false });

            migrationBuilder.InsertData(
                table: "Tiles",
                columns: new[] { "TileId", "Name", "Transparent" },
                values: new object[] { 3, "player", false });

            migrationBuilder.InsertData(
                table: "ZaWorldo",
                columns: new[] { "TilePositionId", "TileId", "x", "y", "z" },
                values: new object[,]
                {
                    { 9, 1, 1, 5, 0 },
                    { 8, 2, 1, 6, 0 },
                    { 15, 2, 2, 6, 0 },
                    { 22, 2, 3, 6, 0 },
                    { 29, 2, 4, 6, 0 },
                    { 36, 2, 5, 6, 0 },
                    { 43, 2, 6, 6, 0 },
                    { 2, 2, 0, 5, 0 },
                    { 44, 2, 6, 5, 0 },
                    { 3, 2, 0, 4, 0 },
                    { 45, 2, 6, 4, 0 },
                    { 4, 2, 0, 3, 0 },
                    { 46, 2, 6, 3, 0 },
                    { 5, 2, 0, 2, 0 },
                    { 47, 2, 6, 2, 0 },
                    { 6, 2, 0, 1, 0 },
                    { 48, 2, 6, 1, 0 },
                    { 7, 2, 0, 0, 0 },
                    { 14, 2, 1, 0, 0 },
                    { 21, 2, 2, 0, 0 },
                    { 28, 2, 3, 0, 0 },
                    { 35, 2, 4, 0, 0 },
                    { 1, 2, 0, 6, 0 },
                    { 42, 2, 5, 0, 0 },
                    { 41, 1, 5, 1, 0 },
                    { 27, 1, 3, 1, 0 },
                    { 16, 1, 2, 5, 0 },
                    { 23, 1, 3, 5, 0 },
                    { 30, 1, 4, 5, 0 },
                    { 37, 1, 5, 5, 0 },
                    { 10, 1, 1, 4, 0 },
                    { 17, 1, 2, 4, 0 },
                    { 24, 1, 3, 4, 0 },
                    { 31, 1, 4, 4, 0 },
                    { 38, 1, 5, 4, 0 },
                    { 11, 1, 1, 3, 0 },
                    { 18, 1, 2, 3, 0 },
                    { 25, 1, 3, 3, 0 },
                    { 32, 1, 4, 3, 0 },
                    { 39, 1, 5, 3, 0 },
                    { 12, 1, 1, 2, 0 },
                    { 19, 1, 2, 2, 0 },
                    { 26, 1, 3, 2, 0 },
                    { 33, 1, 4, 2, 0 },
                    { 40, 1, 5, 2, 0 },
                    { 13, 1, 1, 1, 0 },
                    { 20, 1, 2, 1, 0 },
                    { 34, 1, 4, 1, 0 },
                    { 49, 2, 6, 0, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ZaWorldo_TileId",
                table: "ZaWorldo",
                column: "TileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ZaWorldo");

            migrationBuilder.DropTable(
                name: "Tiles");

            migrationBuilder.CreateTable(
                name: "Cardigans",
                columns: table => new
                {
                    CardiganId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cardigans", x => x.CardiganId);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "Shoes",
                columns: table => new
                {
                    ShoeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shoes", x => x.ShoeId);
                });
        }
    }
}
