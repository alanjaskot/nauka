using Microsoft.EntityFrameworkCore.Migrations;

namespace nauka.Migrations
{
    public partial class Init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "ExtraFreeDays",
                table: "Employees",
                type: "INTEGER",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "YearsOfExpirence",
                table: "Employees",
                type: "INTEGER",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExtraFreeDays",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "YearsOfExpirence",
                table: "Employees");
        }
    }
}
