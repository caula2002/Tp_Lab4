using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tp_Peliculas.Migrations
{
    /// <inheritdoc />
    public partial class Cambios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actores_PeliculasActores_PeliculaActoresId",
                table: "Actores");

            migrationBuilder.DropForeignKey(
                name: "FK_Generos_Peliculas_PeliculaId",
                table: "Generos");

            migrationBuilder.DropForeignKey(
                name: "FK_Peliculas_PeliculasActores_PeliculaActoresId",
                table: "Peliculas");

            migrationBuilder.DropIndex(
                name: "IX_Peliculas_PeliculaActoresId",
                table: "Peliculas");

            migrationBuilder.DropIndex(
                name: "IX_Generos_PeliculaId",
                table: "Generos");

            migrationBuilder.DropIndex(
                name: "IX_Actores_PeliculaActoresId",
                table: "Actores");

            migrationBuilder.DropColumn(
                name: "PeliculaActoresId",
                table: "Peliculas");

            migrationBuilder.DropColumn(
                name: "PeliculaId",
                table: "Generos");

            migrationBuilder.DropColumn(
                name: "PeliculaActoresId",
                table: "Actores");

            migrationBuilder.AddColumn<int>(
                name: "ActoresId",
                table: "PeliculasActores",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "FechaEstreno",
                table: "Peliculas",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateIndex(
                name: "IX_PeliculasActores_ActoresId",
                table: "PeliculasActores",
                column: "ActoresId");

            migrationBuilder.CreateIndex(
                name: "IX_PeliculasActores_PeliculaId",
                table: "PeliculasActores",
                column: "PeliculaId");

            migrationBuilder.CreateIndex(
                name: "IX_Peliculas_GeneroId",
                table: "Peliculas",
                column: "GeneroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Peliculas_Generos_GeneroId",
                table: "Peliculas",
                column: "GeneroId",
                principalTable: "Generos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeliculasActores_Actores_ActoresId",
                table: "PeliculasActores",
                column: "ActoresId",
                principalTable: "Actores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PeliculasActores_Peliculas_PeliculaId",
                table: "PeliculasActores",
                column: "PeliculaId",
                principalTable: "Peliculas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Peliculas_Generos_GeneroId",
                table: "Peliculas");

            migrationBuilder.DropForeignKey(
                name: "FK_PeliculasActores_Actores_ActoresId",
                table: "PeliculasActores");

            migrationBuilder.DropForeignKey(
                name: "FK_PeliculasActores_Peliculas_PeliculaId",
                table: "PeliculasActores");

            migrationBuilder.DropIndex(
                name: "IX_PeliculasActores_ActoresId",
                table: "PeliculasActores");

            migrationBuilder.DropIndex(
                name: "IX_PeliculasActores_PeliculaId",
                table: "PeliculasActores");

            migrationBuilder.DropIndex(
                name: "IX_Peliculas_GeneroId",
                table: "Peliculas");

            migrationBuilder.DropColumn(
                name: "ActoresId",
                table: "PeliculasActores");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaEstreno",
                table: "Peliculas",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AddColumn<int>(
                name: "PeliculaActoresId",
                table: "Peliculas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PeliculaId",
                table: "Generos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PeliculaActoresId",
                table: "Actores",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Peliculas_PeliculaActoresId",
                table: "Peliculas",
                column: "PeliculaActoresId");

            migrationBuilder.CreateIndex(
                name: "IX_Generos_PeliculaId",
                table: "Generos",
                column: "PeliculaId");

            migrationBuilder.CreateIndex(
                name: "IX_Actores_PeliculaActoresId",
                table: "Actores",
                column: "PeliculaActoresId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actores_PeliculasActores_PeliculaActoresId",
                table: "Actores",
                column: "PeliculaActoresId",
                principalTable: "PeliculasActores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Generos_Peliculas_PeliculaId",
                table: "Generos",
                column: "PeliculaId",
                principalTable: "Peliculas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Peliculas_PeliculasActores_PeliculaActoresId",
                table: "Peliculas",
                column: "PeliculaActoresId",
                principalTable: "PeliculasActores",
                principalColumn: "Id");
        }
    }
}
