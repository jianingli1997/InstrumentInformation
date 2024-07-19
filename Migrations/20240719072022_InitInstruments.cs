using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InstrumentInformation.Migrations
{
    /// <inheritdoc />
    public partial class InitInstruments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Instruments",
                table: "Instruments");

            migrationBuilder.RenameTable(
                name: "Instruments",
                newName: "instruments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_instruments",
                table: "instruments",
                column: "Id");

            migrationBuilder.InsertData(
                table: "instruments",
                columns: new[] { "Id", "CreatedDatetime", "Description", "ExpiredDatetime", "InstrumentTypeId", "Length", "Name", "SerialNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 19, 15, 20, 22, 147, DateTimeKind.Local).AddTicks(5109), "器械1的描述", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 68, 0.0, "特大号持针钳490", "0002" },
                    { 2, new DateTime(2024, 7, 19, 15, 20, 22, 147, DateTimeKind.Local).AddTicks(5121), "器械1的描述", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 68, 0.0, "特大号持针钳490", "0003" },
                    { 3, new DateTime(2024, 7, 19, 15, 20, 22, 147, DateTimeKind.Local).AddTicks(5122), "器械1的描述", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 68, 0.0, "特大号持针钳490", "0004" },
                    { 4, new DateTime(2024, 7, 19, 15, 20, 22, 147, DateTimeKind.Local).AddTicks(5123), "器械1的描述", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 71, 0.0, "大力抓取钳500", "das12334ss" },
                    { 5, new DateTime(2024, 7, 19, 15, 20, 22, 147, DateTimeKind.Local).AddTicks(5124), "器械1的描述", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 71, 0.0, "大力抓取钳500", "000ds21234432adas4" },
                    { 6, new DateTime(2024, 7, 19, 15, 20, 22, 147, DateTimeKind.Local).AddTicks(5125), "器械1的描述", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 98, 0.0, "超声刀头550", "dsada12deas" },
                    { 7, new DateTime(2024, 7, 19, 15, 20, 22, 147, DateTimeKind.Local).AddTicks(5126), "器械1的描述", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 99, 0.0, "超声刀头510", "45656dadasdas" },
                    { 8, new DateTime(2024, 7, 19, 15, 20, 22, 147, DateTimeKind.Local).AddTicks(5127), "器械1的描述", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 99, 0.0, "超声刀头510", "45656dadasdas" },
                    { 9, new DateTime(2024, 7, 19, 15, 20, 22, 147, DateTimeKind.Local).AddTicks(5128), "器械1的描述", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 99, 0.0, "超声刀头510", "45656dadasdas" },
                    { 10, new DateTime(2024, 7, 19, 15, 20, 22, 147, DateTimeKind.Local).AddTicks(5129), "器械1的描述", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 99, 0.0, "超声刀头510", "45656dadasdas" },
                    { 11, new DateTime(2024, 7, 19, 15, 20, 22, 147, DateTimeKind.Local).AddTicks(5130), "器械1的描述", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 99, 0.0, "超声刀头510", "45656dadasdas" },
                    { 12, new DateTime(2024, 7, 19, 15, 20, 22, 147, DateTimeKind.Local).AddTicks(5130), "器械1的描述", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 99, 0.0, "超声刀头510", "45656dadasdas" },
                    { 13, new DateTime(2024, 7, 19, 15, 20, 22, 147, DateTimeKind.Local).AddTicks(5131), "器械1的描述", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 99, 0.0, "超声刀头510", "45656dadasdas" },
                    { 14, new DateTime(2024, 7, 19, 15, 20, 22, 147, DateTimeKind.Local).AddTicks(5133), "器械1的描述", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 99, 0.0, "超声刀头510", "45656dadasdas" },
                    { 15, new DateTime(2024, 7, 19, 15, 20, 22, 147, DateTimeKind.Local).AddTicks(5134), "器械1的描述", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 99, 0.0, "超声刀头510", "45656dadasdas" },
                    { 16, new DateTime(2024, 7, 19, 15, 20, 22, 147, DateTimeKind.Local).AddTicks(5132), "器械1的描述", new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 99, 0.0, "超声刀头510", "45656dadasdas" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_instruments",
                table: "instruments");

            migrationBuilder.DeleteData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.RenameTable(
                name: "instruments",
                newName: "Instruments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instruments",
                table: "Instruments",
                column: "Id");
        }
    }
}
