using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Core_Instructor_Lecture.Migrations
{
    public partial class UpdatedVoteModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Votes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsUpVote",
                table: "Votes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Votes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "IsUpVote",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Votes");
        }
    }
}
