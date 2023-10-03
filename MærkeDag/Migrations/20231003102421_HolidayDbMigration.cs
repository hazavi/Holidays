using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MærkeDag.Migrations
{
    /// <inheritdoc />
    public partial class HolidayDbMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Birth",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Birth", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Holiday",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holiday", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Holiday",
                columns: new[] { "ID", "Date", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nytårsdag" },
                    { 2, new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Skærtorsdag" },
                    { 3, new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Langfredag" },
                    { 4, new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Påskedag" },
                    { 5, new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "2. Påskedag" },
                    { 6, new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Store bededag" },
                    { 7, new DateTime(2023, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kristi Himmelfartsdag" },
                    { 8, new DateTime(2023, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Banklukkedag" },
                    { 9, new DateTime(2023, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pinsedag" },
                    { 10, new DateTime(2023, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "2. Pinsedag" },
                    { 11, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grundlovsdag" },
                    { 12, new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juleaftensdag" },
                    { 13, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Juledag / 1. juledag" },
                    { 14, new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "2. juledag" },
                    { 15, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nytårsaftensdag" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Birth");

            migrationBuilder.DropTable(
                name: "Holiday");
        }
    }
}
