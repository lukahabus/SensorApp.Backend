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
                    { 1107L, 1000000, 0, "Light", 314554f },
                    { 1227L, 1000000, 0, "Light", 920220f },
                    { 1302L, 100, 0, "Humidity", 68f },
                    { 1396L, 100, 0, "Humidity", 71f },
                    { 1421L, 100, 0, "Humidity", 89f },
                    { 1526L, 1000000, 0, "Light", 402113f },
                    { 1591L, 650, -240, "Temperature", 21f },
                    { 1638L, 1000000, 0, "Light", 599353f },
                    { 1889L, 100, 0, "Humidity", 90f },
                    { 1991L, 1000000, 0, "Light", 444195f },
                    { 2043L, 100, 0, "Humidity", 82f },
                    { 2223L, 1000000, 0, "Light", 714229f },
                    { 2596L, 650, -240, "Temperature", 260f },
                    { 2666L, 650, -240, "Temperature", -96f },
                    { 2908L, 100, 0, "Humidity", 57f },
                    { 2994L, 100, 0, "Humidity", 91f },
                    { 4096L, 1000000, 0, "Light", 859618f },
                    { 4411L, 1000000, 0, "Light", 766701f },
                    { 4776L, 1000000, 0, "Light", 967743f },
                    { 5179L, 650, -240, "Temperature", -195f },
                    { 5287L, 1000000, 0, "Light", 898754f },
                    { 5315L, 1000000, 0, "Light", 311194f },
                    { 5697L, 650, -240, "Temperature", 145f },
                    { 5896L, 1000000, 0, "Light", 772492f },
                    { 5953L, 100, 0, "Humidity", 21f },
                    { 6146L, 100, 0, "Humidity", 9f },
                    { 6258L, 100, 0, "Humidity", 0f },
                    { 6643L, 1000000, 0, "Light", 519022f },
                    { 6662L, 1000000, 0, "Light", 435698f },
                    { 6740L, 1000000, 0, "Light", 413739f },
                    { 6922L, 100, 0, "Humidity", 39f },
                    { 7044L, 650, -240, "Temperature", -76f },
                    { 7196L, 650, -240, "Temperature", 621f },
                    { 7498L, 1000000, 0, "Light", 656384f },
                    { 7565L, 1000000, 0, "Light", 254401f },
                    { 7682L, 1000000, 0, "Light", 570066f },
                    { 8087L, 650, -240, "Temperature", -90f },
                    { 8147L, 650, -240, "Temperature", 41f },
                    { 8255L, 1000000, 0, "Light", 786735f },
                    { 8711L, 1000000, 0, "Light", 913081f },
                    { 8742L, 650, -240, "Temperature", 173f },
                    { 8768L, 100, 0, "Humidity", 5f },
                    { 8843L, 100, 0, "Humidity", 51f },
                    { 9027L, 100, 0, "Humidity", 26f },
                    { 9032L, 1000000, 0, "Light", 728076f },
                    { 9312L, 650, -240, "Temperature", -197f },
                    { 9646L, 1000000, 0, "Light", 52203f },
                    { 9683L, 100, 0, "Humidity", 59f },
                    { 9691L, 650, -240, "Temperature", -192f },
                    { 9707L, 650, -240, "Temperature", 21f }
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
