using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InstrumentInformation.Migrations
{
    /// <inheritdoc />
    public partial class InitDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Instruments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InstrumentTypeId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Length = table.Column<double>(type: "double", nullable: false),
                    SerialNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedDatetime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ExpiredDatetime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instruments", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "instrument_types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instrument_types", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "instrument_types",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 47, "荧光内窥镜9L" },
                    { 48, "荧光内窥镜9S" },
                    { 49, "电子腹腔镜" },
                    { 59, "单孔电子腹腔镜" },
                    { 65, "大号持针钳490" },
                    { 66, "大号持针钳520" },
                    { 67, "大号持针钳550" },
                    { 68, "特大号持针钳490" },
                    { 69, "特大号持针钳520" },
                    { 70, "特大号持针钳550" },
                    { 71, "大力抓取钳500" },
                    { 72, "大力抓取钳530" },
                    { 73, "大力抓取钳560" },
                    { 74, "圆头抓取钳500" },
                    { 75, "圆头抓取钳530" },
                    { 76, "圆头抓取钳560" },
                    { 77, "直剪刀490" },
                    { 78, "直剪刀520" },
                    { 79, "直剪刀550" },
                    { 80, "弯剪刀490" },
                    { 81, "弯剪刀520" },
                    { 82, "弯剪刀550" },
                    { 83, "单极弧剪490" },
                    { 84, "单极弧剪520" },
                    { 85, "单极弧剪550" },
                    { 86, "单极电钩490" },
                    { 87, "单极电钩520" },
                    { 88, "单极电钩550" },
                    { 89, "单极电铲500" },
                    { 90, "单极电铲530" },
                    { 91, "单极电铲560" },
                    { 92, "双极尖头抓钳500" },
                    { 93, "双极尖头抓钳530" },
                    { 94, "双极尖头抓钳560" },
                    { 95, "双极圆头抓钳500" },
                    { 96, "双极圆头抓钳530" },
                    { 97, "双极圆头抓钳560" },
                    { 98, "超声刀头550" },
                    { 99, "超声刀头510" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instruments");

            migrationBuilder.DropTable(
                name: "instrument_types");
        }
    }
}
