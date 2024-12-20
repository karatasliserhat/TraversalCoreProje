﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TraversolCoreProje.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_Update_ReservationTable_DeleteColumnDestionation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Destination",
                table: "Reservations");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Destination",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
