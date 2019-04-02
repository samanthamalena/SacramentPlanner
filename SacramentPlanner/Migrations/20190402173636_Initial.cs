using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentPlanner.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sacrament",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Conducting = table.Column<string>(nullable: true),
                    OpenHymn = table.Column<string>(nullable: true),
                    OpenPrayer = table.Column<string>(nullable: true),
                    SacramentHymn = table.Column<string>(nullable: true),
                    Speaker = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    CloseHymn = table.Column<string>(nullable: true),
                    ClosePrayer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sacrament", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sacrament");
        }
    }
}
