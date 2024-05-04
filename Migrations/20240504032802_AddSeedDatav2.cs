using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace notesApp.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedDatav2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NoteItems",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "NoteItems",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "NoteItems",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "NoteItems",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "NoteItems",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.InsertData(
                table: "NoteItems",
                columns: new[] { "Id", "Date", "Text" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 3, 23, 28, 1, 767, DateTimeKind.Local).AddTicks(8535), "First note" },
                    { 2, new DateTime(2024, 5, 3, 23, 28, 1, 767, DateTimeKind.Local).AddTicks(8586), "Second note" },
                    { 3, new DateTime(2024, 5, 3, 23, 28, 1, 767, DateTimeKind.Local).AddTicks(8588), "Third note" },
                    { 4, new DateTime(2024, 5, 3, 23, 28, 1, 767, DateTimeKind.Local).AddTicks(8589), "Fourth note" },
                    { 5, new DateTime(2024, 5, 3, 23, 28, 1, 767, DateTimeKind.Local).AddTicks(8591), "Fifth note" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NoteItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NoteItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NoteItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NoteItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NoteItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "NoteItems",
                columns: new[] { "Id", "Date", "Text" },
                values: new object[,]
                {
                    { -5, new DateTime(2024, 5, 3, 23, 24, 21, 631, DateTimeKind.Local).AddTicks(2130), "Fifth note" },
                    { -4, new DateTime(2024, 5, 3, 23, 24, 21, 631, DateTimeKind.Local).AddTicks(2128), "Fourth note" },
                    { -3, new DateTime(2024, 5, 3, 23, 24, 21, 631, DateTimeKind.Local).AddTicks(2127), "Third note" },
                    { -2, new DateTime(2024, 5, 3, 23, 24, 21, 631, DateTimeKind.Local).AddTicks(2124), "Second note" },
                    { -1, new DateTime(2024, 5, 3, 23, 24, 21, 631, DateTimeKind.Local).AddTicks(2075), "First note" }
                });
        }
    }
}
