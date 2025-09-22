using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class AnotherUpdateOnEmojisAndLevels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Hund", "🐶" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Katt", "🐱" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Mus", "🐭" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Kanin", "🐰" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Räv", "🦊" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Björn", "🐻" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Panda", "🐼" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Koala", "🐨" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Lejon", "🦁" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Ko", "🐮" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Gris", "🐷" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Groda", "🐸" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Apa", "🐵" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Enhörning", "🦄" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Kyckling", "🐔" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Äpple", "🍎" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Pizza", "🍕" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Hamburgare", "🍔" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Glass", "🍦" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Munk", "🍩" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Vattenmelon", "🍉" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Pommes", "🍟" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Tårta", "🍰" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Choklad", "🍫" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Öl", "🍺" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Te", "🍵" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Popcorn", "🍿" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Aubergine", "🍆" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Jordgubb", "🍓" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Persika", "🍑" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Fotboll", "⚽" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Basket", "🏀" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Rugby", "🏈" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Tennis", "🎾" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Pingis", "🏓" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Badminton", "🏸" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Simning", "🏊" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Cykling", "🚴" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Klättring", "🧗" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Surfing", "🏄" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Snowboard", "🏂" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Hockey", "🏒" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Boxning", "🥊" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Gymnastik", "🤸" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Handboll", "🤾" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Läkare", "👨‍⚕️" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Lärare", "👩‍🏫" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Kock", "👨‍🍳" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Mekaniker", "👩‍🔧" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Brandman", "👨‍🚒" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Pilot", "👩‍✈️" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Domare", "👨‍⚖️" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Konstnär", "👩‍🎨" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Forskare", "👨‍🔬" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Programmerare", "👩‍💻" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Svetsare", "👨‍🏭" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Astronaut", "👩‍🚀" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Artist", "👨‍🎤" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Bonde", "👩‍🌾" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Polis", "👮" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Bil", "🚗" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Taxi", "🚕" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Buss", "🚌" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Spårvagn", "🚎" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Polis", "🚓" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Ambulans", "🚑" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Brandbil", "🚒" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Van", "🚐" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Lastbil", "🚚" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Cykel", "🚲" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Sparkcykel", "🛴" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Moped", "🛵" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Motorcykel", "🏍️" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Tåg", "🚂" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Flygplan", "✈️" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Sol", "🌞" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Regn", "🌧️" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Oväder", "⛈️" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Regnbåge", "🌈" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Tornado", "🌪️" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Solros", "🌻" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Träd", "🌳" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Gran", "🌲" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Kaktus", "🌵" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Palm", "🌴" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Blomma", "🌸" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Måne", "🌙" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Löv", "🍂" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Fjäril", "🦋" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Snö", "❄️" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Arena", "🏟️" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Villa", "🏡" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Strand", "🏖️" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Ö", "🏝️" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Station", "🏤" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Sjukhus", "🏥" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Bank", "🏦" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Hotell", "🏨" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Park", "🏞️" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Butik", "🏪" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Skola", "🏫" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Köpcenter", "🏬" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Fabrik", "🏭" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Tempel", "🏯" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Slott", "🏰" });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Glad", "🙂" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Ledsen", "😢" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Arg", "😠" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Kär", "😍" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Förvånad", "😮" });

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
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Entusiastisk", "😃" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Förvirrad", "😕" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Nervös", "😅" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Lugn", "😌" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Rädd", "😱" });

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

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Björn", "🐻" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Panda", "🐼" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Koala", "🐨" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Lejon", "🦁" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Ko", "🐮" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Gris", "🐷" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Groda", "🐸" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Apa", "🐵" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Enhörning", "🦄" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Kyckling", "🐔" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Blinkar", "😉" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Flinar", "😏" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Oseriös", "🙃" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Tänker", "🤔" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Njuter", "😋" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Busig", "😜" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Fnissar", "🤭" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Skämtar", "😛" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Cool", "😎" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Skrattar", "😂" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Imponerad", "🤩" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Rörd", "🥹" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Dreglar", "🤤" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Smälter", "🫠" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Kräks", "🤮" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Äpple", "🍎" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Pizza", "🍕" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Hamburgare", "🍔" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Glass", "🍦" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Munk", "🍩" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Vattenmelon", "🍉" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Pommes", "🍟" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Tårta", "🍰" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Choklad", "🍫" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Öl", "🍺" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Te", "🍵" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Popcorn", "🍿" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Aubergine", "🍆" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Jordgubb", "🍓" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Persika", "🍑" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Fotboll", "⚽" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Basket", "🏀" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Rugby", "🏈" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Tennis", "🎾" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Pingis", "🏓" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Badminton", "🏸" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Simning", "🏊" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Cykling", "🚴" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Klättring", "🧗" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Surfing", "🏄" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Snowboard", "🏂" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Hockey", "🏒" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Boxning", "🥊" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Gymnastik", "🤸" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Handboll", "🤾" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Läkare", "👨‍⚕️" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Lärare", "👩‍🏫" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Kock", "👨‍🍳" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Mekaniker", "👩‍🔧" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Brandman", "👨‍🚒" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Pilot", "👩‍✈️" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Domare", "👨‍⚖️" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Konstnär", "👩‍🎨" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Forskare", "👨‍🔬" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Programmerare", "👩‍💻" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Svetsare", "👨‍🏭" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Astronaut", "👩‍🚀" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Artist", "👨‍🎤" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Bonde", "👩‍🌾" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Polis", "👮" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Bil", "🚗" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Taxi", "🚕" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Buss", "🚌" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Spårvagn", "🚎" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Polis", "🚓" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Ambulans", "🚑" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Brandbil", "🚒" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Van", "🚐" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Lastbil", "🚚" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Cykel", "🚲" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Sparkcykel", "🛴" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Moped", "🛵" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Motorcykel", "🏍️" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Tåg", "🚂" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Flygplan", "✈️" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Sol", "🌞" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Regn", "🌧️" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Oväder", "⛈️" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Regnbåge", "🌈" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Tornado", "🌪️" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Solros", "🌻" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Träd", "🌳" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Gran", "🌲" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Kaktus", "🌵" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Palm", "🌴" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Blomma", "🌸" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Måne", "🌙" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Löv", "🍂" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Fjäril", "🦋" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Snö", "❄️" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Arena", "🏟️" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Villa", "🏡" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Strand", "🏖️" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Ö", "🏝️" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Station", "🏤" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Sjukhus", "🏥" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Bank", "🏦" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Hotell", "🏨" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Park", "🏞️" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Butik", "🏪" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Skola", "🏫" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Köpcenter", "🏬" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Fabrik", "🏭" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Tempel", "🏯" });

            migrationBuilder.UpdateData(
                table: "Emojis",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Description", "Symbol" },
                values: new object[] { "Slott", "🏰" });
        }
    }
}
