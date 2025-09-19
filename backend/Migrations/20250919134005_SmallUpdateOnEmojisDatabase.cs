using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class SmallUpdateOnEmojisDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 65,
                column: "Description",
                value: "Polisbil");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 65,
                column: "Description",
                value: "Polis");
        }
    }
}
