using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FarmBookingBackend.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class edit2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72c221d9-59f6-4a52-ae0f-21cba7c319b4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bff08c94-358b-4596-8fe0-32c3a484f5d2");

            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "FarmRooms");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "FarmRooms");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "870149f3-ba99-411b-8d6b-4261e17b1701");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b36a364a-9288-4be6-b027-a9578056cfa1");

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "FarmRooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "FarmRooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "Created_Date", "IsAvailable", "IsDelete" },
                values: new object[] { new DateTime(2024, 9, 24, 21, 12, 55, 341, DateTimeKind.Local).AddTicks(9771), true, false });

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 102,
                columns: new[] { "Created_Date", "IsAvailable", "IsDelete" },
                values: new object[] { new DateTime(2024, 9, 24, 21, 12, 55, 341, DateTimeKind.Local).AddTicks(9780), true, false });

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 103,
                columns: new[] { "Created_Date", "IsAvailable", "IsDelete" },
                values: new object[] { new DateTime(2024, 9, 24, 21, 12, 55, 341, DateTimeKind.Local).AddTicks(9784), true, false });

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 104,
                columns: new[] { "Created_Date", "IsAvailable", "IsDelete" },
                values: new object[] { new DateTime(2024, 9, 24, 21, 12, 55, 341, DateTimeKind.Local).AddTicks(9788), true, false });

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 201,
                columns: new[] { "Created_Date", "IsAvailable", "IsDelete" },
                values: new object[] { new DateTime(2024, 9, 24, 21, 12, 55, 341, DateTimeKind.Local).AddTicks(9792), true, false });

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 202,
                columns: new[] { "Created_Date", "IsAvailable", "IsDelete" },
                values: new object[] { new DateTime(2024, 9, 24, 21, 12, 55, 341, DateTimeKind.Local).AddTicks(9796), true, false });

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 203,
                columns: new[] { "Created_Date", "IsAvailable", "IsDelete" },
                values: new object[] { new DateTime(2024, 9, 24, 21, 12, 55, 341, DateTimeKind.Local).AddTicks(9800), true, false });

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 301,
                columns: new[] { "Created_Date", "IsAvailable", "IsDelete" },
                values: new object[] { new DateTime(2024, 9, 24, 21, 12, 55, 341, DateTimeKind.Local).AddTicks(9804), true, false });

            migrationBuilder.UpdateData(
                table: "FarmRooms",
                keyColumn: "FarmRoom_Number",
                keyValue: 302,
                columns: new[] { "Created_Date", "IsAvailable", "IsDelete" },
                values: new object[] { new DateTime(2024, 9, 24, 21, 12, 55, 341, DateTimeKind.Local).AddTicks(9807), true, false });

            migrationBuilder.UpdateData(
                table: "Farms",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 21, 12, 55, 341, DateTimeKind.Local).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "Farms",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 21, 12, 55, 341, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Farms",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created_Date",
                value: new DateTime(2024, 9, 24, 21, 12, 55, 341, DateTimeKind.Local).AddTicks(9658));
        }
    }
}
