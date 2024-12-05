using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TraversolCoreProje.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_update_VisitorTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "VisitorDate",
                table: "Visitors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VisitorDate",
                table: "Visitors");
        }
    }
}
