using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FarmBookingBackend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class edit1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "72c221d9-59f6-4a52-ae0f-21cba7c319b4", null, "admin", "ADMIN" },
                    { "bff08c94-358b-4596-8fe0-32c3a484f5d2", null, "customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 101,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 21, 12, 55, 341, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 102,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 21, 12, 55, 341, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 103,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 21, 12, 55, 341, DateTimeKind.Local).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 104,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 21, 12, 55, 341, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 201,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 21, 12, 55, 341, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 202,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 21, 12, 55, 341, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 203,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 21, 12, 55, 341, DateTimeKind.Local).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 301,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 21, 12, 55, 341, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 302,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 21, 12, 55, 341, DateTimeKind.Local).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "Farms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_Date", "ImageUrl" },
                values: new object[] { new DateTime(2024, 9, 24, 21, 12, 55, 341, DateTimeKind.Local).AddTicks(9607), "C:\\Users\\Lenovo\\Desktop\\CV Projects\\FarmBookingFB\\FarmBookingBackend\\FarmBookingBackend.Web\\images\\VillaImage\\a78075cc-2905-4471-a578-1d5fe3945fcd.jpg" });

            migrationBuilder.UpdateData(
                table: "Farms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_Date", "ImageUrl" },
                values: new object[] { new DateTime(2024, 9, 24, 21, 12, 55, 341, DateTimeKind.Local).AddTicks(9650), "C:\\Users\\Lenovo\\Desktop\\CV Projects\\FarmBookingFB\\FarmBookingBackend\\FarmBookingBackend.Web\\images\\VillaImage\\cac7e1b4-5ba4-493f-9b73-14434d5b56d7.jpg" });

            migrationBuilder.UpdateData(
                table: "Farms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_Date", "ImageUrl" },
                values: new object[] { new DateTime(2024, 9, 24, 21, 12, 55, 341, DateTimeKind.Local).AddTicks(9658), "C:\\Users\\Lenovo\\Desktop\\CV Projects\\FarmBookingFB\\FarmBookingBackend\\FarmBookingBackend.Web\\images\\VillaImage\\d75cb0ad-9ed1-46af-87bc-fa99e00b2e58.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72c221d9-59f6-4a52-ae0f-21cba7c319b4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bff08c94-358b-4596-8fe0-32c3a484f5d2");

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
                columns: new[] { "Created_Date", "ImageUrl" },
                values: new object[] { new DateTime(2024, 9, 24, 20, 38, 27, 376, DateTimeKind.Local).AddTicks(7959), "C:\\Users\\Lenovo\\Desktop\\CV Projects\\FarmBookingFB\\FarmBookingBackend\\FarmBookingBackend.Web\\images\\FarmImage\\a78075cc-2905-4471-a578-1d5fe3945fcd.jpg" });

            migrationBuilder.UpdateData(
                table: "Farms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_Date", "ImageUrl" },
                values: new object[] { new DateTime(2024, 9, 24, 20, 38, 27, 376, DateTimeKind.Local).AddTicks(8012), "C:\\Users\\Lenovo\\Desktop\\CV Projects\\FarmBookingFB\\FarmBookingBackend\\FarmBookingBackend.Web\\images\\FarmImage\\cac7e1b4-5ba4-493f-9b73-14434d5b56d7.jpg" });

            migrationBuilder.UpdateData(
                table: "Farms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_Date", "ImageUrl" },
                values: new object[] { new DateTime(2024, 9, 24, 20, 38, 27, 376, DateTimeKind.Local).AddTicks(8017), "C:\\Users\\Lenovo\\Desktop\\CV Projects\\FarmBookingFB\\FarmBookingBackend\\FarmBookingBackend.Web\\images\\FarmImage\\d75cb0ad-9ed1-46af-87bc-fa99e00b2e58.jpg" });
        }
    }
}
