using Microsoft.EntityFrameworkCore.Migrations;

namespace GearShop.Migrations
{
    public partial class AddedSalePriceAndQty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PQuantityOnHand",
                table: "Pants",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "PSalePrice",
                table: "Pants",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "JQuantityOnHand",
                table: "Jerseys",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "JSalePrice",
                table: "Jerseys",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PQuantityOnHand",
                table: "Pants");

            migrationBuilder.DropColumn(
                name: "PSalePrice",
                table: "Pants");

            migrationBuilder.DropColumn(
                name: "JQuantityOnHand",
                table: "Jerseys");

            migrationBuilder.DropColumn(
                name: "JSalePrice",
                table: "Jerseys");
        }
    }
}
