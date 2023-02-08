using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SensorApp.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Light : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sensors",
                columns: new[] { "Id", "RangeEnd", "RangeStart", "SensorType", "Value" },
                values: new object[] { 3L, 1000000, 0, "Light", 450f });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sensors",
                keyColumn: "Id",
                keyValue: 3L);
        }
    }
}
