using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TraversolCoreProje.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_update_VisitorTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Visitors");

            migrationBuilder.DropColumn(
                name: "Mail",
                table: "Visitors");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Visitors");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Visitors");

            migrationBuilder.AlterColumn<int>(
                name: "City",
                table: "Visitors",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Visitors",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "Visitors");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Visitors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Visitors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mail",
                table: "Visitors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Visitors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Visitors",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
