using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EB3.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddRomanNumerolsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RomanNumerals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numeral = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HinduArabicNumeral = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RomanNumerals", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RomanNumerals");
        }
    }
}
