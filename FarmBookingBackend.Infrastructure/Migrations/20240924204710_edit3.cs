using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FarmBookingBackend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class edit3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "870149f3-ba99-411b-8d6b-4261e17b1701");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b36a364a-9288-4be6-b027-a9578056cfa1");

            migrationBuilder.DropColumn(
                name: "IsPaymentSuccessful",
                table: "Bookings");

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 23, 47, 7, 768, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 23, 47, 7, 768, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 23, 47, 7, 768, DateTimeKind.Local).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 23, 47, 7, 768, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 23, 47, 7, 768, DateTimeKind.Local).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 23, 47, 7, 768, DateTimeKind.Local).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 23, 47, 7, 768, DateTimeKind.Local).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 23, 47, 7, 768, DateTimeKind.Local).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 23, 47, 7, 768, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "295d2927-8493-484e-bee4-564a7ac6fa94", null, "customer", "CUSTOMER" },
                    { "f0770f0f-54bf-4f7d-a84b-1a8b07dffc1a", null, "admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 101,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 23, 47, 7, 768, DateTimeKind.Local).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 102,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 23, 47, 7, 768, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 103,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 23, 47, 7, 768, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 104,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 23, 47, 7, 768, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 201,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 23, 47, 7, 768, DateTimeKind.Local).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 202,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 23, 47, 7, 768, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 203,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 23, 47, 7, 768, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 301,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 23, 47, 7, 768, DateTimeKind.Local).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 302,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 23, 47, 7, 768, DateTimeKind.Local).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "Farms",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 23, 47, 7, 768, DateTimeKind.Local).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "Farms",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 23, 47, 7, 768, DateTimeKind.Local).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "Farms",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 23, 47, 7, 768, DateTimeKind.Local).AddTicks(3440));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "295d2927-8493-484e-bee4-564a7ac6fa94");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0770f0f-54bf-4f7d-a84b-1a8b07dffc1a");

            migrationBuilder.AddColumn<bool>(
                name: "IsPaymentSuccessful",
                table: "Bookings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created_Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created_Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created_Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created_Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created_Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 11,
                column: "Created_Date",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "870149f3-ba99-411b-8d6b-4261e17b1701", null, "customer", "CUSTOMER" },
                    { "b36a364a-9288-4be6-b027-a9578056cfa1", null, "admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 101,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 22, 37, 0, 381, DateTimeKind.Local).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 102,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 22, 37, 0, 381, DateTimeKind.Local).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 103,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 22, 37, 0, 381, DateTimeKind.Local).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 104,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 22, 37, 0, 381, DateTimeKind.Local).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 201,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 22, 37, 0, 381, DateTimeKind.Local).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 202,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 22, 37, 0, 381, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 203,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 22, 37, 0, 381, DateTimeKind.Local).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 301,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 22, 37, 0, 381, DateTimeKind.Local).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 302,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 22, 37, 0, 381, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "Farms",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 22, 37, 0, 380, DateTimeKind.Local).AddTicks(9979));

            migrationBuilder.UpdateData(
                table: "Farms",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 22, 37, 0, 381, DateTimeKind.Local).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "Farms",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 22, 37, 0, 381, DateTimeKind.Local).AddTicks(15));
        }
    }
}
