using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class AddSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Levels",
                columns: new[] { "Id", "Number" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Emojis",
                columns: new[] { "Id", "Description", "LevelId", "Symbol" },
                values: new object[,]
                {
                    { 1, "Glad", 1, "🙂" },
                    { 2, "Ledsen", 1, "😢" },
                    { 3, "Arg", 1, "😠" },
                    { 4, "Kär", 1, "😍" },
                    { 5, "Förvånad", 1, "😮" },
                    { 6, "Blinkar", 1, "😉" },
                    { 7, "Cool", 1, "😎" },
                    { 8, "Skrattar", 1, "😂" },
                    { 9, "Snäll", 1, "😇" },
                    { 10, "Sover", 1, "😴" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Levels",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
