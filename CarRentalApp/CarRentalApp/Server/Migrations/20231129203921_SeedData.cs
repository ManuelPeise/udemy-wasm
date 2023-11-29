using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(5495), "System", "Black", new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(5544), "System" },
                    { 2, new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(5547), "System", "Red", new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(5549), "System" },
                    { 3, new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(5552), "System", "Blue", new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(5554), "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(6497), "System", "Audi", new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(6503), "System" },
                    { 2, new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(6506), "System", "Renault", new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(6508), "System" },
                    { 3, new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(6510), "System", "VW", new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(6512), "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(6075), "System", "A4", new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(6081), "System" },
                    { 2, new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(6090), "System", "Cool", new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(6092), "System" },
                    { 3, new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(6095), "System", "Work", new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(6097), "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
