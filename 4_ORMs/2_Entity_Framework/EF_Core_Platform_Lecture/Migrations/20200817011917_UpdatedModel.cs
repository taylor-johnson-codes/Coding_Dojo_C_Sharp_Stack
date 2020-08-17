using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Core_Platform_Lecture.Migrations
{
    public partial class UpdatedModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "Monsters");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Monsters",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "Monsters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Monsters",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Monsters",
                table: "Monsters",
                column: "MonsterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Monsters",
                table: "Monsters");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Monsters");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Monsters");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Monsters");

            migrationBuilder.RenameTable(
                name: "Monsters",
                newName: "Users");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "MonsterId");
        }
    }
}
