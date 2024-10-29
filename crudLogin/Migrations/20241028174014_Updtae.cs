using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace crudLogin.Migrations
{
    /// <inheritdoc />
    public partial class Updtae : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SKU",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "currency",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "pictures",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "price",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SKU",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "currency",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "pictures",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "price",
                table: "Productos");
        }
    }
}
