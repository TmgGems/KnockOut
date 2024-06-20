using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductCrudKnockOut.Migrations
{
    /// <inheritdoc />
    public partial class foreginkeyaddedinCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Companies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProductManufactured",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ProductId",
                table: "Companies",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Products_ProductId",
                table: "Companies",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Products_ProductId",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_ProductId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "ProductManufactured",
                table: "Companies");
        }
    }
}
