﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bug_Tracker_Web.Migrations
{
    /// <inheritdoc />
    public partial class AddDescriptionTickets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Tickets");
        }
    }
}