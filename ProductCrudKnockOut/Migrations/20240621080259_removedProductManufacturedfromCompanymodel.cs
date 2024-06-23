using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductCrudKnockOut.Migrations
{
    /// <inheritdoc />
    public partial class removedProductManufacturedfromCompanymodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductManufactured",
                table: "Companies");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductManufactured",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
