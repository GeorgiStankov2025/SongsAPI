using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SongsAPI.Migrations
{
    /// <inheritdoc />
    public partial class Feeding2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Genre", "Name", "Singer" },
                values: new object[,]
                {
                    { 2, "Pop", "Bad Blood", "Taylor Swift" },
                    { 3, "Classic", "The show must go on", "Fredy Mercury with Queen" },
                    { 4, "Russian folk", "Prince Igor", "Natasha Morozova" },
                    { 5, "Italian pop", "Next Summer", "Damiano David" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
