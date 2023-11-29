using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedDefaultUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "623faaa6-95ac-4734-81c2-b504b40a9b84", null, "SystemAdmin", "SystemAdmin" },
                    { "b1b0ea46-75e8-4106-8008-28e461666acf", null, "Admin", "Admin" },
                    { "d1e0cabd-39fd-49f3-9932-0e7b48738291", null, "User", "User" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "90b0139e-200d-47b4-ab90-ae27d532c351", 0, "f9a614a9-6597-4acd-920e-2a1d03686b37", "admin@carrental.com", true, "System", "Admin", false, null, "ADMIN@CARRENTAL.COM", "ADMIN@CARRENTAL.COM", "AQAAAAIAAYagAAAAEGR3Pth5P3ssETZuKQmvXJ08vi+fI0c+UAw6pRa+c9BAftQA/nd4GMx3kzzJgexHIA==", null, false, "1b1ed79d-dcd9-4c41-8f9c-35edeec375f7", false, "admin@carrental.com" });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 29, 22, 0, 49, 370, DateTimeKind.Local).AddTicks(9704), new DateTime(2023, 11, 29, 22, 0, 49, 370, DateTimeKind.Local).AddTicks(9759) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 29, 22, 0, 49, 370, DateTimeKind.Local).AddTicks(9827), new DateTime(2023, 11, 29, 22, 0, 49, 370, DateTimeKind.Local).AddTicks(9829) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 29, 22, 0, 49, 370, DateTimeKind.Local).AddTicks(9833), new DateTime(2023, 11, 29, 22, 0, 49, 370, DateTimeKind.Local).AddTicks(9835) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 29, 22, 0, 49, 371, DateTimeKind.Local).AddTicks(879), new DateTime(2023, 11, 29, 22, 0, 49, 371, DateTimeKind.Local).AddTicks(884) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 29, 22, 0, 49, 371, DateTimeKind.Local).AddTicks(886), new DateTime(2023, 11, 29, 22, 0, 49, 371, DateTimeKind.Local).AddTicks(888) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 29, 22, 0, 49, 371, DateTimeKind.Local).AddTicks(891), new DateTime(2023, 11, 29, 22, 0, 49, 371, DateTimeKind.Local).AddTicks(893) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 29, 22, 0, 49, 371, DateTimeKind.Local).AddTicks(450), new DateTime(2023, 11, 29, 22, 0, 49, 371, DateTimeKind.Local).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 29, 22, 0, 49, 371, DateTimeKind.Local).AddTicks(462), new DateTime(2023, 11, 29, 22, 0, 49, 371, DateTimeKind.Local).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2023, 11, 29, 22, 0, 49, 371, DateTimeKind.Local).AddTicks(466), new DateTime(2023, 11, 29, 22, 0, 49, 371, DateTimeKind.Local).AddTicks(468) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "623faaa6-95ac-4734-81c2-b504b40a9b84", "90b0139e-200d-47b4-ab90-ae27d532c351" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1b0ea46-75e8-4106-8008-28e461666acf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1e0cabd-39fd-49f3-9932-0e7b48738291");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "623faaa6-95ac-4734-81c2-b504b40a9b84", "90b0139e-200d-47b4-ab90-ae27d532c351" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "623faaa6-95ac-4734-81c2-b504b40a9b84");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90b0139e-200d-47b4-ab90-ae27d532c351");

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
    }
}
