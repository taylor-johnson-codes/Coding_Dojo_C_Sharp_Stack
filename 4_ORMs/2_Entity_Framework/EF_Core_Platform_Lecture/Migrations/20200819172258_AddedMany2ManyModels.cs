using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Core_Platform_Lecture.Migrations
{
    public partial class AddedMany2ManyModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "M2M_Magazines",
                columns: table => new
                {
                    M2M_MagazineId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    M2M_Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M2M_Magazines", x => x.M2M_MagazineId);
                });

            migrationBuilder.CreateTable(
                name: "M2M_Persons",
                columns: table => new
                {
                    M2M_PersonId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    M2M_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M2M_Persons", x => x.M2M_PersonId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "M2M_Subscriptions",
                columns: table => new
                {
                    M2M_SubscriptionId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    M2M_PersonId = table.Column<int>(nullable: false),
                    M2M_MagazineId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M2M_Subscriptions", x => x.M2M_SubscriptionId);
                    table.ForeignKey(
                        name: "FK_M2M_Subscriptions_M2M_Magazines_M2M_MagazineId",
                        column: x => x.M2M_MagazineId,
                        principalTable: "M2M_Magazines",
                        principalColumn: "M2M_MagazineId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_M2M_Subscriptions_M2M_Persons_M2M_PersonId",
                        column: x => x.M2M_PersonId,
                        principalTable: "M2M_Persons",
                        principalColumn: "M2M_PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Content = table.Column<string>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK_Messages_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_M2M_Subscriptions_M2M_MagazineId",
                table: "M2M_Subscriptions",
                column: "M2M_MagazineId");

            migrationBuilder.CreateIndex(
                name: "IX_M2M_Subscriptions_M2M_PersonId",
                table: "M2M_Subscriptions",
                column: "M2M_PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserId",
                table: "Messages",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "M2M_Subscriptions");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "M2M_Magazines");

            migrationBuilder.DropTable(
                name: "M2M_Persons");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
