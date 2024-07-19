using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstrumentInformation.Migrations
{
    /// <inheritdoc />
    public partial class UpdateInsrtumentSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDatetime",
                table: "instruments");

            migrationBuilder.DropColumn(
                name: "ExpiredDatetime",
                table: "instruments");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "instruments",
                type: "DATE",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiredDate",
                table: "instruments",
                type: "DATE",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UsableCount",
                table: "instruments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ExpiredDate", "UsableCount" },
                values: new object[] { new DateTime(2024, 7, 19, 16, 11, 18, 499, DateTimeKind.Local).AddTicks(7993), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10 });

            migrationBuilder.UpdateData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ExpiredDate", "UsableCount" },
                values: new object[] { new DateTime(2024, 7, 19, 16, 11, 18, 499, DateTimeKind.Local).AddTicks(8004), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10 });

            migrationBuilder.UpdateData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ExpiredDate", "UsableCount" },
                values: new object[] { new DateTime(2024, 7, 19, 16, 11, 18, 499, DateTimeKind.Local).AddTicks(8005), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10 });

            migrationBuilder.UpdateData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ExpiredDate", "UsableCount" },
                values: new object[] { new DateTime(2024, 7, 19, 16, 11, 18, 499, DateTimeKind.Local).AddTicks(8006), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10 });

            migrationBuilder.UpdateData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ExpiredDate", "UsableCount" },
                values: new object[] { new DateTime(2024, 7, 19, 16, 11, 18, 499, DateTimeKind.Local).AddTicks(8007), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10 });

            migrationBuilder.UpdateData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ExpiredDate", "UsableCount" },
                values: new object[] { new DateTime(2024, 7, 19, 16, 11, 18, 499, DateTimeKind.Local).AddTicks(8008), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10 });

            migrationBuilder.UpdateData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ExpiredDate", "UsableCount" },
                values: new object[] { new DateTime(2024, 7, 19, 16, 11, 18, 499, DateTimeKind.Local).AddTicks(8009), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10 });

            migrationBuilder.UpdateData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ExpiredDate", "UsableCount" },
                values: new object[] { new DateTime(2024, 7, 19, 16, 11, 18, 499, DateTimeKind.Local).AddTicks(8009), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10 });

            migrationBuilder.UpdateData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ExpiredDate", "UsableCount" },
                values: new object[] { new DateTime(2024, 7, 19, 16, 11, 18, 499, DateTimeKind.Local).AddTicks(8010), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10 });

            migrationBuilder.UpdateData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ExpiredDate", "UsableCount" },
                values: new object[] { new DateTime(2024, 7, 19, 16, 11, 18, 499, DateTimeKind.Local).AddTicks(8011), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10 });

            migrationBuilder.UpdateData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ExpiredDate", "UsableCount" },
                values: new object[] { new DateTime(2024, 7, 19, 16, 11, 18, 499, DateTimeKind.Local).AddTicks(8012), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10 });

            migrationBuilder.UpdateData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ExpiredDate", "UsableCount" },
                values: new object[] { new DateTime(2024, 7, 19, 16, 11, 18, 499, DateTimeKind.Local).AddTicks(8013), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10 });

            migrationBuilder.UpdateData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ExpiredDate", "UsableCount" },
                values: new object[] { new DateTime(2024, 7, 19, 16, 11, 18, 499, DateTimeKind.Local).AddTicks(8014), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10 });

            migrationBuilder.UpdateData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ExpiredDate", "UsableCount" },
                values: new object[] { new DateTime(2024, 7, 19, 16, 11, 18, 499, DateTimeKind.Local).AddTicks(8015), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10 });

            migrationBuilder.UpdateData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ExpiredDate", "UsableCount" },
                values: new object[] { new DateTime(2024, 7, 19, 16, 11, 18, 499, DateTimeKind.Local).AddTicks(8016), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10 });

            migrationBuilder.UpdateData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ExpiredDate", "UsableCount" },
                values: new object[] { new DateTime(2024, 7, 19, 16, 11, 18, 499, DateTimeKind.Local).AddTicks(8015), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999), 10 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "instruments");

            migrationBuilder.DropColumn(
                name: "ExpiredDate",
                table: "instruments");

            migrationBuilder.DropColumn(
                name: "UsableCount",
                table: "instruments");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDatetime",
                table: "instruments",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiredDatetime",
                table: "instruments",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDatetime", "ExpiredDatetime" },
                values: new object[] { new DateTime(2024, 7, 19, 15, 20, 22, 147, DateTimeKind.Local).AddTicks(5109), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDatetime", "ExpiredDatetime" },
                values: new object[] { new DateTime(2024, 7, 19, 15, 20, 22, 147, DateTimeKind.Local).AddTicks(5121), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDatetime", "ExpiredDatetime" },
                values: new object[] { new DateTime(2024, 7, 19, 15, 20, 22, 147, DateTimeKind.Local).AddTicks(5122), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDatetime", "ExpiredDatetime" },
                values: new object[] { new DateTime(2024, 7, 19, 15, 20, 22, 147, DateTimeKind.Local).AddTicks(5123), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDatetime", "ExpiredDatetime" },
                values: new object[] { new DateTime(2024, 7, 19, 15, 20, 22, 147, DateTimeKind.Local).AddTicks(5124), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDatetime", "ExpiredDatetime" },
                values: new object[] { new DateTime(2024, 7, 19, 15, 20, 22, 147, DateTimeKind.Local).AddTicks(5125), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDatetime", "ExpiredDatetime" },
                values: new object[] { new DateTime(2024, 7, 19, 15, 20, 22, 147, DateTimeKind.Local).AddTicks(5126), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDatetime", "ExpiredDatetime" },
                values: new object[] { new DateTime(2024, 7, 19, 15, 20, 22, 147, DateTimeKind.Local).AddTicks(5127), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDatetime", "ExpiredDatetime" },
                values: new object[] { new DateTime(2024, 7, 19, 15, 20, 22, 147, DateTimeKind.Local).AddTicks(5128), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDatetime", "ExpiredDatetime" },
                values: new object[] { new DateTime(2024, 7, 19, 15, 20, 22, 147, DateTimeKind.Local).AddTicks(5129), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDatetime", "ExpiredDatetime" },
                values: new object[] { new DateTime(2024, 7, 19, 15, 20, 22, 147, DateTimeKind.Local).AddTicks(5130), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDatetime", "ExpiredDatetime" },
                values: new object[] { new DateTime(2024, 7, 19, 15, 20, 22, 147, DateTimeKind.Local).AddTicks(5130), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDatetime", "ExpiredDatetime" },
                values: new object[] { new DateTime(2024, 7, 19, 15, 20, 22, 147, DateTimeKind.Local).AddTicks(5131), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDatetime", "ExpiredDatetime" },
                values: new object[] { new DateTime(2024, 7, 19, 15, 20, 22, 147, DateTimeKind.Local).AddTicks(5133), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDatetime", "ExpiredDatetime" },
                values: new object[] { new DateTime(2024, 7, 19, 15, 20, 22, 147, DateTimeKind.Local).AddTicks(5134), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });

            migrationBuilder.UpdateData(
                table: "instruments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDatetime", "ExpiredDatetime" },
                values: new object[] { new DateTime(2024, 7, 19, 15, 20, 22, 147, DateTimeKind.Local).AddTicks(5132), new DateTime(9999, 12, 31, 23, 59, 59, 999, DateTimeKind.Unspecified).AddTicks(9999) });
        }
    }
}
