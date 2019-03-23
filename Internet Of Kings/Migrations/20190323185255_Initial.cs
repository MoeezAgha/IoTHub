using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Internet_Of_Kings.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LogInformations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Time = table.Column<DateTime>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Value = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogInformations", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LogInformations");
        }
    }
}
