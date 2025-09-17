using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class FullEmojiList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Spänd", "😬" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Chockad", "😲" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Frustrerad", "😤" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Ilska", "😡" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Nöjd", "😊" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "LevelId", "Symbol" },
                values: new object[] { "Entusiastisk", 1, "😃" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "LevelId", "Symbol" },
                values: new object[] { "Förvirrad", 1, "😕" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "LevelId", "Symbol" },
                values: new object[] { "Nervös", 1, "😅" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "LevelId", "Symbol" },
                values: new object[] { "Lugn", 1, "😌" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "LevelId", "Symbol" },
                values: new object[] { "Rädd", 1, "😱" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Hund", "🐶" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Katt", "🐱" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Mus", "🐭" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Kanin", "🐰" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Räv", "🦊" });

            migrationBuilder.InsertData(
                table: "Emojis",
                columns: new[] { "Id", "Description", "LevelId", "Symbol" },
                values: new object[,]
                {
                    { 21, "Björn", 2, "🐻" },
                    { 22, "Panda", 2, "🐼" },
                    { 23, "Koala", 2, "🐨" },
                    { 24, "Lejon", 2, "🦁" },
                    { 25, "Ko", 2, "🐮" },
                    { 26, "Gris", 2, "🐷" },
                    { 27, "Groda", 2, "🐸" },
                    { 28, "Apa", 2, "🐵" },
                    { 29, "Enhörning", 2, "🦄" },
                    { 30, "Kyckling", 2, "🐔" },
                    { 31, "Blinkar", 3, "😉" },
                    { 32, "Flinar", 3, "😏" },
                    { 33, "Oseriös", 3, "🙃" },
                    { 34, "Tänker", 3, "🤔" },
                    { 35, "Njuter", 3, "😋" },
                    { 36, "Busig", 3, "😜" },
                    { 37, "Fnissar", 3, "🤭" },
                    { 38, "Skämtar", 3, "😛" },
                    { 39, "Cool", 3, "😎" },
                    { 40, "Skrattar", 3, "😂" },
                    { 41, "Imponerad", 3, "🤩" },
                    { 42, "Rörd", 3, "🥹" },
                    { 43, "Dreglar", 3, "🤤" },
                    { 44, "Smälter", 3, "🫠" },
                    { 45, "Kräks", 3, "🤮" },
                    { 46, "Äpple", 4, "🍎" },
                    { 47, "Pizza", 4, "🍕" },
                    { 48, "Hamburgare", 4, "🍔" },
                    { 49, "Glass", 4, "🍦" },
                    { 50, "Munk", 4, "🍩" },
                    { 51, "Vattenmelon", 4, "🍉" },
                    { 52, "Pommes", 4, "🍟" },
                    { 53, "Tårta", 4, "🍰" },
                    { 54, "Choklad", 4, "🍫" },
                    { 55, "Öl", 4, "🍺" },
                    { 56, "Te", 4, "🍵" },
                    { 57, "Popcorn", 4, "🍿" },
                    { 58, "Aubergine", 4, "🍆" },
                    { 59, "Jordgubb", 4, "🍓" },
                    { 60, "Persika", 4, "🍑" },
                    { 61, "Fotboll", 5, "⚽" },
                    { 62, "Basket", 5, "🏀" },
                    { 63, "Rugby", 5, "🏈" },
                    { 64, "Tennis", 5, "🎾" },
                    { 65, "Pingis", 5, "🏓" },
                    { 66, "Badminton", 5, "🏸" },
                    { 67, "Simning", 5, "🏊" },
                    { 68, "Cykling", 5, "🚴" },
                    { 69, "Klättring", 5, "🧗" },
                    { 70, "Surfing", 5, "🏄" },
                    { 71, "Snowboard", 5, "🏂" },
                    { 72, "Hockey", 5, "🏒" },
                    { 73, "Boxning", 5, "🥊" },
                    { 74, "Gymnastik", 5, "🤸" },
                    { 75, "Handboll", 5, "🤾" },
                    { 76, "Läkare", 6, "👨‍⚕️" },
                    { 77, "Lärare", 6, "👩‍🏫" },
                    { 78, "Kock", 6, "👨‍🍳" },
                    { 79, "Mekaniker", 6, "👩‍🔧" },
                    { 80, "Brandman", 6, "👨‍🚒" },
                    { 81, "Pilot", 6, "👩‍✈️" },
                    { 82, "Domare", 6, "👨‍⚖️" },
                    { 83, "Konstnär", 6, "👩‍🎨" },
                    { 84, "Forskare", 6, "👨‍🔬" },
                    { 85, "Programmerare", 6, "👩‍💻" },
                    { 86, "Svetsare", 6, "👨‍🏭" },
                    { 87, "Astronaut", 6, "👩‍🚀" },
                    { 88, "Artist", 6, "👨‍🎤" },
                    { 89, "Bonde", 6, "👩‍🌾" },
                    { 90, "Polis", 6, "👮" },
                    { 91, "Bil", 7, "🚗" },
                    { 92, "Taxi", 7, "🚕" },
                    { 93, "Buss", 7, "🚌" },
                    { 94, "Spårvagn", 7, "🚎" },
                    { 95, "Polis", 7, "🚓" },
                    { 96, "Ambulans", 7, "🚑" },
                    { 97, "Brandbil", 7, "🚒" },
                    { 98, "Van", 7, "🚐" },
                    { 99, "Lastbil", 7, "🚚" },
                    { 100, "Cykel", 7, "🚲" },
                    { 101, "Sparkcykel", 7, "🛴" },
                    { 102, "Moped", 7, "🛵" },
                    { 103, "Motorcykel", 7, "🏍️" },
                    { 104, "Tåg", 7, "🚂" },
                    { 105, "Flygplan", 7, "✈️" },
                    { 106, "Sol", 8, "🌞" },
                    { 107, "Regn", 8, "🌧️" },
                    { 108, "Oväder", 8, "⛈️" },
                    { 109, "Regnbåge", 8, "🌈" },
                    { 110, "Tornado", 8, "🌪️" },
                    { 111, "Solros", 8, "🌻" },
                    { 112, "Träd", 8, "🌳" },
                    { 113, "Gran", 8, "🌲" },
                    { 114, "Kaktus", 8, "🌵" },
                    { 115, "Palm", 8, "🌴" },
                    { 116, "Blomma", 8, "🌸" },
                    { 117, "Måne", 8, "🌙" },
                    { 118, "Löv", 8, "🍂" },
                    { 119, "Fjäril", 8, "🦋" },
                    { 120, "Snö", 8, "❄️" },
                    { 121, "Arena", 9, "🏟️" },
                    { 122, "Villa", 9, "🏡" },
                    { 123, "Strand", 9, "🏖️" },
                    { 124, "Ö", 9, "🏝️" },
                    { 125, "Station", 9, "🏤" },
                    { 126, "Sjukhus", 9, "🏥" },
                    { 127, "Bank", 9, "🏦" },
                    { 128, "Hotell", 9, "🏨" },
                    { 129, "Park", 9, "🏞️" },
                    { 130, "Butik", 9, "🏪" },
                    { 131, "Skola", 9, "🏫" },
                    { 132, "Köpcenter", 9, "🏬" },
                    { 133, "Fabrik", 9, "🏭" },
                    { 134, "Tempel", 9, "🏯" },
                    { 135, "Slott", 9, "🏰" },
                    { 136, "Hjärta", 10, "❤️" },
                    { 137, "Brusten", 10, "💔" },
                    { 138, "Stjärna", 10, "⭐" },
                    { 139, "Glans", 10, "✨" },
                    { 140, "Blixt", 10, "⚡" },
                    { 141, "Eld", 10, "🔥" },
                    { 142, "Droppe", 10, "💧" },
                    { 143, "Utrop", 10, "❗" },
                    { 144, "Fråga", 10, "❓" },
                    { 145, "Klar", 10, "✅" },
                    { 146, "Fel", 10, "❌" },
                    { 147, "Plus", 10, "➕" },
                    { 148, "Minus", 10, "➖" },
                    { 149, "Division", 10, "➗" },
                    { 150, "Triangel", 10, "🔺" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Blinkar", "😉" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Cool", "😎" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Skrattar", "😂" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Snäll", "😇" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Sover", "😴" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "LevelId", "Symbol" },
                values: new object[] { "Nöjd", 2, "😊" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "LevelId", "Symbol" },
                values: new object[] { "Tänker", 2, "🤔" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "LevelId", "Symbol" },
                values: new object[] { "Entusiastisk", 2, "😃" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "LevelId", "Symbol" },
                values: new object[] { "Förvirrad", 2, "😕" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "LevelId", "Symbol" },
                values: new object[] { "Nervös", 2, "😅" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Upp och ner", "🙃" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Lugn", "😌" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Kram", "🤗" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Gott", "😋" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Flinar", "😏" });
        }
    }
}
