using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MasterCard.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDatabas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CardCategories",
                columns: new[] { "Id", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 1L, false, "ریاست" },
                    { 2L, false, "معاونت آموزش" },
                    { 3L, false, "معاونت فرهنگی تربیتی" },
                    { 4L, false, "معاونت پژوهش" },
                    { 5L, false, "معاونت بین الملل" }
                });

            migrationBuilder.InsertData(
                table: "CadModels",
                columns: new[] { "Id", "CardCategoryId", "Description", "Icon", "IsDeleted", "Link", "Title" },
                values: new object[,]
                {
                    { 1L, 1L, "نسخه جدید (سازگار با مرورگرهای گوگل کروم و فایرفاکس)", "https://localhost:7143/images/SiteIcons/chargoon.png", false, "http://office5.miu.ir", "سامانه اتوماسیون اداری نسخه 5" },
                    { 2L, 1L, "", "https://localhost:7143/images/SiteIcons/foodCourt.png", false, "https://food.miu.ac.ir", "سامانه تغذیه" },
                    { 3L, 1L, "گردشگری، تسهیلات، هدایا و بیمه", "https://localhost:7143/images/SiteIcons/workers.png", false, "http://irefah.miu.ir/", "سامانه رفاهی کارکنان" },
                    { 4L, 1L, "پست الکترونیک سازمانی المصطفی (مدیران، اساتید و کارکنان)", "https://localhost:7143/images/SiteIcons/electronic.png", false, "https://mail.miu.ac.ir", "پست الکترونیک المصطفی" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CadModels",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "CadModels",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "CadModels",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "CadModels",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "CardCategories",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "CardCategories",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "CardCategories",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "CardCategories",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "CardCategories",
                keyColumn: "Id",
                keyValue: 1L);
        }
    }
}
