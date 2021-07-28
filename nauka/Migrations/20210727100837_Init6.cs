using Microsoft.EntityFrameworkCore.Migrations;

namespace nauka.Migrations
{
    public partial class Init6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "CurrentFreeDays",
                table: "Employees",
                type: "INTEGER",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "LastYearFreeDays",
                table: "Employees",
                type: "INTEGER",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentFreeDays",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LastYearFreeDays",
                table: "Employees");
        }
    }
}
