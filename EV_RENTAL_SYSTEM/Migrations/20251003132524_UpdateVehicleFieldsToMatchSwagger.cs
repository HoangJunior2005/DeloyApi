﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EV_RENTAL_SYSTEM.Migrations
{
    /// <inheritdoc />
    public partial class UpdateVehicleFieldsToMatchSwagger : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Daily_rate",
                table: "Vehicle",
                newName: "Price_per_day");

            migrationBuilder.AddColumn<decimal>(
                name: "Battery",
                table: "Vehicle",
                type: "numeric(5,2)",
                nullable: true);

            // Charging_time is not needed for Vehicle

            migrationBuilder.AddColumn<int>(
                name: "Range_km",
                table: "Vehicle",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Vehicle",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vehicle_image",
                table: "Vehicle",
                type: "character varying(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Station_Id",
                table: "Vehicle",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_Station_Id",
                table: "Vehicle",
                column: "Station_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Station_Station_Id",
                table: "Vehicle",
                column: "Station_Id",
                principalTable: "Station",
                principalColumn: "Station_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Station_Station_Id",
                table: "Vehicle");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_Station_Id",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "Battery",
                table: "Vehicle");

            // Charging_time was not added, so no need to drop it

            migrationBuilder.DropColumn(
                name: "Range_km",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "Station_Id",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "Vehicle_image",
                table: "Vehicle");

            migrationBuilder.RenameColumn(
                name: "Price_per_day",
                table: "Vehicle",
                newName: "Daily_rate");
        }
    }
}
