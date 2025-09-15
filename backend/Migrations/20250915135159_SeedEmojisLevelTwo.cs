using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedEmojisLevelTwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Emojis",
                columns: new[] { "Id", "Description", "LevelId", "Symbol" },
                values: new object[,]
                {
                    { 11, "Nöjd", 2, "😊" },
                    { 12, "Tänker", 2, "🤔" },
                    { 13, "Entusiastisk", 2, "😃" },
                    { 14, "Förvirrad", 2, "😕" },
                    { 15, "Nervös", 2, "😅" },
                    { 16, "Upp och ner", 2, "🙃" },
                    { 17, "Lugn", 2, "😌" },
                    { 18, "Kram", 2, "🤗" },
                    { 19, "Gott", 2, "😋" },
                    { 20, "Flinar", 2, "😏" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
