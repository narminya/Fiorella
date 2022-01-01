using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiorella.Migrations
{
    public partial class tg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Fullname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fullname",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "AspNetUsers");
        }
    }
}
