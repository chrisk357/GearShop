using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GearShop.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jerseys",
                columns: table => new
                {
                    JId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    JBrand = table.Column<string>(nullable: true),
                    JModel = table.Column<string>(nullable: true),
                    JColor = table.Column<string>(nullable: true),
                    JSize = table.Column<string>(nullable: true),
                    JPrice = table.Column<double>(nullable: false),
                    JImageUrl = table.Column<string>(nullable: true),
                    IsJOfTheWeek = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jerseys", x => x.JId);
                });

            migrationBuilder.CreateTable(
                name: "Pants",
                columns: table => new
                {
                    PId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PBrand = table.Column<string>(nullable: true),
                    PModel = table.Column<string>(nullable: true),
                    PColor = table.Column<string>(nullable: true),
                    PSize = table.Column<string>(nullable: true),
                    PPrice = table.Column<double>(nullable: false),
                    PImageUrl = table.Column<string>(nullable: true),
                    IsPOfTheWeek = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pants", x => x.PId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jerseys");

            migrationBuilder.DropTable(
                name: "Pants");
        }
    }
}
