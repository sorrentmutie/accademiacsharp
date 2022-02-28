using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoMVC.Models.Migrations
{
    public partial class Artisti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artisti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artisti", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DateTour",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Indirizzo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArtistaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateTour", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DateTour_Artisti_ArtistaId",
                        column: x => x.ArtistaId,
                        principalTable: "Artisti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DateTour_ArtistaId",
                table: "DateTour",
                column: "ArtistaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DateTour");

            migrationBuilder.DropTable(
                name: "Artisti");
        }
    }
}
