using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MasterCard.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddIsActive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "CardCategories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "CadModels",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "CadModels",
                keyColumn: "Id",
                keyValue: 1L,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "CadModels",
                keyColumn: "Id",
                keyValue: 2L,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "CadModels",
                keyColumn: "Id",
                keyValue: 3L,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "CadModels",
                keyColumn: "Id",
                keyValue: 4L,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "CardCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "CardCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "CardCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "CardCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "IsActive",
                value: false);

            migrationBuilder.UpdateData(
                table: "CardCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "IsActive",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "CardCategories");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "CadModels");
        }
    }
}
