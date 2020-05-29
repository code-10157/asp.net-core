using Microsoft.EntityFrameworkCore.Migrations;

namespace Test2.Migrations
{
    public partial class AddAddressToMembers2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Member");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DateTime",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
