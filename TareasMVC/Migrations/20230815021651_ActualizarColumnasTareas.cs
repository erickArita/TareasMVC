using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMVC.Migrations
{
    /// <inheritdoc />
    public partial class ActualizarColumnasTareas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "Tareas",
                newName: "titulo");

            migrationBuilder.RenameColumn(
                name: "Orden",
                table: "Tareas",
                newName: "orden");

            migrationBuilder.RenameColumn(
                name: "FechaCreacion",
                table: "Tareas",
                newName: "fechaCreacion");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Tareas",
                newName: "descripcion");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tareas",
                newName: "id");

            migrationBuilder.AlterColumn<string>(
                name: "titulo",
                table: "Tareas",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "titulo",
                table: "Tareas",
                newName: "Titulo");

            migrationBuilder.RenameColumn(
                name: "orden",
                table: "Tareas",
                newName: "Orden");

            migrationBuilder.RenameColumn(
                name: "fechaCreacion",
                table: "Tareas",
                newName: "FechaCreacion");

            migrationBuilder.RenameColumn(
                name: "descripcion",
                table: "Tareas",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Tareas",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Tareas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);
        }
    }
}
