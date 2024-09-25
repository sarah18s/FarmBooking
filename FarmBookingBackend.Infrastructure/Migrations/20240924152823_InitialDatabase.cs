using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FarmBookingBackend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73820363-480e-443c-866d-cf8b44129328");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f44d25c-9335-4e68-909e-efc977c27a44");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "156bf035-cbd2-4790-89c3-31d2e1be2e62", null, "customer", "CUSTOMER" },
                    { "dc88183a-1e3f-453e-9e12-0330729396ec", null, "admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 101,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 18, 28, 22, 804, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 102,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 18, 28, 22, 804, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 103,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 18, 28, 22, 804, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 104,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 18, 28, 22, 804, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 201,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 18, 28, 22, 804, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 202,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 18, 28, 22, 804, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 203,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 18, 28, 22, 804, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 301,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 18, 28, 22, 804, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 302,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 18, 28, 22, 804, DateTimeKind.Local).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "Farms",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 18, 28, 22, 804, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "Farms",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 18, 28, 22, 804, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "Farms",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 18, 28, 22, 804, DateTimeKind.Local).AddTicks(2692));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "156bf035-cbd2-4790-89c3-31d2e1be2e62");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc88183a-1e3f-453e-9e12-0330729396ec");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "73820363-480e-443c-866d-cf8b44129328", null, "customer", "CUSTOMER" },
                    { "9f44d25c-9335-4e68-909e-efc977c27a44", null, "admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 101,
                column: "Created_Date",
                value: new DateTime(2024, 9, 22, 17, 56, 35, 121, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 102,
                column: "Created_Date",
                value: new DateTime(2024, 9, 22, 17, 56, 35, 121, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 103,
                column: "Created_Date",
                value: new DateTime(2024, 9, 22, 17, 56, 35, 121, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 104,
                column: "Created_Date",
                value: new DateTime(2024, 9, 22, 17, 56, 35, 121, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 201,
                column: "Created_Date",
                value: new DateTime(2024, 9, 22, 17, 56, 35, 121, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 202,
                column: "Created_Date",
                value: new DateTime(2024, 9, 22, 17, 56, 35, 121, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 203,
                column: "Created_Date",
                value: new DateTime(2024, 9, 22, 17, 56, 35, 121, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 301,
                column: "Created_Date",
                value: new DateTime(2024, 9, 22, 17, 56, 35, 121, DateTimeKind.Local).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 302,
                column: "Created_Date",
                value: new DateTime(2024, 9, 22, 17, 56, 35, 121, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Farms",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 9, 22, 17, 56, 35, 121, DateTimeKind.Local).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "Farms",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 9, 22, 17, 56, 35, 121, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "Farms",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 9, 22, 17, 56, 35, 121, DateTimeKind.Local).AddTicks(4386));
        }
    }
}
