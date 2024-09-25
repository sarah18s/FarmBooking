using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FarmBookingBackend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class edit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "5d4b67f4-f943-4f61-bc6f-a60ad7076eba", null, "admin", "ADMIN" },
                    { "6ff595b7-a70f-4a48-bed5-b6383e40b671", null, "customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 101,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 20, 38, 27, 376, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 102,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 20, 38, 27, 376, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 103,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 20, 38, 27, 376, DateTimeKind.Local).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 104,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 20, 38, 27, 376, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 201,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 20, 38, 27, 376, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 202,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 20, 38, 27, 376, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 203,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 20, 38, 27, 376, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 301,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 20, 38, 27, 376, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 302,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 20, 38, 27, 376, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "Farms",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 20, 38, 27, 376, DateTimeKind.Local).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "Farms",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 20, 38, 27, 376, DateTimeKind.Local).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "Farms",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 20, 38, 27, 376, DateTimeKind.Local).AddTicks(8017));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d4b67f4-f943-4f61-bc6f-a60ad7076eba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ff595b7-a70f-4a48-bed5-b6383e40b671");

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
    }
}
