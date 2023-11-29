using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8e0b7aa1-4dcd-4349-aa13-54b435788eba", null, "User", "User" },
                    { "9044c3c6-9bba-473b-aca3-9311b4506439", null, "SystemAdmin", "SystemAdmin" },
                    { "cf820538-738a-4299-951c-824ac1a9ac23", null, "Admin", "Admin" }
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 29, 21, 43, 54, 833, DateTimeKind.Local).AddTicks(366), new DateTime(2023, 11, 29, 21, 43, 54, 833, DateTimeKind.Local).AddTicks(433) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 29, 21, 43, 54, 833, DateTimeKind.Local).AddTicks(438), new DateTime(2023, 11, 29, 21, 43, 54, 833, DateTimeKind.Local).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 29, 21, 43, 54, 833, DateTimeKind.Local).AddTicks(442), new DateTime(2023, 11, 29, 21, 43, 54, 833, DateTimeKind.Local).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 29, 21, 43, 54, 833, DateTimeKind.Local).AddTicks(1629), new DateTime(2023, 11, 29, 21, 43, 54, 833, DateTimeKind.Local).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 29, 21, 43, 54, 833, DateTimeKind.Local).AddTicks(1637), new DateTime(2023, 11, 29, 21, 43, 54, 833, DateTimeKind.Local).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 29, 21, 43, 54, 833, DateTimeKind.Local).AddTicks(1642), new DateTime(2023, 11, 29, 21, 43, 54, 833, DateTimeKind.Local).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 29, 21, 43, 54, 833, DateTimeKind.Local).AddTicks(1287), new DateTime(2023, 11, 29, 21, 43, 54, 833, DateTimeKind.Local).AddTicks(1293) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 29, 21, 43, 54, 833, DateTimeKind.Local).AddTicks(1296), new DateTime(2023, 11, 29, 21, 43, 54, 833, DateTimeKind.Local).AddTicks(1298) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 29, 21, 43, 54, 833, DateTimeKind.Local).AddTicks(1301), new DateTime(2023, 11, 29, 21, 43, 54, 833, DateTimeKind.Local).AddTicks(1302) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e0b7aa1-4dcd-4349-aa13-54b435788eba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9044c3c6-9bba-473b-aca3-9311b4506439");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf820538-738a-4299-951c-824ac1a9ac23");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(5495), new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(5547), new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(5549) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(5552), new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(5554) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(6497), new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(6503) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(6506), new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(6508) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(6510), new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(6512) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(6075), new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(6090), new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(6095), new DateTime(2023, 11, 29, 21, 39, 21, 611, DateTimeKind.Local).AddTicks(6097) });
        }
    }
}
