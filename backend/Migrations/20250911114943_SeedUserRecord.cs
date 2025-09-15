using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Round",
                table: "Records",
                newName: "LevelId");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AvatarId", "Email", "Level", "PasswordHash", "Username" },
                values: new object[] { 1, 1, "jerry@test.com", 1, "hashedpassword", "jerry" });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "Id", "LevelId", "Rounds", "Time", "UserId" },
                values: new object[] { 1, 1, 12, 45, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Records_LevelId",
                table: "Records",
                column: "LevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Levels_LevelId",
                table: "Records",
                column: "LevelId",
                principalTable: "Levels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Records_Levels_LevelId",
                table: "Records");

            migrationBuilder.DropIndex(
                name: "IX_Records_LevelId",
                table: "Records");

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "LevelId",
                table: "Records",
                newName: "Round");
        }
    }
}
