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
                    { 1315L, 650, -240, "Temperature", 390f },
                    { 1623L, 100, 0, "Humidity", 45f },
                    { 1645L, 650, -240, "Temperature", 404f },
                    { 1736L, 650, -240, "Temperature", 200f },
                    { 1755L, 100, 0, "Humidity", 48f },
                    { 2068L, 650, -240, "Temperature", 108f },
                    { 2287L, 100, 0, "Humidity", 60f },
                    { 2581L, 650, -240, "Temperature", 186f },
                    { 2830L, 650, -240, "Temperature", 516f },
                    { 2859L, 650, -240, "Temperature", 395f },
                    { 3021L, 100, 0, "Humidity", 72f },
                    { 3191L, 1000000, 0, "Light", 648391f },
                    { 3900L, 100, 0, "Humidity", 48f },
                    { 4503L, 650, -240, "Temperature", -91f },
                    { 4693L, 1000000, 0, "Light", 166084f },
                    { 5002L, 100, 0, "Humidity", 54f },
                    { 5049L, 100, 0, "Humidity", 65f },
                    { 5155L, 650, -240, "Temperature", 385f },
                    { 5655L, 650, -240, "Temperature", 44f },
                    { 5773L, 1000000, 0, "Light", 458732f },
                    { 5855L, 650, -240, "Temperature", 593f },
                    { 5916L, 100, 0, "Humidity", 53f },
                    { 6199L, 1000000, 0, "Light", 123642f },
                    { 6218L, 1000000, 0, "Light", 817381f },
                    { 6829L, 650, -240, "Temperature", 182f },
                    { 6863L, 1000000, 0, "Light", 300262f },
                    { 7050L, 100, 0, "Humidity", 44f },
                    { 7177L, 100, 0, "Humidity", 15f },
                    { 7275L, 1000000, 0, "Light", 313963f },
                    { 7415L, 1000000, 0, "Light", 898567f },
                    { 7472L, 1000000, 0, "Light", 26370f },
                    { 7676L, 1000000, 0, "Light", 603670f },
                    { 7701L, 100, 0, "Humidity", 58f },
                    { 7976L, 100, 0, "Humidity", 10f },
                    { 8060L, 100, 0, "Humidity", 97f },
                    { 8099L, 1000000, 0, "Light", 533453f },
                    { 8179L, 1000000, 0, "Light", 4464f },
                    { 8248L, 650, -240, "Temperature", 633f },
                    { 8352L, 1000000, 0, "Light", 919611f },
                    { 8688L, 1000000, 0, "Light", 193326f },
                    { 8837L, 650, -240, "Temperature", 87f },
                    { 8947L, 650, -240, "Temperature", -56f },
                    { 9129L, 1000000, 0, "Light", 664018f },
                    { 9136L, 650, -240, "Temperature", 7f },
                    { 9450L, 1000000, 0, "Light", 807216f },
                    { 9559L, 650, -240, "Temperature", 170f },
                    { 9694L, 100, 0, "Humidity", 32f },
                    { 9750L, 650, -240, "Temperature", 464f },
                    { 9810L, 100, 0, "Humidity", 90f },
                    { 9918L, 650, -240, "Temperature", -225f }
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
