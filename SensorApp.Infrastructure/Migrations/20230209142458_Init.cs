using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SensorApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sensors",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SensorType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RangeStart = table.Column<int>(type: "int", nullable: false),
                    RangeEnd = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sensors", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Sensors",
                columns: new[] { "Id", "RangeEnd", "RangeStart", "SensorType", "Value" },
                values: new object[,]
                {
                    { 1L, 1000000, 0, "Light", 608355f },
                    { 2L, 650, -240, "Temperature", 345f },
                    { 3L, 100, 0, "Humidity", 85f },
                    { 4L, 100, 0, "Humidity", 62f },
                    { 5L, 100, 0, "Humidity", 96f },
                    { 6L, 650, -240, "Temperature", -163f },
                    { 7L, 1000000, 0, "Light", 992379f },
                    { 8L, 100, 0, "Humidity", 6f },
                    { 9L, 650, -240, "Temperature", 12f },
                    { 10L, 100, 0, "Humidity", 81f },
                    { 11L, 100, 0, "Humidity", 58f },
                    { 12L, 100, 0, "Humidity", 74f },
                    { 13L, 650, -240, "Temperature", 459f },
                    { 14L, 100, 0, "Humidity", 97f },
                    { 15L, 650, -240, "Temperature", 565f },
                    { 16L, 100, 0, "Humidity", 58f },
                    { 17L, 100, 0, "Humidity", 33f },
                    { 18L, 1000000, 0, "Light", 707947f },
                    { 19L, 1000000, 0, "Light", 263455f },
                    { 20L, 100, 0, "Humidity", 81f },
                    { 21L, 650, -240, "Temperature", -120f },
                    { 22L, 1000000, 0, "Light", 50735f },
                    { 23L, 100, 0, "Humidity", 63f },
                    { 24L, 100, 0, "Humidity", 39f },
                    { 25L, 100, 0, "Humidity", 41f },
                    { 26L, 100, 0, "Humidity", 60f },
                    { 27L, 100, 0, "Humidity", 12f },
                    { 28L, 1000000, 0, "Light", 418980f },
                    { 29L, 100, 0, "Humidity", 22f },
                    { 30L, 650, -240, "Temperature", 254f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sensors");
        }
    }
}
