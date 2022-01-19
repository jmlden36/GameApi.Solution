using Microsoft.EntityFrameworkCore.Migrations;

namespace GameApi.Solution.Migrations
{
    public partial class ChangePlayerProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "x",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "y",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "z",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "x",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "y",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "z",
                table: "Players");
        }
    }
}
