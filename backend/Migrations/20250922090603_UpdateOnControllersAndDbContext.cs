using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOnControllersAndDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 74,
                column: "Description",
                value: "Lok");

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 95,
                column: "Description",
                value: "Poststation");

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Hjärta", "❤️" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Brusten", "💔" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Stjärna", "⭐" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Glans", "✨" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Blixt", "⚡" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Eld", "🔥" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Droppe", "💧" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Utrop", "❗" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Fråga", "❓" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Klar", "✅" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Fel", "❌" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Plus", "➕" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Minus", "➖" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Division", "➗" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Triangel", "🔺" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Glad", "🙂" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Ledsen", "😢" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Arg", "😠" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Kär", "😍" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Förvånad", "😮" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Spänd", "😬" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Chockad", "😲" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Frustrerad", "😤" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Ilska", "😡" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Nöjd", "😊" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Entusiastisk", "😃" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Förvirrad", "😕" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Nervös", "😅" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Lugn", "😌" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Rädd", "😱" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Blinkar", "😉" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Flinar", "😏" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Oseriös", "🙃" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Tänker", "🤔" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Njuter", "😋" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Busig", "😜" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Fnissar", "🤭" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Skämtar", "😛" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Cool", "😎" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Skrattar", "😂" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Imponerad", "🤩" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Rörd", "🥹" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Dreglar", "🤤" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Smälter", "🫠" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Kräks", "🤮" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 74,
                column: "Description",
                value: "Tåg");

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 95,
                column: "Description",
                value: "Station");

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Glad", "🙂" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Ledsen", "😢" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Arg", "😠" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Kär", "😍" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Förvånad", "😮" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Spänd", "😬" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Chockad", "😲" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Frustrerad", "😤" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Ilska", "😡" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Nöjd", "😊" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Entusiastisk", "😃" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Förvirrad", "😕" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Nervös", "😅" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Lugn", "😌" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Rädd", "😱" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Blinkar", "😉" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Flinar", "😏" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Oseriös", "🙃" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Tänker", "🤔" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Njuter", "😋" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Busig", "😜" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Fnissar", "🤭" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Skämtar", "😛" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Cool", "😎" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Skrattar", "😂" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Imponerad", "🤩" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Rörd", "🥹" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Dreglar", "🤤" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Smälter", "🫠" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Kräks", "🤮" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Hjärta", "❤️" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Brusten", "💔" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Stjärna", "⭐" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Glans", "✨" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Blixt", "⚡" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Eld", "🔥" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Droppe", "💧" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Utrop", "❗" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Fråga", "❓" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Klar", "✅" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Fel", "❌" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Plus", "➕" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Minus", "➖" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Division", "➗" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Triangel", "🔺" });
        }
    }
}
