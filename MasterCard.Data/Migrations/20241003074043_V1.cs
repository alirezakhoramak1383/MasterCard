using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MasterCard.Data.Migrations
{
    /// <inheritdoc />
    public partial class V1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardCategories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CadModels",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(700)", maxLength: 700, nullable: false),
                    Link = table.Column<string>(type: "nvarchar(700)", maxLength: 700, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CardCategoryId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CadModels_CardCategories_CardCategoryId",
                        column: x => x.CardCategoryId,
                        principalTable: "CardCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CadModels_CardCategoryId",
                table: "CadModels",
                column: "CardCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CadModels");

            migrationBuilder.DropTable(
                name: "CardCategories");
        }
    }
}
