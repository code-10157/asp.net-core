using Microsoft.EntityFrameworkCore.Migrations;

namespace Test2.Migrations
{
    public partial class AddAddressToAuthors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Member");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "Timestamp",
                table: "Member",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }
    }
}
