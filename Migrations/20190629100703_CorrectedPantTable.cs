using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GearShop.Migrations
{
    public partial class CorrectedPantTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PSize",
                table: "Pants",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Helmets",
                columns: table => new
                {
                    HId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HBrand = table.Column<string>(nullable: true),
                    HModel = table.Column<string>(nullable: true),
                    HColor = table.Column<string>(nullable: true),
                    HSize = table.Column<string>(nullable: true),
                    HPrice = table.Column<double>(nullable: false),
                    HSalePrice = table.Column<double>(nullable: false),
                    HImageUrl = table.Column<string>(nullable: true),
                    IsHOfTheWeek = table.Column<bool>(nullable: false),
                    HQuantityOnHand = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Helmets", x => x.HId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Helmets");

            migrationBuilder.AlterColumn<string>(
                name: "PSize",
                table: "Pants",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
