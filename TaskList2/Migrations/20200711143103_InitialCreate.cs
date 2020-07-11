using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskList2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<int>(nullable: false),
                    ProjectName = table.Column<string>(maxLength: 50, nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    CompletionDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: true),
                    Priority = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Thing",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    ProjectID = table.Column<int>(nullable: false),
                    Process = table.Column<string>(nullable: true),
                    TaskName = table.Column<string>(nullable: true),
                    Start = table.Column<DateTime>(nullable: false),
                    End = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: true),
                    Progress = table.Column<string>(nullable: true),
                    Memo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thing", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Thing_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Thing_ProjectID",
                table: "Thing",
                column: "ProjectID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Thing");

            migrationBuilder.DropTable(
                name: "Project");
        }
    }
}
