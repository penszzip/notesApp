using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace notesApp.Migrations
{
    /// <inheritdoc />
    public partial class AddDateRemoveTitle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "NoteItems");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "NoteItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "NoteItems");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "NoteItems",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
