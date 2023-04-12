using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class UserMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "_updateAt",
                table: "User");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateAt",
                table: "User",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdateAt",
                table: "User");

            migrationBuilder.AddColumn<DateTime>(
                name: "_updateAt",
                table: "User",
                type: "datetime(6)",
                nullable: true);
        }
    }
}
